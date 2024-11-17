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
using WindowsForm.IRepository.Repository;
using WindowsForm.Models;

namespace WindowsForm.Estado_de_Resultado_Forms
{
    public partial class ClasificacionesER : Form
    {

        private readonly IRepository<ClasificacionER> clasificacionRepository;
        public ClasificacionesER()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            clasificacionRepository = new ClasificacionERRepository(connectionString);
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

                ClasificacionER nuevaClasificacion = new ClasificacionER
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
    }
}
