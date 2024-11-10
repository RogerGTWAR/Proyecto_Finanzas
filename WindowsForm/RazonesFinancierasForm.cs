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

namespace WindowsForm
{
    public partial class RazonesFinancierasForm : Form
    {
        private readonly IRepository<RazonesFinanciera> _razonesRepository;
        private readonly IRepository<CuentasDeLasRazones> _cuentaRepository;
        private readonly IRepository<DatosBalanceG> _balanceRepository;
        private readonly IRepository<DatosER> _datosERRepository;
        public RazonesFinancierasForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _razonesRepository = new RazonesFinancierasRepository(connectionString);
            _cuentaRepository = new CuentasRazonesRepository(connectionString);
            _balanceRepository = new BalanceRepository(connectionString);
            _datosERRepository = new DatosERRepository(connectionString);
            RefreshData();
            CargarDatosComboBox();
            CargarComboBoxCRF();
        }

        private void CargarComboBoxCRF()
        {
            if (cbID_CuentasDeRazones.SelectedValue != null)
            {
                int idCuentaRazon = (int)cbID_CuentasDeRazones.SelectedValue;
                var cuentaRazon = _cuentaRepository.GetById(idCuentaRazon);

                if (cuentaRazon != null)
                {

                    decimal activosCirculantes = cuentaRazon.ActivoCirculante;
                    decimal pasivosCorrientes = cuentaRazon.PasivoCirculante;
                    decimal inventarios = cuentaRazon.Inventario;
                    decimal cuentasPorCobrar = cuentaRazon.CuentasPorCobrar;
                    decimal ventas = cuentaRazon.VentasNetas;
                    decimal activosFijos = cuentaRazon.ActivoFijo;
                    decimal activosTotales = cuentaRazon.ActivoTotal;
                    decimal pasivosTotales = cuentaRazon.PasivoTotal;
                    decimal capitalContable = cuentaRazon.CapitalContable;
                    decimal utilidadAntesIntereses = cuentaRazon.UtilidadAntesDeImpuestos;
                    //decimal gastosPorIntereses = cuentaRazon.;
                    //decimal utilidadBruta = cuentaRazon.UtilidadBruta;
                    decimal utilidadOperativa = cuentaRazon.UtilidadOperativa;
                    decimal utilidadNeta = cuentaRazon.UtilidadNeta;
                    decimal razonCirculante = activosCirculantes / pasivosCorrientes;
                    decimal pruebaAcida = (activosCirculantes - inventarios) / pasivosCorrientes;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para la cuenta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarDatosComboBox()
        {
            cbID_DatosBalance.DataSource = _balanceRepository.GetAll();
            cbID_DatosBalance.DisplayMember = "NombreBG";
            cbID_DatosBalance.ValueMember = "ID_DatosBalance";

            cbID_DatosER.DataSource = _datosERRepository.GetAll();
            cbID_DatosER.DisplayMember = "NombreER";
            cbID_DatosER.ValueMember = "ID_DatosER";

            cbID_CuentasDeRazones.DataSource = _cuentaRepository.GetAll();
            cbID_CuentasDeRazones.DisplayMember = "NombreDeLaEmpresa";
            cbID_CuentasDeRazones.ValueMember = "ID_CuentasDeRazones";
        }

        private void RefreshData()
        {
            try
            {
                var cuentas = _razonesRepository.GetAll().ToList();
                dgvRazones.DataSource = cuentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas. Error: " + ex.Message);
            }
        }

        private void RazonesFinancierasForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRazonesFinancieras_Click(object sender, EventArgs e)
        {


            if (cbID_CuentasDeRazones.SelectedValue != null)
            {
                int idCuentaRazon = (int)cbID_CuentasDeRazones.SelectedValue;
                var cuentaRazon = _cuentaRepository.GetById(idCuentaRazon);

                if (cuentaRazon != null)
                {
                    decimal activosCirculantes = cuentaRazon.ActivoCirculante;
                    decimal pasivosCorrientes = cuentaRazon.PasivoCirculante;
                    decimal inventarios = cuentaRazon.Inventario;
                    decimal cuentasPorCobrar = cuentaRazon.CuentasPorCobrar;
                    decimal ventas = cuentaRazon.VentasNetas;
                    decimal activosFijos = cuentaRazon.ActivoFijo;
                    decimal activosTotales = cuentaRazon.ActivoTotal;
                    decimal pasivosTotales = cuentaRazon.PasivoTotal;
                    decimal capitalContable = cuentaRazon.CapitalContable;
                    decimal utilidadOperativa = cuentaRazon.UtilidadOperativa;
                    decimal utilidadNeta = cuentaRazon.UtilidadNeta;

                    decimal razonCirculante = pasivosCorrientes != 0 ? activosCirculantes / pasivosCorrientes : 0;
                    decimal pruebaAcida = pasivosCorrientes != 0 ? (activosCirculantes - inventarios) / pasivosCorrientes : 0;
                    decimal rotacionInventario = inventarios != 0 ? ventas / inventarios : 0;
                    decimal rotacionCuentasPorCobrar = cuentasPorCobrar != 0 ? ventas / cuentasPorCobrar : 0;
                    decimal periodoPromedioCobro = rotacionCuentasPorCobrar != 0 ? 365 / rotacionCuentasPorCobrar : 0;
                    decimal rotacionActivosFijos = activosFijos != 0 ? ventas / activosFijos : 0;
                    decimal rotacionActivosTotales = activosTotales != 0 ? ventas / activosTotales : 0;
                    decimal razonDeudaTotal = activosTotales != 0 ? pasivosTotales / activosTotales : 0;
                    decimal razonPasivoCapital = capitalContable != 0 ? pasivosTotales / capitalContable : 0;
                    decimal utilidadMOM = ventas != 0 ? utilidadOperativa / ventas : 0;
                    decimal utilidadNetaM = ventas != 0 ? utilidadNeta / ventas : 0;
                    decimal capitaldetrabajo = activosCirculantes - pasivosCorrientes;

                    txtCapitalTrabajo.Text = capitaldetrabajo.ToString("N2");
                    txtRazonCorriente.Text = razonCirculante.ToString("N2");
                    txtPruebaAcida.Text = pruebaAcida.ToString("N2");
                    txtRotacionInventario.Text = rotacionInventario.ToString("N2");
                    txtRotacionCuentasPorCobrar.Text = rotacionCuentasPorCobrar.ToString("N2");
                    txtPeriodoPromedioCobro.Text = periodoPromedioCobro.ToString("N2");
                    txtRotacionActivosFijos.Text = rotacionActivosFijos.ToString("N2");
                    txtRotacionActivosTotales.Text = rotacionActivosTotales.ToString("N2");
                    txtRazonEndeudamiento.Text = razonDeudaTotal.ToString("P2");
                    txtRazonPasivoCapital.Text = razonPasivoCapital.ToString("P2");
                    txtMargenUtilidadOperativa.Text = utilidadMOM.ToString("P2");
                    txtMargenUtilidadNeta.Text = utilidadNetaM.ToString("P2");
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para la cuenta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
