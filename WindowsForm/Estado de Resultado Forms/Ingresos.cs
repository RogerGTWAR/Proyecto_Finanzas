using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.IRepository.Repository;
using WindowsForm.IRepository;
using WindowsForm.Models;
using System.Configuration;

namespace WindowsForm.Estado_de_Resultado_Forms
{

    public partial class Ingresos : Form
    {
        public readonly IRepository<Ingreso> IngRepo;
        public readonly IRepository<DatosER> er;
        public readonly IRepository<ClasificacionER> clasificacionER;
        ClasificacionERRepository repo;
        DatosERRepository Er;
        public Ingresos()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            IngRepo = new IngresosERRepository(connectionString);
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
                var list = IngRepo.GetAll().ToList();
                dgvIngresos.DataSource = list;
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

                Ingreso nuevoDato = new Ingreso
                {
                    NombreDeCuenta = txtNombreCuenta.Text,
                    Monto = Convert.ToDecimal(txtMonto.Text),
                    ID_Clasificacion = Convert.ToInt32(repo.GetIdByDescrip(cboClasificacion.Text)),
                    ID_DatosER = Convert.ToInt32(Er.GetIdByName(cboEstadoDeResult.Text))
                };
                IngRepo.Add(nuevoDato);
                RefreshData();
                txtMonto.Clear();
                txtNombreCuenta.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el ingreso al resultado: ");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvIngresos.SelectedRows.Count > 0)
            {
                var selected = (Ingreso)dgvIngresos.SelectedRows[0].DataBoundItem;
                var update = new Ingreso
                {
                    ID_Ingresos = selected.ID_Ingresos,
                    ID_DatosER = Convert.ToInt32(Er.GetIdByName(cboEstadoDeResult.Text)),
                    ID_Clasificacion = Convert.ToInt32(repo.GetIdByDescrip(cboClasificacion.Text)),
                    NombreDeCuenta = txtNombreCuenta.Text,
                    Monto = Convert.ToDecimal(txtMonto.Text),
                };

                try
                {
                    IngRepo.Update(update);
                    MessageBox.Show("¡Ingreso actualizado exitosamente!", "Éxito",
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
                MessageBox.Show("Seleccione un ingreso para actualizar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvIngresos.Rows.Count > 0)
            {
                var selected = (Ingreso)dgvIngresos.SelectedRows[0].DataBoundItem;
                var result =
                     MessageBox.Show($"¿Está seguro de que desea eliminar el ingreso '{selected.NombreDeCuenta}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        IngRepo.Delete(selected.ID_Ingresos);
                        MessageBox.Show("¡Ingreso eliminado exitosamente!", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar ingreso: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione un ingreso para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var ing = (Ingreso)dgvIngresos.Rows[e.RowIndex].DataBoundItem;
                txtNombreCuenta.Text = ing.NombreDeCuenta;
                txtMonto.Text = ing.Monto.ToString();

            }
        }
    }
}
