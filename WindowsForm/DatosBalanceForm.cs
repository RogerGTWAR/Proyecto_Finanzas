using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.IRepository;
using WindowsForm.Models;
using WindowsForm.Repository;

namespace WindowsForm
{
    public partial class DatosBalanceForm : Form
    {
        private readonly IRepository<DatosBalanceG> balanceIDRepository;
        public DatosBalanceForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            balanceIDRepository = new BalanceRepository(connectionString);
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                var balanceIds = balanceIDRepository.GetAll().ToList();
                dgvBalance.DataSource = balanceIds;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos de Balance General");
            }
        }

        private void CrearBalanceID_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DatosBalanceG newBalance = new DatosBalanceG
                {
                    NombreBG = txtNombreBalance.Text,
                    FechaInicio = dtpFechaInicio.Value,
                    Fechafin = dtpFechaFin.Value
                };

                balanceIDRepository.Add(newBalance);
                RefreshData();
                txtNombreBalance.Clear();
                dtpFechaInicio.Value = DateTime.Now;
                dtpFechaFin.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Balance General: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBalance.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvBalance.SelectedRows[0].Cells["ID_DatosBalance"].Value);
                    balanceIDRepository.Delete(id);
                    RefreshData();
                    MessageBox.Show("Balance eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un balance para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el balance: " + ex.Message);
            }
        }
    }
}
