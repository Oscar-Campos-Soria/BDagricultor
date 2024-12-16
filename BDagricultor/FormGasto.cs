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
    public partial class FormGasto : Form
    {
        public FormGasto()
        {
            InitializeComponent();
        }

        private void FormGasto_Load(object sender, EventArgs e)
        {
            CargarCultivos();
            CargarGastos();
        }

        private void btnGuardarGasto_Click(object sender, EventArgs e)
        {
            try
            {
                Gasto gasto = new Gasto
                {
                    descripcion = txtDescripcion.Text,
                    monto = Convert.ToDecimal(txtMonto.Text),
                    fechaGasto = dtpFechadeGasto.Value,
                    idCultivo = Convert.ToInt32(cmbIdCultivos.SelectedValue)
                };

                int resultado = PersonaDat.AgregarGasto(gasto);

                if (resultado > 0)
                {
                    MessageBox.Show("Gasto agregado exitosamente.");
                    CargarGastos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el gasto.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvGastos.SelectedRows.Count > 0)
                {
                    int idGasto = Convert.ToInt32(dgvGastos.CurrentRow.Cells["idGasto"].Value);

                    int resultado = PersonaDat.EliminarGasto(idGasto);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Gasto eliminado exitosamente.");
                        CargarGastos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el gasto.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un gasto para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void CargarGastos()
        {
            try
            {
                dgvGastos.DataSource = PersonaDat.MostrarGastos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los gastos: {ex.Message}");
            }
        }

        private void CargarCultivos()
        {
            try
            {
                List<Cultivo> listaCultivos = PersonaDat.MostrarCultivos();
                cmbIdCultivos.DataSource = listaCultivos;
                cmbIdCultivos.DisplayMember = "nombreCultivo";
                cmbIdCultivos.ValueMember = "idCultivo";
                cmbIdCultivos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cultivos: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = string.Empty;
            txtMonto.Text = string.Empty;
            dtpFechadeGasto.Value = DateTime.Now;
            cmbIdCultivos.SelectedIndex = -1;
        }

    }
}
