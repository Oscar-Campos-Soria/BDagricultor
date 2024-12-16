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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                // Crear un nuevo objeto cliente con los valores ingresados
                Cliente cliente = new Cliente
                {
                    nombreCliente = txtNombreCliente.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text
                };

                // Llamar al método para agregar cliente
                int resultado = PersonaDat.AgregarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente agregado exitosamente.");
                    CargarClientes(); // Refrescar el DataGridView
                }
                else
                {
                    MessageBox.Show("Error al agregar el cliente.");
                }

                // Limpiar los campos después de guardar
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    // Obtener el ID del cliente seleccionado
                    int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["idCliente"].Value);

                    // Llamar al método para eliminar cliente
                    int resultado = PersonaDat.EliminarCliente(idCliente);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente eliminado exitosamente.");
                        CargarClientes(); // Refrescar el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        public void FormCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();


        }
        private void CargarClientes()
        {
            try
            {
                dgvClientes.DataSource = PersonaDat.MostrarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
    }

}