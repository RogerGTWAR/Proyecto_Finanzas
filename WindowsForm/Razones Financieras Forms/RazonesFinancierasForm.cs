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
        private readonly IRepository<CuentaDeLasRazones> _cuentaRepository;
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
                    decimal pasivoNocirculante = cuentaRazon.PasivoNoCirculante;
                    decimal inventarios = cuentaRazon.Inventario;
                    decimal cuentasPorCobrar = cuentaRazon.CuentasPorCobrar;
                    decimal ventascredito = cuentaRazon.VentasCredito;
                    decimal ventas = cuentaRazon.VentasNetas;
                    decimal capitalsocial = cuentaRazon.CapitalSocial;
                    decimal activosFijos = cuentaRazon.ActivoFijo;
                    decimal activosTotales = cuentaRazon.ActivoTotal;
                    decimal costosdeventas = cuentaRazon.CostoVentas;
                    decimal pasivosTotales = cuentaRazon.PasivoTotal;
                    decimal capitalContable = cuentaRazon.CapitalContable;
                    decimal utilidadOperativa = cuentaRazon.UtilidadOperativa;
                    decimal utilidadNeta = cuentaRazon.UtilidadNeta;
                    decimal cargosporinteres = cuentaRazon.CargosporIntereses;
                    decimal utilidadantesdeintereseseimpuestos = cuentaRazon.UtilidadAntesDeInteresesImpuestos;
                    decimal utilidadantesdeimpuestos = cuentaRazon.UtilidadAntesDeImpuestos;
                    decimal accionescirculantes = cuentaRazon.AccionesenCirculacion;
                    decimal utilidadnetaaaccionistascomunes = cuentaRazon.UtilidadNetaparaAccionista;
                    decimal preciodelmercadoporaccion = cuentaRazon.PreciodelMercadoporAccion;


                    //Liquidez y Actividad
                    decimal capitaldetrabajo = activosCirculantes - pasivosCorrientes;
                    decimal razonCirculante = pasivosCorrientes != 0 ? activosCirculantes / pasivosCorrientes : 0;
                    decimal pruebaAcida = pasivosCorrientes != 0 ? (activosCirculantes - inventarios) / pasivosCorrientes : 0;
                    decimal rotacionInventario = inventarios != 0 ? costosdeventas / inventarios : 0;
                    decimal rotacionCuentasPorCobrar = cuentasPorCobrar != 0 ? ventascredito / cuentasPorCobrar : 0;
                    decimal periodoPromedioCobro = rotacionCuentasPorCobrar != 0 ? cuentasPorCobrar / (ventascredito / 360) : 0;
                    decimal rotacionActivosFijos = activosFijos != 0 ? ventas / activosFijos : 0;
                    decimal rotacionActivosTotales = activosTotales != 0 ? ventas / activosTotales : 0;

                    //Endeudamiento y Rentabilidad
                    decimal razonDeudaTotal = activosTotales != 0 ? pasivosTotales / activosTotales : 0;
                    decimal razonPasivoCapital = capitalsocial != 0 ? (pasivoNocirculante / capitalsocial) / 100m : 0;
                    decimal razonrotacioninteresautilidades = cargosporinteres != 0 ? (utilidadantesdeintereseseimpuestos / cargosporinteres) / 100m : 0;

                    decimal margenutilidadbruta = ventas != 0 ? (ventas - costosdeventas) / ventas : 0;
                    decimal margenutilidadoperativa = ventas != 0 ? utilidadOperativa / ventas : 0;
                    decimal margenutilidadneta = ventas != 0 ? utilidadantesdeimpuestos / ventas : 0;

                    //Mercado
                    decimal utilidadporaccion = accionescirculantes != 0 ? utilidadnetaaaccionistascomunes / accionescirculantes : 0;
                    decimal razonprecio = utilidadporaccion != 0 ? preciodelmercadoporaccion / utilidadporaccion : 0;
                    decimal valrenlibrosporaccion = accionescirculantes != 0 ? capitalContable / accionescirculantes : 0;
                    decimal valorenmercado = valrenlibrosporaccion != 0 ? capitalContable / valrenlibrosporaccion : 0;

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
                    txtRotaciondeiau.Text = razonrotacioninteresautilidades.ToString("P2");

                    txtMargenBruto.Text = margenutilidadbruta.ToString("P2");
                    txtMargenUtilidadOperativa.Text = margenutilidadoperativa.ToString("P2");
                    txtMargenUtilidadNeta.Text = margenutilidadneta.ToString("P2");

                    txtUtilidadporAccion.Text = utilidadporaccion.ToString("N2");
                    txtRazonPrecio.Text = razonprecio.ToString("N2");
                    txtValorenLibros.Text = valorenmercado.ToString("N2");
                    txtValorenLibrosA.Text = valrenlibrosporaccion.ToString("N2");
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para la cuenta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRazones.CurrentRow != null && dgvRazones.CurrentRow.DataBoundItem is RazonesFinanciera razonSeleccionada)
                {
                    int idcuentas = Convert.ToInt32(cbID_CuentasDeRazones.SelectedValue);
                    int ider = Convert.ToInt32(cbID_DatosER.SelectedValue);
                    int idbg = Convert.ToInt32(cbID_DatosBalance.SelectedValue);

                    razonSeleccionada.ID_CuentasDeRazones = idcuentas;
                    razonSeleccionada.ID_DatosER = ider;
                    razonSeleccionada.ID_DatosBalance = idbg;
                    razonSeleccionada.CapitalTrabajoNeto = ValidarDecimal(txtCapitalTrabajo.Text);
                    razonSeleccionada.RazonCirculante = ValidarDecimal(txtRazonCorriente.Text);
                    razonSeleccionada.PruebaAcida = ValidarDecimal(txtPruebaAcida.Text);
                    razonSeleccionada.RotacionInventario = ValidarDecimal(txtRotacionInventario.Text);
                    razonSeleccionada.RotacionCuentasPorCobrar = ValidarDecimal(txtRotacionCuentasPorCobrar.Text);
                    razonSeleccionada.PeriodoPromedioCobro = ValidarDecimal(txtPeriodoPromedioCobro.Text);
                    razonSeleccionada.RotacionActivosFijos = ValidarDecimal(txtRotacionActivosFijos.Text);
                    razonSeleccionada.RotacionActivosTotales = ValidarDecimal(txtRotacionActivosTotales.Text);
                    razonSeleccionada.RazonDeudaTotal = ValidarDecimal(txtRazonEndeudamiento.Text);
                    razonSeleccionada.RazonPasivoCapital = ValidarDecimal(txtRazonPasivoCapital.Text);
                    razonSeleccionada.RazonRotacionInteresUtilidad = ValidarDecimal(txtRotaciondeiau.Text);
                    razonSeleccionada.MUB = ValidarDecimal(txtMargenBruto.Text);
                    razonSeleccionada.MUO = ValidarDecimal(txtMargenUtilidadOperativa.Text);
                    razonSeleccionada.MUN = ValidarDecimal(txtMargenUtilidadNeta.Text);
                    razonSeleccionada.UtilidadporAccion = ValidarDecimal(txtUtilidadporAccion.Text);
                    razonSeleccionada.RazonPrecio = ValidarDecimal(txtRazonPrecio.Text);
                    razonSeleccionada.ValorenLibros = ValidarDecimal(txtValorenLibros.Text);
                    razonSeleccionada.ValorenLibrosporAccion = ValidarDecimal(txtValorenLibrosA.Text);

                    _razonesRepository.Update(razonSeleccionada);
                    RefreshData();

                    MessageBox.Show("Razón financiera actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione una razón financiera para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la razón financiera. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int idcuentas = Convert.ToInt32(cbID_CuentasDeRazones.SelectedValue);
                int ider = Convert.ToInt32(cbID_DatosER.SelectedValue);
                int idbg = Convert.ToInt32(cbID_DatosBalance.SelectedValue);
                var nuevaRazon = new RazonesFinanciera
                {
                    ID_CuentasDeRazones = idcuentas,
                    ID_DatosER = ider,
                    ID_DatosBalance = idbg,
                    CapitalTrabajoNeto = ValidarDecimal(txtCapitalTrabajo.Text),
                    RazonCirculante = ValidarDecimal(txtRazonCorriente.Text),
                    PruebaAcida = ValidarDecimal(txtPruebaAcida.Text),
                    RotacionInventario = ValidarDecimal(txtRotacionInventario.Text),
                    RotacionCuentasPorCobrar = ValidarDecimal(txtRotacionCuentasPorCobrar.Text),
                    PeriodoPromedioCobro = ValidarDecimal(txtPeriodoPromedioCobro.Text),
                    RotacionActivosFijos = ValidarDecimal(txtRotacionActivosFijos.Text),
                    RotacionActivosTotales = ValidarDecimal(txtRotacionActivosTotales.Text),
                    RazonDeudaTotal = ValidarDecimal(txtRazonEndeudamiento.Text),
                    RazonPasivoCapital = ValidarDecimal(txtRazonPasivoCapital.Text),
                    RazonRotacionInteresUtilidad = ValidarDecimal(txtRotaciondeiau.Text),
                    MUB = ValidarDecimal(txtMargenBruto.Text),
                    MUO = ValidarDecimal(txtMargenUtilidadOperativa.Text),
                    MUN = ValidarDecimal(txtMargenUtilidadNeta.Text),
                    UtilidadporAccion = ValidarDecimal(txtUtilidadporAccion.Text),
                    RazonPrecio = ValidarDecimal(txtRazonPrecio.Text),
                    ValorenLibros = ValidarDecimal(txtValorenLibros.Text),
                    ValorenLibrosporAccion = ValidarDecimal(txtValorenLibrosA.Text)
                };
                _razonesRepository.Add(nuevaRazon);
                RefreshData();

                MessageBox.Show("Razón financiera agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la razón financiera. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal ValidarDecimal(string valor)
        {
            try
            {
                valor = valor.Trim();
                if (valor.Contains("%"))
                {
                    valor = valor.Replace("%", "").Trim();
                    if (!decimal.TryParse(valor, out decimal resultado))
                    {
                        throw new FormatException("El valor no es un número válido.");
                    }
                    return resultado / 100;
                }
                if (!decimal.TryParse(valor, out decimal valorDecimal))
                {
                    throw new FormatException("El valor no es un número válido.");
                }

                return valorDecimal;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el valor ingresado: {ex.Message}", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRazones.CurrentRow != null && dgvRazones.CurrentRow.DataBoundItem is RazonesFinanciera razonSeleccionada)
                {
                    var result = MessageBox.Show("¿Está seguro de que desea eliminar esta razón financiera?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _razonesRepository.Delete(razonSeleccionada.ID_RazonFinanciera);
                        RefreshData();
                        MessageBox.Show("Razón financiera eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una razón financiera para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la razón financiera. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
