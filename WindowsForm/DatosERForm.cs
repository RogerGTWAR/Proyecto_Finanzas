using Microsoft.VisualBasic;
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
    public partial class DatosERForm : Form
    {
        public readonly IRepository<DatosER> datosERrepository;
        public DatosERForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            datosERrepository = new DatosERRepository(connectionString);
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                var balanceIds = datosERrepository.GetAll().ToList();
                dgvDatosER.DataSource = balanceIds;
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
                string nombreER = txtNombreER.Text.Trim();
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFIn.Value;

                if (string.IsNullOrWhiteSpace(nombreER))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para el estado de resultado.");
                    return;
                }
                DatosER nuevoDato = new DatosER
                {
                    NombreER = nombreER,
                    FechaInicio = fechaInicio,
                    Fechafin = fechaFin
                };
                datosERrepository.Add(nuevoDato);
                RefreshData();
                txtNombreER.Clear();
                dtpFechaInicio.Value = DateTime.Now;
                dtpFechaFIn.Value = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el estado de resultado: ");
            }
        }

        private void DatosER_Load(object sender, EventArgs e)
        {

        }
    }
}
