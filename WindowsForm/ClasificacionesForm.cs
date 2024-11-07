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
    public partial class ClasificacionesForm : Form
    {
        private readonly IRepository<Clasificacion> clasificacionRepository;

        public ClasificacionesForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            clasificacionRepository = new ClasificacionRepository(connectionString);
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                var clasificaciones = clasificacionRepository.GetAll().ToList();
                dgvClasificaciones.DataSource = clasificaciones;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos de Clasificaciones.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = txtDescripcion.Text;

                if (string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("La descripción de la clasificación no puede estar vacía.");
                    return;
                }

                Clasificacion nuevaClasificacion = new Clasificacion
                {
                    Descripcion = descripcion
                };

                clasificacionRepository.Add(nuevaClasificacion);
                RefreshData();
                txtDescripcion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Clasificación: " + ex.Message);
            }
        }
                
        private void ClasificacionesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
