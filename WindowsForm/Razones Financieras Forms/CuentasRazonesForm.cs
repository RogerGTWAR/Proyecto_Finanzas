using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.IRepository;
using WindowsForm.IRepository.Repository;
using WindowsForm.Models;

namespace WindowsForm
{
    public partial class CuentasRazonesForm : Form
    {
        private readonly IRepository<CuentaDeLasRazones> cuentasRazonesrepository;
        public CuentasRazonesForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            cuentasRazonesrepository = new CuentasRazonesRepository(connectionString);
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                var cuentas = cuentasRazonesrepository.GetAll().ToList();
                dgv.DataSource = cuentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas. Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.CurrentRow != null)
                {
                    CuentaDeLasRazones selectedCuenta = (CuentaDeLasRazones)dgv.CurrentRow.DataBoundItem;
                    cuentasRazonesrepository.Delete(selectedCuenta.ID_CuentasDeRazones);
                    RefreshData();
                    MessageBox.Show("Cuenta eliminada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una cuenta para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la cuenta: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpresa.Text) ||
                string.IsNullOrWhiteSpace(txtActivoCirculante.Text) ||
                string.IsNullOrWhiteSpace(txtPasivoCirculante.Text) ||
                string.IsNullOrWhiteSpace(txtPasivoNoCirculante.Text) ||
                string.IsNullOrWhiteSpace(txtInventario.Text) ||
                string.IsNullOrWhiteSpace(txtActivoTotal.Text) ||
                string.IsNullOrWhiteSpace(txtPasivoTotal.Text) ||
                string.IsNullOrWhiteSpace(txtCapitalContable.Text) ||
                string.IsNullOrWhiteSpace(txtActivosFijos.Text) ||
                string.IsNullOrWhiteSpace(txtCuentasPorCobrar.Text) ||
                string.IsNullOrWhiteSpace(txtUtilidadOperativa.Text) ||
                string.IsNullOrWhiteSpace(txtVentasNetas.Text) ||
                string.IsNullOrWhiteSpace(txtCostoVentas.Text) ||
                string.IsNullOrWhiteSpace(txtVentas.Text) ||
                string.IsNullOrWhiteSpace(txtUtilidadAntesImpuestos.Text) ||
                string.IsNullOrWhiteSpace(txtUtilidadNeta.Text) ||
                string.IsNullOrWhiteSpace(txtVentasCredito.Text) ||
                string.IsNullOrWhiteSpace(txtUtilidadAntesDeInteresesImpuestos.Text) ||
                string.IsNullOrWhiteSpace(txtCargosporIntereses.Text) ||
                string.IsNullOrWhiteSpace(txtUtilidadNetaparaAccionista.Text) ||
                string.IsNullOrWhiteSpace(txtAccionesenCirculacion.Text) ||
                string.IsNullOrWhiteSpace(txtPreciodelMercadoPorAccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CuentaDeLasRazones nuevaCuenta = new CuentaDeLasRazones
                {
                    NombreDeLaEmpresa = txtNombreEmpresa.Text,
                    ActivoCirculante = Convert.ToDecimal(txtActivoCirculante.Text, CultureInfo.InvariantCulture),
                    PasivoCirculante = Convert.ToDecimal(txtPasivoCirculante.Text, CultureInfo.InvariantCulture),
                    PasivoNoCirculante = Convert.ToDecimal(txtPasivoNoCirculante.Text, CultureInfo.InvariantCulture),
                    Inventario = Convert.ToDecimal(txtInventario.Text, CultureInfo.InvariantCulture),
                    ActivoTotal = Convert.ToDecimal(txtActivoTotal.Text, CultureInfo.InvariantCulture),
                    PasivoTotal = Convert.ToDecimal(txtPasivoTotal.Text, CultureInfo.InvariantCulture),
                    CapitalContable = Convert.ToDecimal(txtCapitalContable.Text, CultureInfo.InvariantCulture),
                    ActivoFijo = Convert.ToDecimal(txtActivosFijos.Text, CultureInfo.InvariantCulture),
                    CuentasPorCobrar = Convert.ToDecimal(txtCuentasPorCobrar.Text, CultureInfo.InvariantCulture),
                    UtilidadOperativa = Convert.ToDecimal(txtUtilidadOperativa.Text, CultureInfo.InvariantCulture),
                    VentasNetas = Convert.ToDecimal(txtVentasNetas.Text, CultureInfo.InvariantCulture),
                    CostoVentas = Convert.ToDecimal(txtCostoVentas.Text, CultureInfo.InvariantCulture),
                    CapitalSocial = Convert.ToDecimal(txtVentas.Text, CultureInfo.InvariantCulture),
                    UtilidadAntesDeImpuestos = Convert.ToDecimal(txtUtilidadAntesImpuestos.Text, CultureInfo.InvariantCulture),
                    UtilidadNeta = Convert.ToDecimal(txtUtilidadNeta.Text, CultureInfo.InvariantCulture),
                    VentasCredito = Convert.ToDecimal(txtVentasCredito.Text, CultureInfo.InvariantCulture),
                    UtilidadAntesDeInteresesImpuestos = Convert.ToDecimal(txtUtilidadAntesDeInteresesImpuestos.Text, CultureInfo.InvariantCulture),
                    CargosporIntereses = Convert.ToDecimal(txtCargosporIntereses.Text, CultureInfo.InvariantCulture),
                    UtilidadNetaparaAccionista = Convert.ToDecimal(txtUtilidadNetaparaAccionista.Text, CultureInfo.InvariantCulture),
                    AccionesenCirculacion = Convert.ToDecimal(txtAccionesenCirculacion.Text, CultureInfo.InvariantCulture),
                    PreciodelMercadoporAccion = Convert.ToDecimal(txtPreciodelMercadoPorAccion.Text, CultureInfo.InvariantCulture)
                };
                cuentasRazonesrepository.Add(nuevaCuenta);
                RefreshData();
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrate de que todos los valores sean números válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona una cuenta de razón para actualizar.");
                    return;
                }

                CuentaDeLasRazones selectedCuenta = (CuentaDeLasRazones)dgv.CurrentRow.DataBoundItem;
                if (!decimal.TryParse(txtActivoCirculante.Text, out decimal activoCirculante) ||
                    !decimal.TryParse(txtPasivoCirculante.Text, out decimal pasivoCirculante) ||
                    !decimal.TryParse(txtPasivoNoCirculante.Text, out decimal pasivonoCirculante) ||
                    !decimal.TryParse(txtInventario.Text, out decimal inventario) ||
                    !decimal.TryParse(txtActivoTotal.Text, out decimal activoTotal) ||
                    !decimal.TryParse(txtPasivoTotal.Text, out decimal pasivoTotal) ||
                    !decimal.TryParse(txtCapitalContable.Text, out decimal capitalContable) ||
                    !decimal.TryParse(txtActivosFijos.Text, out decimal activosFijos) ||
                    !decimal.TryParse(txtCuentasPorCobrar.Text, out decimal cuentasPorCobrar) ||
                    !decimal.TryParse(txtUtilidadOperativa.Text, out decimal utilidadOperativa) ||
                    !decimal.TryParse(txtVentasNetas.Text, out decimal ventasNetas) ||
                    !decimal.TryParse(txtCostoVentas.Text, out decimal costoVentas) ||
                    !decimal.TryParse(txtVentas.Text, out decimal ventas) ||
                    !decimal.TryParse(txtUtilidadAntesImpuestos.Text, out decimal utilidadAntesImpuestos) ||
                    !decimal.TryParse(txtUtilidadNeta.Text, out decimal utilidadNeta) ||
                    !decimal.TryParse(txtVentasCredito.Text, out decimal ventasCredito) ||
                    !decimal.TryParse(txtUtilidadAntesDeInteresesImpuestos.Text, out decimal utilidadAntesDeInteresesImpuestos) ||
                    !decimal.TryParse(txtCargosporIntereses.Text, out decimal cargosporIntereses) ||
                    !decimal.TryParse(txtUtilidadNetaparaAccionista.Text, out decimal utilidadNetaparaAccionista) ||
                    !decimal.TryParse(txtAccionesenCirculacion.Text, out decimal accionesenCirculacion) ||
                    !decimal.TryParse(txtPreciodelMercadoPorAccion.Text, out decimal preciodelMercadoporAccion))
                {
                    MessageBox.Show("Por favor, asegúrese de llenar todos los campos correctamente con valores numéricos.");
                    return;
                }
                selectedCuenta.NombreDeLaEmpresa = txtNombreEmpresa.Text;
                selectedCuenta.ActivoCirculante = activoCirculante;
                selectedCuenta.PasivoCirculante = pasivoCirculante;
                selectedCuenta.PasivoNoCirculante = pasivonoCirculante;
                selectedCuenta.Inventario = inventario;
                selectedCuenta.ActivoTotal = activoTotal;
                selectedCuenta.PasivoTotal = pasivoTotal;
                selectedCuenta.CapitalContable = capitalContable;
                selectedCuenta.ActivoFijo = activosFijos;
                selectedCuenta.CuentasPorCobrar = cuentasPorCobrar;
                selectedCuenta.UtilidadOperativa = utilidadOperativa;
                selectedCuenta.VentasNetas = ventasNetas;
                selectedCuenta.CostoVentas = costoVentas;
                selectedCuenta.CapitalSocial = ventas;
                selectedCuenta.UtilidadAntesDeImpuestos = utilidadAntesImpuestos;
                selectedCuenta.UtilidadNeta = utilidadNeta;
                selectedCuenta.VentasCredito = ventasCredito;
                selectedCuenta.UtilidadAntesDeInteresesImpuestos = utilidadAntesDeInteresesImpuestos;
                selectedCuenta.CargosporIntereses = cargosporIntereses;
                selectedCuenta.UtilidadNetaparaAccionista = utilidadNetaparaAccionista;
                selectedCuenta.AccionesenCirculacion = accionesenCirculacion;
                selectedCuenta.PreciodelMercadoporAccion = preciodelMercadoporAccion;
                cuentasRazonesrepository.Update(selectedCuenta);
                RefreshData();
                LimpiarCampos();
                MessageBox.Show("La cuenta ha sido actualizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la cuenta: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtNombreEmpresa.Clear();
            txtActivoCirculante.Clear();
            txtPasivoCirculante.Clear();
            txtPasivoNoCirculante.Clear();
            txtInventario.Clear();
            txtActivoTotal.Clear();
            txtPasivoTotal.Clear();
            txtCapitalContable.Clear();
            txtActivosFijos.Clear();
            txtCuentasPorCobrar.Clear();
            txtUtilidadOperativa.Clear();
            txtVentasNetas.Clear();
            txtCostoVentas.Clear();
            txtVentas.Clear();
            txtUtilidadAntesImpuestos.Clear();
            txtUtilidadNeta.Clear();
            txtVentasCredito.Clear();
            txtUtilidadAntesDeInteresesImpuestos.Clear();
            txtCargosporIntereses.Clear();
            txtUtilidadNetaparaAccionista.Clear();
            txtAccionesenCirculacion.Clear();
            txtPreciodelMercadoPorAccion.Clear();

        }

        private void CuentasRazonesForm_Load(object sender, EventArgs e)
        {
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                    txtNombreEmpresa.Text = selectedRow.Cells["nombreDeLaEmpresaDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;

                    txtActivoCirculante.Text = selectedRow.Cells["activoCirculanteDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtActivosFijos.Text = selectedRow.Cells["activoFijoDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtActivoTotal.Text = selectedRow.Cells["activoTotalDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtInventario.Text = selectedRow.Cells["inventarioDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtCuentasPorCobrar.Text = selectedRow.Cells["cuentasPorCobrarDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;

                    txtPasivoCirculante.Text = selectedRow.Cells["pasivoCirculanteDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtPasivoNoCirculante.Text = selectedRow.Cells["pasivoNoCirculanteDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtPasivoTotal.Text = selectedRow.Cells["pasivoTotalDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;

                    txtCapitalContable.Text = selectedRow.Cells["capitalContableDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtVentas.Text = selectedRow.Cells["capitalSocialDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;

                    txtVentasCredito.Text = selectedRow.Cells["ventasCreditoDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtVentasNetas.Text = selectedRow.Cells["ventasNetasDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtCostoVentas.Text = selectedRow.Cells["costoVentasDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtUtilidadOperativa.Text = selectedRow.Cells["utilidadOperativaDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtUtilidadAntesImpuestos.Text = selectedRow.Cells["utilidadAntesDeImpuestosDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtUtilidadNeta.Text = selectedRow.Cells["utilidadNetaDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtUtilidadAntesDeInteresesImpuestos.Text = selectedRow.Cells["utilidadAntesDeInteresesImpuestosDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtCargosporIntereses.Text = selectedRow.Cells["cargosporInteresesDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtUtilidadNetaparaAccionista.Text = selectedRow.Cells["utilidadNetaparaAccionistaDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;

                    txtAccionesenCirculacion.Text = selectedRow.Cells["accionesenCirculacionDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                    txtPreciodelMercadoPorAccion.Text = selectedRow.Cells["preciodelMercadoporAccionDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar la fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
