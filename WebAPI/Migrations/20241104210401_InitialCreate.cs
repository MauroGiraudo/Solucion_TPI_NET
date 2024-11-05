using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bonificaciones",
                columns: table => new
                {
                    IdBonificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadParaDescuento = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    ProporcionDescuento = table.Column<float>(type: "real", nullable: false),
                    FecVigenciaBonificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonificaciones", x => x.IdBonificacion);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdUsu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FecNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdUsu);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdUsu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FecNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdUsu);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionMarca = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "TiposPrenda",
                columns: table => new
                {
                    IdTipoPrenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionTipoPrenda = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPrenda", x => x.IdTipoPrenda);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    IdOperacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsu = table.Column<int>(type: "int", nullable: false),
                    FecOperacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoOperacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => new { x.IdUsu, x.IdOperacion });
                    table.ForeignKey(
                        name: "FK_Compras_Clientes_IdUsu",
                        column: x => x.IdUsu,
                        principalTable: "Clientes",
                        principalColumn: "IdUsu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cargas",
                columns: table => new
                {
                    IdOperacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsu = table.Column<int>(type: "int", nullable: false),
                    FecOperacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoOperacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargas", x => new { x.IdUsu, x.IdOperacion });
                    table.ForeignKey(
                        name: "FK_Cargas_Empleados_IdUsu",
                        column: x => x.IdUsu,
                        principalTable: "Empleados",
                        principalColumn: "IdUsu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prendas",
                columns: table => new
                {
                    IdPrenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    PuntoPedido = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Talla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTipoPrenda = table.Column<int>(type: "int", nullable: false),
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prendas", x => x.IdPrenda);
                    table.ForeignKey(
                        name: "FK_Prendas_Marcas_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marcas",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prendas_TiposPrenda_IdTipoPrenda",
                        column: x => x.IdTipoPrenda,
                        principalTable: "TiposPrenda",
                        principalColumn: "IdTipoPrenda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineasCarga",
                columns: table => new
                {
                    NumeroLinea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOperacion = table.Column<int>(type: "int", nullable: false),
                    IdUsu = table.Column<int>(type: "int", nullable: false),
                    CantidadPrenda = table.Column<int>(type: "int", nullable: false),
                    IdPrenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasCarga", x => new { x.IdOperacion, x.NumeroLinea });
                    table.ForeignKey(
                        name: "FK_LineasCarga_Cargas_IdUsu_IdOperacion",
                        columns: x => new { x.IdUsu, x.IdOperacion },
                        principalTable: "Cargas",
                        principalColumns: new[] { "IdUsu", "IdOperacion" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineasCarga_Prendas_IdPrenda",
                        column: x => x.IdPrenda,
                        principalTable: "Prendas",
                        principalColumn: "IdPrenda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineasCompra",
                columns: table => new
                {
                    NumeroLinea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOperacion = table.Column<int>(type: "int", nullable: false),
                    IdUsu = table.Column<int>(type: "int", nullable: false),
                    CantidadPrenda = table.Column<int>(type: "int", nullable: false),
                    IdPrenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasCompra", x => new { x.IdOperacion, x.NumeroLinea });
                    table.ForeignKey(
                        name: "FK_LineasCompra_Compras_IdUsu_IdOperacion",
                        columns: x => new { x.IdUsu, x.IdOperacion },
                        principalTable: "Compras",
                        principalColumns: new[] { "IdUsu", "IdOperacion" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineasCompra_Prendas_IdPrenda",
                        column: x => x.IdPrenda,
                        principalTable: "Prendas",
                        principalColumn: "IdPrenda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciosPrenda",
                columns: table => new
                {
                    IdPrenda = table.Column<int>(type: "int", nullable: false),
                    FecVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciosPrenda", x => new { x.IdPrenda, x.FecVigencia });
                    table.ForeignKey(
                        name: "FK_PreciosPrenda_Prendas_IdPrenda",
                        column: x => x.IdPrenda,
                        principalTable: "Prendas",
                        principalColumn: "IdPrenda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineasCarga_IdPrenda",
                table: "LineasCarga",
                column: "IdPrenda");

            migrationBuilder.CreateIndex(
                name: "IX_LineasCarga_IdUsu_IdOperacion",
                table: "LineasCarga",
                columns: new[] { "IdUsu", "IdOperacion" });

            migrationBuilder.CreateIndex(
                name: "IX_LineasCompra_IdPrenda",
                table: "LineasCompra",
                column: "IdPrenda");

            migrationBuilder.CreateIndex(
                name: "IX_LineasCompra_IdUsu_IdOperacion",
                table: "LineasCompra",
                columns: new[] { "IdUsu", "IdOperacion" });

            migrationBuilder.CreateIndex(
                name: "IX_Prendas_IdMarca",
                table: "Prendas",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Prendas_IdTipoPrenda",
                table: "Prendas",
                column: "IdTipoPrenda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bonificaciones");

            migrationBuilder.DropTable(
                name: "LineasCarga");

            migrationBuilder.DropTable(
                name: "LineasCompra");

            migrationBuilder.DropTable(
                name: "PreciosPrenda");

            migrationBuilder.DropTable(
                name: "Cargas");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Prendas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "TiposPrenda");
        }
    }
}
