using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDagricultor
{
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarPedidos();
        }
        private void CargarProveedores()
        {
            try
            {
                List<Proveedor> listaProveedores = PersonaDat.MostrarProveedores();
                cmbIdProvedor.DataSource = listaProveedores;
                cmbIdProvedor.DisplayMember = "nombreProveedor";
                cmbIdProvedor.ValueMember = "idProveedor";
                cmbIdProvedor.SelectedIndex = -1; // Deseleccionar por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}");
            }
        }

        private void CargarPedidos()
        {
            try
            {
                dgvPedido.DataSource = PersonaDat.MostrarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pedidos: {ex.Message}");
            }
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = new Pedido
                {
                    fechaPedido = dtpFechaPedido.Value,
                    cantidad = Convert.ToDecimal(txtCantidad.Text),
                    idProveedor = Convert.ToInt32(cmbIdProvedor.SelectedValue)
                };

                int resultado = PersonaDat.AgregarPedido(pedido);

                if (resultado > 0)
                {
                    MessageBox.Show("Pedido agregado exitosamente.");
                    CargarPedidos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el pedido.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }

        }

        private void bntEliminarPedido_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvPedido.SelectedRows.Count > 0)
                {
                    int idPedido = Convert.ToInt32(dgvPedido.CurrentRow.Cells["idPedido"].Value);
                    int resultado = PersonaDat.EliminarPedido(idPedido);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Pedido eliminado exitosamente.");
                        CargarPedidos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el pedido.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un pedido para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            dtpFechaPedido.Value = DateTime.Now;
            txtCantidad.Text = string.Empty;
            cmbIdProvedor.SelectedIndex = -1;
        }

    }
}
