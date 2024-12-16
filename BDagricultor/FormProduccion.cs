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
    public partial class FormProduccion : Form
    {
        public FormProduccion()
        {
            InitializeComponent();
        }

        private void btnGuardarProduccion_Click(object sender, EventArgs e)
        {
            try
            {
                Produccion produccion = new Produccion
                {
                    cantidad = Convert.ToDecimal(txtCantidadProducida.Text),
                    calidad = cmbCalidad.Text, // O txtCalidad.Text si usas TextBox
                    fechaProduccion = dtpFechaProduccion.Value,
                    idCultivo = Convert.ToInt32(cmbIdCultivo.SelectedValue)
                };

                int resultado = PersonaDat.AgregarProduccion(produccion);

                if (resultado > 0)
                {
                    MessageBox.Show("Producción agregada exitosamente.");
                    CargarProducciones();
                }
                else
                {
                    MessageBox.Show("Error al agregar la producción.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnEliminarProduccion_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvProduccion.SelectedRows.Count > 0)
                {
                    int idProduccion = Convert.ToInt32(dgvProduccion.CurrentRow.Cells["idProduccion"].Value);

                    int resultado = PersonaDat.EliminarProduccion(idProduccion);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Producción eliminada exitosamente.");
                        CargarProducciones();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la producción.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una producción para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void FormProduccion_Load(object sender, EventArgs e)
        {
            CargarCultivos();
            CargarProducciones();
        }

        public void CargarCultivos()
        {

            try
            {
                // Obtener lista de cultivos
                List<Cultivo> listaCultivos = PersonaDat.MostrarCultivos();

                // Configurar el ComboBox
                    cmbIdCultivo.DataSource = listaCultivos;
                cmbIdCultivo.DisplayMember = "nombreCultivo"; // Campo a mostrar
                cmbIdCultivo.ValueMember = "idCultivo";      // Valor (ID) correspondiente
                cmbIdCultivo.SelectedIndex = -1;            // Deseleccionar por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los cultivos: {ex.Message}");
            }
        }

        private void CargarProducciones()
        {
            try
            {
                dgvProduccion.DataSource = PersonaDat.MostrarProducciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar producciones: {ex.Message}");
            }
        }
        private void LimpiarCampos()
        {
            txtCantidadProducida.Text = string.Empty;
            cmbCalidad.SelectedIndex = -1; // Deselecciona cualquier valor en el ComboBox
            dtpFechaProduccion.Value = DateTime.Now; // Resetea la fecha al día actual
            cmbIdCultivo.SelectedIndex = -1; // Deselecciona cualquier valor en el ComboBox
        }

        private void cmbCalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
