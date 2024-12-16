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
    public partial class Form1 : Form
    {
        private bool isInitializing = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Persona persona = new Persona();
                persona.nombre = txtNombre.Text;
                persona.edad = Convert.ToInt32(txtEdad.Text);
                persona.experiencia = txtExperiencia.Text;

                // Obtener el ID de la fila seleccionada, si existe
                int id = 0;
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    id = Convert.ToInt32(txtID.Text);
                }

                int result = 0;

                // Si no hay ID (registro nuevo), agregar
                if (id == 0)
                {
                    result = PersonaDat.AgregarPersona(persona);

                    if (result > 0)
                    {
                        MessageBox.Show("Éxito al guardar");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar");
                    }
                }
                else
                {
                    // Si hay ID (registro existente), modificar
                    persona.id = id;
                    result = PersonaDat.ModificarPersona(persona);

                    if (result > 0)
                    {
                        MessageBox.Show("Éxito al modificar");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar");
                    }
                }

                // Refrescar la pantalla después de guardar o modificar
                refresspantalla();
                ClearInputs();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresspantalla();
            txtID.Enabled = false; // Deshabilitar el campo de ID

            ClearInputs(); // Limpiar los campos al cargar el formulario

            isInitializing = false; // Indicar que la inicialización ha terminado
        }
        public void refresspantalla()
        {
            dataGridView1.DataSource = PersonaDat.PresentarRegistro();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Evitar que el evento se dispare durante la inicialización
            if (isInitializing || dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["id"].Value == null)
            {
                return;
            }

            txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);
            txtEdad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Edad"].Value);
            txtExperiencia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Experiencia"].Value);

        }
        private void ClearInputs()
        {
            // Limpia los campos de entrada para permitir agregar un nuevo registro
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtExperiencia.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Obtener el ID de la fila seleccionada
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                // Llamar al método para eliminar
                int resultado = PersonaDat.EliminarPersona(id);

                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("Error al eliminar. Verifica que el registro exista.");
                }

                // Refrescar el DataGridView y limpiar campos
                refresspantalla();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FormCultivo formCultivo = new FormCultivo();
            formCultivo.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();

        }

        private void btnProvedor_Click(object sender, EventArgs e)
        {
            FormProveedor formProveedor = new FormProveedor();
            formProveedor.Show();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            FormProduccion formProduccion = new FormProduccion();
            formProduccion.Show();
        }

        private void btnPlagas_Click(object sender, EventArgs e)
        {
            FormPlaga formPlaga = new FormPlaga();
            formPlaga.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            formPedido.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVenta formVenta = new FormVenta();
            formVenta.Show();

        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            FormGasto formGasto = new FormGasto();
            formGasto.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleado formEmpleado = new FormEmpleado();
            formEmpleado.Show();
        }
    }

}
