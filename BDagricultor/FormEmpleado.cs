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
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            CargarAgricultores();
            CargarEmpleados();
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado
                {
                    nombreEmpleado = txtNombreEmpleado.Text,
                    puesto = txtPuesto.Text,
                    salario = Convert.ToDecimal(txtSalario.Text),
                    idAgricultor = Convert.ToInt32(cmbIdAgricultor.SelectedValue)
                };

                int resultado = PersonaDat.AgregarEmpleado(empleado);

                if (resultado > 0)
                {
                    MessageBox.Show("Empleado agregado exitosamente.");
                    CargarEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al agregar el empleado.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    int idEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["idEmpleado"].Value);

                    int resultado = PersonaDat.EliminarEmpleado(idEmpleado);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Empleado eliminado exitosamente.");
                        CargarEmpleados();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el empleado.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un empleado para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                dgvEmpleados.DataSource = PersonaDat.MostrarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los empleados: {ex.Message}");
            }
        }

        private void CargarAgricultores()
        {
            try
            {
                List<Persona> listaAgricultores = PersonaDat.PresentarRegistro();
                cmbIdAgricultor.DataSource = listaAgricultores;
                cmbIdAgricultor.DisplayMember = "nombre"; // Campo a mostrar
                cmbIdAgricultor.ValueMember = "id";      // Valor (ID) correspondiente
                cmbIdAgricultor.SelectedIndex = -1;      // Deseleccionar por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar agricultores: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtNombreEmpleado.Text = string.Empty;
            txtPuesto.Text = string.Empty;
            txtSalario.Text = string.Empty;
            cmbIdAgricultor.SelectedIndex = -1;
        }

    }
}
