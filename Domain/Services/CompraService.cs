using Domain.Model.Compras;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System.Reflection.PortableExecutable;

namespace Domain.Services
{
    public class CompraService
    {
        public CompraService()
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
        }
        public  void Add(Compra compra)
        {
            using var context = new TiendaRopaContext();

            context.Compras.Add(compra);
            context.SaveChanges();
        }

        /*public  void Update(Compra compra)
        {
            using var context = new TiendaRopaContext();

            Compra? compraToUpdate = context.Compras.Find(compra.IdUsu, compra.IdOperacion);

            if (compraToUpdate != null)
            {
                compraToUpdate.EstadoOperacion = compra.EstadoOperacion;
                context.SaveChanges();
            }
        }*/

        public void Update(Compra compra)
        {
            using var context = new TiendaRopaContext();
            context.Entry(compra).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public  void Delete(Compra compra)
        {
            using var context = new TiendaRopaContext();

            context.Compras.Remove(compra);
            context.SaveChanges();
        }

        public  Compra? GetOne(int IdUsu, int IdOperacion)
        {
            using var context = new TiendaRopaContext();
            return context.Compras.Find(IdUsu, IdOperacion);
        }

        public IEnumerable<Compra> GetEnProceso(int IdUsu)
        {
            using var context = new TiendaRopaContext();
            var compras = context.Compras.ToList();
            return from c in compras
                   where c.IdUsu == IdUsu && c.EstadoOperacion == "En Proceso"
                   select c;
        }

        public  IEnumerable<Compra> FindAll(int IdUsu)
        {
            using var context = new TiendaRopaContext();
            var compras = context.Compras.ToList();
            return from c in compras
                   where c.IdUsu == IdUsu
                   select c;
        }

        //Generación del PDF:
        public byte[] GeneratePDF(DetalleCompra detalleCompra)
        {
            var documento = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, QuestPDF.Infrastructure.Unit.Centimetre);

                    page.Header()
                        .Row(row =>
                        {
                            row.RelativeItem()
                            .AlignLeft()
                                .Column(column =>
                                {
                                    column.Item()
                                        .Text("Id de Compra: ")
                                        .FontFamily("Arial")
                                        .FontSize(15)
                                        .Bold();
                                    column.Item()
                                        .Text(detalleCompra.IdOperacion.ToString())
                                        .FontFamily("Arial")
                                        .FontSize(13)
                                        .AlignCenter();

                                });

                            row.RelativeItem()
                            .AlignCenter()
                                .Column(column =>
                                {
                                    column.Item()
                                        .Text("Fecha de Compra: ")
                                        .FontFamily("Arial")
                                        .FontSize(15)
                                        .Bold();
                                    column.Item()
                                        .Text(detalleCompra.FechaOperacion.ToString())
                                        .FontFamily("Arial")
                                        .FontSize(13)
                                        .AlignCenter();
                                });

                            row.RelativeItem()
                                .AlignRight()
                                .Column(column =>
                                {
                                    column.Item()
                                        .Text("Estado de Compra: ")
                                        .FontFamily("Arial")
                                        .FontSize(15)
                                        .Bold();
                                    column.Item()
                                        .Text(detalleCompra.EstadoOperacion)
                                        .FontFamily("Arial")
                                        .FontSize(13)
                                        .AlignCenter();
                                });
                        });

                    page.Content()
                        .PaddingTop(50)
                        .Column(column => 
                        {
                            column.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(50); //Nro Linea
                                    columns.RelativeColumn(); // Prenda
                                    columns.ConstantColumn(80); // Cantidad
                                    columns.ConstantColumn(80); // Precio
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Padding(4).Text("#");
                                    header.Cell().Padding(4).Text("Prenda");
                                    header.Cell().Padding(4).Text("Cantidad").AlignRight();
                                    header.Cell().Padding(4).Text("Precio").AlignRight();

                                    header.Cell()
                                        .ColumnSpan(4)
                                        .PaddingVertical(4)
                                        .BorderBottom(1)
                                        .BorderColor(Colors.Black);
                                });

                                for(var i = 0; i < detalleCompra.PrendaPedido.Count(); i++)
                                {
                                    var backgroundColor = i % 2 == 0 ? Colors.White : Colors.Grey.Lighten2;

                                    var item = detalleCompra.PrendaPedido[i];
                                    table.Cell().Background(backgroundColor).Padding(4).Text(item.NumeroLinea.ToString());
                                    table.Cell().Background(backgroundColor).Padding(4).Text(item.Prenda);
                                    table.Cell().Background(backgroundColor).Padding(4).Text(item.Cantidad.ToString()).AlignRight();
                                    table.Cell().Background(backgroundColor).Padding(4).Text("$" + item.Precio.ToString()).AlignRight();
                                }

                                table.Cell()
                                    .ColumnSpan(4)
                                    .PaddingVertical(4)
                                    .BorderBottom(1)
                                    .BorderColor(Colors.Black);
                                table.Cell().ColumnSpan(4).Text("Total").Bold().AlignRight();
                                float total = detalleCompra.PrendaPedido.Sum(pp => pp.Precio);
                                if(detalleCompra.Bonificacion != null)
                                {
                                    total = total * (1 - detalleCompra.Bonificacion.ProporcionDescuento / 100);
                                }
                                table.Cell().ColumnSpan(4).Text("$" + total.ToString()).AlignRight();
                                    
                            });

                            if(detalleCompra.Bonificacion != null)
                            {
                                column.Item()
                                    .AlignRight()
                                    .PaddingTop(20)
                                    .Text("¡Usted ha recibido una bonificación del " + detalleCompra.Bonificacion.ProporcionDescuento + "%!")
                                    .FontColor(Colors.Red.Medium)
                                    .FontFamily("Arial")
                                    .FontSize(11)
                                    .Bold();
                            }

                        });

                    page.Footer()
                        .Column(column =>
                        {
                            column.Item()
                                .PaddingVertical(10)
                                .Text(text =>
                                {
                                    text.Span("Página ");
                                    text.CurrentPageNumber();
                                    text.Span(" de ");
                                    text.TotalPages();
                                    text.AlignCenter();
                                });
                        });

                });

            });

            //documento.ShowInCompanion();

            return documento.GeneratePdf();
        }
    }
}