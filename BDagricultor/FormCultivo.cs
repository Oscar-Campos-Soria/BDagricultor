using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDagricultor
{
    public partial class FormCultivo : Form
    {
        public FormCultivo()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNombreCultivo.Text = string.Empty;
            txtTemporada.Text = string.Empty;
            cmbIdAgricultor.SelectedIndex = -1; // Si usas un ComboBox para seleccionar Agricultores
        }

        private void RefrescarPantalla()
        {
            try
            {
                // Cargar los cultivos en el DataGridView
                dgvCultivos.DataSource = PersonaDat.MostrarCultivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al refrescar los datos: {ex.Message}");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si se ha seleccionado un valor válido en el ComboBox
                if (cmbIdAgricultor.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona un agricultor válido.");
                    return;
                }

                Cultivo cultivo = new Cultivo
                {
                    nombreCultivo = txtNombreCultivo.Text,
                    temporada = txtTemporada.Text,
                    idAgricultor = Convert.ToInt32(cmbIdAgricultor.SelectedValue) // Obtiene el ID del agricultor
                };

                int resultado = PersonaDat.AgregarCultivo(cultivo);
                if (resultado > 0)
                {
                    MessageBox.Show("Cultivo guardado con éxito");
                    RefrescarPantalla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar el cultivo");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Formato incorrecto: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void FormCultivo_Load(object sender, EventArgs e)
        {
            CargarCultivos();
            try
            {
                using (SqlConnection conexion = BDAgricultor.obtenerconexion())
                {
                    string query = "SELECT id, nombre FROM Agricultor";
                    SqlCommand command = new SqlCommand(query, conexion);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    cmbIdAgricultor.DataSource = dataTable;
                    cmbIdAgricultor.DisplayMember = "nombre"; // Muestra el nombre en el ComboBox
                    cmbIdAgricultor.ValueMember = "id";       // Usa el ID como valor
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar agricultores: {ex.Message}");
            }
        }

        private void btnEliminarCultivo_Click(object sender, EventArgs e)
        {

            try
            {
                // Verifica si hay una fila seleccionada en el DataGridView
                if (dgvCultivos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona un cultivo para eliminar.");
                    return;
                }

                // Obtén el ID del cultivo seleccionado en el DataGridView
                int idCultivo = Convert.ToInt32(dgvCultivos.SelectedRows[0].Cells["idCultivo"].Value);

                // Confirmar la eliminación
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este cultivo?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // Llama al método para eliminar el cultivo
                    int resultado = PersonaDat.EliminarCultivo(idCultivo);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cultivo eliminado con éxito.");
                        RefrescarPantalla(); // Refresca los datos en el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cultivo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void CargarCultivos()
        {
            try
            {
                // Obtiene los datos de la tabla Cultivo y los asigna al DataGridView
                dgvCultivos.DataSource = PersonaDat.MostrarCultivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los cultivos: {ex.Message}");
            }
        }
    }

}