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
using System.Windows.Media.TextFormatting;
using WindowsForm.IRepository;
using WindowsForm.IRepository.Repository;
using WindowsForm.Models;

namespace WindowsForm.Estado_de_Resultado_Forms
{
    public partial class Gastos : Form
    {
        public readonly IRepository<Gasto> gastosRepo;
        public readonly IRepository<DatosER> er;
        public readonly IRepository<ClasificacionER> clasificacionER;
        ClasificacionERRepository repo;
        DatosERRepository Er;


        public Gastos()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            gastosRepo = new GastosERRepository(connectionString);
            er = new DatosERRepository(connectionString);
            clasificacionER = new ClasificacionERRepository(connectionString);
            repo = new ClasificacionERRepository(connectionString);
            Er = new DatosERRepository(connectionString);
            RefreshData();

        }

        private void RefreshData()
        {
            try
            {
                var list = gastosRepo.GetAll().ToList();
                dgvGastos.DataSource = list;
                cboClasificacion.DataSource = repo.GetClasificacionesER().ToList();
                cboEstadoDeResult.DataSource = Er.GetNameER();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos de Estado de Resultado");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Gasto nuevoDato = new Gasto
                {
                    NombreDeCuenta = txtNombreCuenta.Text,
                    Monto = Convert.ToDecimal(txtMonto.Text),
                    ID_Clasificacion = Convert.ToInt32(repo.GetIdByDescrip(cboClasificacion.Text)),
                    ID_DatosER = Convert.ToInt32(Er.GetIdByName(cboEstadoDeResult.Text))
                };
                gastosRepo.Add(nuevoDato);
                RefreshData();
                txtMonto.Clear();
                txtNombreCuenta.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el gasto al estado resultado: ");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {
                var selected = (Gasto)dgvGastos.SelectedRows[0].DataBoundItem;
                var update = new Gasto
                {
                    ID_Gastos = selected.ID_Gastos,
                    ID_DatosER = Convert.ToInt32(Er.GetIdByName(cboEstadoDeResult.Text)),
                    ID_Clasificacion = Convert.ToInt32(repo.GetIdByDescrip(cboClasificacion.Text)),
                    NombreDeCuenta = txtNombreCuenta.Text,
                    Monto = Convert.ToDecimal(txtMonto.Text),
                };

                try
                {
                    gastosRepo.Update(update);
                    MessageBox.Show("¡Gasto actualizado exitosamente!", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMonto.Clear();
                    txtNombreCuenta.Clear();
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la cuenta: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Seleccione un gasto para actualizar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvGastos.Rows.Count > 0)
            {
                var selected = (Gasto)dgvGastos.SelectedRows[0].DataBoundItem;
                var result =
                     MessageBox.Show($"¿Está seguro de que desea eliminar el gasto '{selected.NombreDeCuenta}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        gastosRepo.Delete(selected.ID_Gastos);
                        MessageBox.Show("¡Gasto eliminado exitosamente!", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar gasto: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione un gasto para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void dgvGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var gasto = (Gasto)dgvGastos.Rows[e.RowIndex].DataBoundItem;
                txtNombreCuenta.Text = gasto.NombreDeCuenta;
                txtMonto.Text = gasto.Monto.ToString();
                
            }
        }
    }
}
