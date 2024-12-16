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
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            CargarProducciones();
            CargarClientes();
            CargarVentas();
        }

        private void CargarProducciones()
        {
            try
            {
                List<Produccion> listaProducciones = PersonaDat.MostrarProducciones();
                cmbIdProduccion.DataSource = listaProducciones;
                cmbIdProduccion.DisplayMember = "cantidad"; // Campo a mostrar
                cmbIdProduccion.ValueMember = "idProduccion"; // Valor (ID) correspondiente
                cmbIdProduccion.SelectedIndex = -1; // Deseleccionar por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las producciones: {ex.Message}");
            }
        }
        private void CargarClientes()
        {
            try
            {
                List<Cliente> listaClientes = PersonaDat.MostrarClientes();
                cmbIdCliente.DataSource = listaClientes;
                cmbIdCliente.DisplayMember = "nombreCliente"; // Campo a mostrar
                cmbIdCliente.ValueMember = "idCliente"; // Valor (ID) correspondiente
                cmbIdCliente.SelectedIndex = -1; // Deseleccionar por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}");
            }
        }
        private void CargarVentas()
        {
            try
            {
                dgvVentas.DataSource = PersonaDat.MostrarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ventas: {ex.Message}");
            }
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                Venta venta = new Venta
                {
                    fechaVenta = dtpFechaVenta.Value,
                    cantidadVendida = Convert.ToDecimal(txtCantidadVendida.Text),
                    precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text),
                    idProduccion = Convert.ToInt32(cmbIdProduccion.SelectedValue),
                    idCliente = Convert.ToInt32(cmbIdCliente.SelectedValue)
                };

                int resultado = PersonaDat.AgregarVenta(venta);

                if (resultado > 0)
                {
                    MessageBox.Show("Venta agregada exitosamente.");
                    CargarVentas();
                }
                else
                {
                    MessageBox.Show("Error al agregar la venta.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void bntEliminarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVentas.SelectedRows.Count > 0)
                {
                    int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells["idVenta"].Value);
                    int resultado = PersonaDat.EliminarVenta(idVenta);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Venta eliminada exitosamente.");
                        CargarVentas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la venta.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una venta para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private void LimpiarCampos()
        {
            dtpFechaVenta.Value = DateTime.Now;
            txtCantidadVendida.Text = string.Empty;
            txtPrecioUnitario.Text = string.Empty;
            cmbIdProduccion.SelectedIndex = -1;
            cmbIdCliente.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

