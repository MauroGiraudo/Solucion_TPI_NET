using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Windows_Forms.FormPagPrin;

namespace Windows_Forms
{
    public partial class FrmProductos : Form
    {
        private FormPagPrin _formPagPrin;
        public string vistaActual;
        public FrmProductos(FormPagPrin formPagPrin, string vista)
        {
            InitializeComponent();
            _formPagPrin = formPagPrin;
            vistaActual = vista;
        }
        public FrmProductos(string vista)
        {
            InitializeComponent();
            vistaActual = vista;
        }
        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_productos.Columns["borrar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                                                    "Confirmar Borrado",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dgv_productos.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Vista(vistaActual);
        }
        private void Vista(string vista)
        {
            switch (vistaActual)
            {
                case "ver":
                    dgv_productos.Columns["agregarStock"].Visible = false;
                    break;
                case "agregar":
                    dgv_productos.Columns["borrar"].Visible = false;
                    break;
            }
        }
        private List<int> ObtenerIdsSeleccionados()
        {
            List<int> idsSeleccionados = new List<int>();

            foreach (DataGridViewRow row in dgv_productos.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["agregarStock"].Value);

                if (isChecked)
                {
                    int idPrenda = Convert.ToInt32(row.Cells["idPrenda"].Value);
                    idsSeleccionados.Add(idPrenda);
                }
            }

            return idsSeleccionados;
        }

        private void btn_agregarStock_Click(object sender, EventArgs e)
        {
            List<int> productosSeleccionados = ObtenerIdsSeleccionados();
            _formPagPrin.AbrirFormulario(new FrmAgregarStock(productosSeleccionados));
        }
    }
}
