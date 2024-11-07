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
using WindowsForm.Models;
using WindowsForm.Repository;

namespace WindowsForm
{
    public partial class CrearNumeroDeBalance : Form
    {
        private readonly IRepository<NumeroDeBalances> balanceIDRepository;
        public CrearNumeroDeBalance()
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
                MessageBox.Show("Error al cargar los datos de BalanceID");
            }
        }

        private void CrearBalanceID_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroDeBalance;
                if (int.TryParse(txtNumeroDeBalance.Text, out numeroDeBalance))
                {
                    NumeroDeBalances newBalanceID = new NumeroDeBalances
                    {
                        NumeroDeBalance = numeroDeBalance,
                    };
                    balanceIDRepository.Add(newBalanceID);
                    RefreshData();
                    txtNumeroDeBalance.Clear();
                }
                else
                {
                    MessageBox.Show("El número de balance no es válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Numero de Balance: " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBalance.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvBalance.SelectedRows[0].Cells["ID"].Value);
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
