using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Model.Prendas;
using Windows_Forms.Negocio;
using Windows_Forms.Shared;

namespace Windows_Forms
{
    public partial class form_altaPrenda : Form
    {
        public form_altaPrenda()
        {
            InitializeComponent();
            List<string> tallas = new List<string> { "S", "M", "L", "XL" };
            cb_talla.DataSource = tallas;
            cb_talla.SelectedItem = "S";
            Carga_CBTiposPrenda();
            Carga_CBMarcas();
        }
        public form_altaPrenda(Prenda prenda, PrecioPrenda precio)
        {
            InitializeComponent();
            Text = "Modificar Prenda";
            btn_aceptar.Text = "Modificar";
            txb_descripcion.Text = prenda.Descripcion;
            nud_stock.Value = prenda.Stock;
            nud_puntoPedido.Value = prenda.PuntoPedido;
            cb_talla.SelectedItem = prenda.Talla;
            cb_tipoPrenda.SelectedValue = prenda.IdTipoPrenda;
            cb_marca.SelectedValue = prenda.IdMarca;
            txb_precio.Text = precio.Valor.ToString();
            txb_precio.Enabled = false;
        }

        private Task<IEnumerable<TipoPrenda>>? tiposDePrenda;
        public IEnumerable<TipoPrenda> Carga_TiposPrenda()
        {
            tiposDePrenda = TipoPrendaNegocio.GetAll();
            return tiposDePrenda.Result;
        }
        private async void Carga_CBTiposPrenda()
        {
            Task<IEnumerable<TipoPrenda>> task = new Task<IEnumerable<TipoPrenda>>(Carga_TiposPrenda);
            task.Start();
            cb_tipoPrenda.DataSource = await task;
            cb_tipoPrenda.DisplayMember = "DescripcionTipoPrenda";
            cb_tipoPrenda.ValueMember = "IdTipoPrenda";
        }
        private Task<IEnumerable<Marca>>? marcas;
        public IEnumerable<Marca> Carga_Marcas()
        {
            marcas = MarcaNegocio.GetAll();
            return marcas.Result;
        }
        private async void Carga_CBMarcas()
        {
            Task<IEnumerable<Marca>> task = new Task<IEnumerable<Marca>>(Carga_Marcas);
            task.Start();
            cb_marca.DataSource = await task;
            cb_marca.DisplayMember = "DescripcionMarca";
            cb_marca.ValueMember = "IdMarca";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_aceptar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(txb_descripcion.Text))
            {
                errores.Add("El nombre de la prenda no puede estar vacío");
            }
            if (txb_descripcion.Text.Length > 50)
            {
                errores.Add("El nombre de la prenda no puede tener más de 50 caracteres");
            }
            if (nud_stock.Value < 0)
            {
                errores.Add("El stock no puede ser negativo");
            }
            if(nud_puntoPedido.Value <= 0)
            {
                errores.Add("El punto de pedido no puede ser menor o igual a 0");
            }
            if(int.Parse(txb_precio.Text) <= 0)
            {
                errores.Add("El precio de la prenda no puede ser menor o igual a 0");
            }
            if(errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Prenda prenda = new Prenda();
            prenda.Descripcion = Format.Capitalizar(txb_descripcion.Text);
            prenda.Stock = Convert.ToInt32(nud_stock.Value);
            prenda.PuntoPedido = Convert.ToInt32(nud_puntoPedido.Value);
            prenda.Talla = cb_talla.SelectedItem.ToString();
            prenda.IdTipoPrenda = Convert.ToInt32(cb_tipoPrenda.SelectedValue);
            prenda.IdMarca = Convert.ToInt32(cb_marca.SelectedValue);
            if(btn_aceptar.Text == "Modificar")
            {
                if(await PrendaNegocio.Update(prenda))
                {
                    MessageBox.Show("Prenda modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al modificar la prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(await PrendaNegocio.Add(prenda))
                {
                    Prenda newPrenda = await PrendaNegocio.GetOneByDescAndTalla(prenda.Descripcion, prenda.Talla);
                    PrecioPrenda precio = new PrecioPrenda();
                    precio.IdPrenda = newPrenda.IdPrenda;
                    precio.Valor = float.Parse(txb_precio.Text);
                    if(await PrecioPrendaNegocio.Add(precio))
                    {
                        MessageBox.Show("Prenda creada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el precio de la prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al crear la prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
