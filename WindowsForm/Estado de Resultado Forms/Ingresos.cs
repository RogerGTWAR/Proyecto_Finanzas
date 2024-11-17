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
    }
}
