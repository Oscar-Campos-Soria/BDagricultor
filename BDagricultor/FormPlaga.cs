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
    public partial class FormPlaga : Form
    {
        public FormPlaga()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormPlaga_Load(object sender, EventArgs e)
        {

            CargarCultivos();
            CargarPlagas();
        }
        private void CargarCultivos()
        {
            try
            {
                List<Cultivo> listaCultivos = PersonaDat.MostrarCultivos();
                cmbIdCultivo.DataSource = listaCultivos;
                cmbIdCultivo.DisplayMember = "nombreCultivo";
                cmbIdCultivo.ValueMember = "idCultivo";
                cmbIdCultivo.SelectedIndex = -1; // Deseleccionar por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cultivos: {ex.Message}");
            }
        }


        private void CargarPlagas()
        {
            try
            {
                dgvPlagas.DataSource = PersonaDat.MostrarPlagas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar plagas: {ex.Message}");
            }
        }

        private void btnGuardarPlaga_Click(object sender, EventArgs e)
        {

            try
            {
                Plaga plaga = new Plaga
                {
                    nombrePlaga = txtNombrePlaga.Text,
                    tipoPlaga = cmbTipoPlaga.Text,
                    nivelDanio = cmbNivelDaño.Text,
                    idCultivo = Convert.ToInt32(cmbIdCultivo.SelectedValue)
                };

                int resultado = PersonaDat.AgregarPlaga(plaga);

                if (resultado > 0)
                {
                    MessageBox.Show("Plaga agregada exitosamente.");
                    CargarPlagas();
                }
                else
                {
                    MessageBox.Show("Error al agregar la plaga.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnEliminarPlaga_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvPlagas.SelectedRows.Count > 0)
                {
                    int idPlaga = Convert.ToInt32(dgvPlagas.CurrentRow.Cells["idPlaga"].Value);
                    int resultado = PersonaDat.EliminarPlaga(idPlaga);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Plaga eliminada exitosamente.");
                        CargarPlagas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la plaga.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una plaga para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtNombrePlaga.Text = string.Empty;
            cmbTipoPlaga.SelectedIndex = -1;
            cmbNivelDaño.SelectedIndex = -1;
            cmbIdCultivo.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
