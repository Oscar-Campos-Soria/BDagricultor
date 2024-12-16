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
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        public void FormProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        public void btnGuardarProvedor_Click(object sender, EventArgs e)
        {

            try
            {
                Proveedor proveedor = new Proveedor
                {
                    nombreProveedor = txtNombreProvedor.Text,
                    telefono = txtTelefonoProvedor.Text,
                    direccion = txtDireccionProvedor.Text
                };

                int resultado = PersonaDat.AgregarProveedor(proveedor);

                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor agregado exitosamente.");
                    CargarProveedores();
                }
                else
                {
                    MessageBox.Show("Error al agregar el proveedor.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        public void btnEliminarProvedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedor.SelectedRows.Count > 0)
                {
                    int idProveedor = Convert.ToInt32(dgvProveedor.CurrentRow.Cells["idProveedor"].Value);

                    int resultado = PersonaDat.EliminarProveedor(idProveedor);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Proveedor eliminado exitosamente.");
                        CargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el proveedor.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un proveedor para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        public void CargarProveedores()
        {
            try
            {
                dgvProveedor.DataSource = PersonaDat.MostrarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtNombreProvedor.Text = string.Empty;
            txtTelefonoProvedor.Text = string.Empty;
            txtDireccionProvedor.Text = string.Empty;
        }

        private void txtNombreProvedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


