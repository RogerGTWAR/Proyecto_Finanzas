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
    public partial class CuentasRazonesForm : Form
    {
        private readonly IRepository<CuentasDeLasRazones> cuentasRazonesrepository;
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
                    CuentasDeLasRazones selectedCuenta = (CuentasDeLasRazones)dgv.CurrentRow.DataBoundItem;
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
     string.IsNullOrWhiteSpace(txtInventario.Text) ||
     string.IsNullOrWhiteSpace(txtActivoTotal.Text) ||
     string.IsNullOrWhiteSpace(txtPasivoTotal.Text) ||
     string.IsNullOrWhiteSpace(txtCapitalContable.Text) ||
     string.IsNullOrWhiteSpace(txtActivosFijos.Text) ||
     string.IsNullOrWhiteSpace(txtInteresesPagados.Text) ||
     string.IsNullOrWhiteSpace(txtCuentasPorCobrar.Text) ||
     string.IsNullOrWhiteSpace(txtUtilidadOperativa.Text) ||
     string.IsNullOrWhiteSpace(txtVentasNetas.Text) ||
     string.IsNullOrWhiteSpace(txtCostoVentas.Text) ||
     string.IsNullOrWhiteSpace(txtVentasAnuales.Text) ||
     string.IsNullOrWhiteSpace(txtUtilidadAntesImpuestos.Text) ||
     string.IsNullOrWhiteSpace(txtUtilidadNeta.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CuentasDeLasRazones nuevaCuenta = new CuentasDeLasRazones
                {
                    NombreDeLaEmpresa = txtNombreEmpresa.Text,
                    ActivoCirculante = Convert.ToDecimal(txtActivoCirculante.Text),
                    PasivoCirculante = Convert.ToDecimal(txtPasivoCirculante.Text),
                    Inventario = Convert.ToDecimal(txtInventario.Text),
                    ActivoTotal = Convert.ToDecimal(txtActivoTotal.Text),
                    PasivoTotal = Convert.ToDecimal(txtPasivoTotal.Text),
                    CapitalContable = Convert.ToDecimal(txtCapitalContable.Text),
                    ActivoFijo = Convert.ToDecimal(txtActivosFijos.Text),
                    InteresesPagados = Convert.ToDecimal(txtInteresesPagados.Text),
                    CuentasPorCobrar = Convert.ToDecimal(txtCuentasPorCobrar.Text),
                    UtilidadOperativa = Convert.ToDecimal(txtUtilidadOperativa.Text),
                    VentasNetas = Convert.ToDecimal(txtVentasNetas.Text),
                    CostoVentas = Convert.ToDecimal(txtCostoVentas.Text),
                    VentasAnuales = Convert.ToDecimal(txtVentasAnuales.Text),
                    UtilidadAntesDeImpuestos = Convert.ToDecimal(txtUtilidadAntesImpuestos.Text),
                    UtilidadNeta = Convert.ToDecimal(txtUtilidadNeta.Text)
                };
                cuentasRazonesrepository.Add(nuevaCuenta);
                RefreshData();
                LimpiarCampos();
            }
            catch (FormatException ex)
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
                CuentasDeLasRazones selectedCuenta = (CuentasDeLasRazones)dgv.CurrentRow.DataBoundItem;
                if (!decimal.TryParse(txtActivoCirculante.Text, out decimal activoCirculante) ||
                    !decimal.TryParse(txtInventario.Text, out decimal inventario) ||
                    !decimal.TryParse(txtActivoTotal.Text, out decimal activoTotal) ||
                    !decimal.TryParse(txtPasivoTotal.Text, out decimal pasivoTotal) ||
                    !decimal.TryParse(txtCapitalContable.Text, out decimal capitalContable) ||
                    !decimal.TryParse(txtActivosFijos.Text, out decimal activosFijos) ||
                    !decimal.TryParse(txtInteresesPagados.Text, out decimal interesesPagados) ||
                    !decimal.TryParse(txtCuentasPorCobrar.Text, out decimal cuentasPorCobrar) ||
                    !decimal.TryParse(txtUtilidadOperativa.Text, out decimal utilidadOperativa) ||
                    !decimal.TryParse(txtVentasNetas.Text, out decimal ventasNetas) ||
                    !decimal.TryParse(txtCostoVentas.Text, out decimal costoVentas) ||
                    !decimal.TryParse(txtVentasAnuales.Text, out decimal ventasAnuales) ||
                    !decimal.TryParse(txtUtilidadAntesImpuestos.Text, out decimal utilidadAntesImpuestos) ||
                    !decimal.TryParse(txtUtilidadNeta.Text, out decimal utilidadNeta))
                {
                    MessageBox.Show("Por favor, asegúrese de llenar todos los campos correctamente con valores numéricos.");
                    return;
                }

                selectedCuenta.NombreDeLaEmpresa = txtNombreEmpresa.Text;
                selectedCuenta.ActivoCirculante = activoCirculante;
                selectedCuenta.Inventario = inventario;
                selectedCuenta.ActivoTotal = activoTotal;
                selectedCuenta.PasivoTotal = pasivoTotal;
                selectedCuenta.CapitalContable = capitalContable;
                selectedCuenta.ActivoFijo = activosFijos;
                selectedCuenta.InteresesPagados = interesesPagados;
                selectedCuenta.CuentasPorCobrar = cuentasPorCobrar;
                selectedCuenta.UtilidadOperativa = utilidadOperativa;
                selectedCuenta.VentasNetas = ventasNetas;
                selectedCuenta.CostoVentas = costoVentas;
                selectedCuenta.VentasAnuales = ventasAnuales;
                selectedCuenta.UtilidadAntesDeImpuestos = utilidadAntesImpuestos;
                selectedCuenta.UtilidadNeta = utilidadNeta;
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
            txtInventario.Clear();
            txtActivoTotal.Clear();
            txtPasivoTotal.Clear();
            txtCapitalContable.Clear();
            txtActivosFijos.Clear();
            txtInteresesPagados.Clear();
            txtCuentasPorCobrar.Clear();
            txtUtilidadOperativa.Clear();
            txtVentasNetas.Clear();
            txtCostoVentas.Clear();
            txtVentasAnuales.Clear();
            txtUtilidadAntesImpuestos.Clear();
            txtUtilidadNeta.Clear();
        }

        private void CuentasRazonesForm_Load(object sender, EventArgs e)
        {
        }
        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                    txtNombreEmpresa.Text = selectedRow.Cells["NombreDeLaEmpresa"].Value?.ToString() ?? string.Empty;
                    txtActivoCirculante.Text = selectedRow.Cells["ActivoCirculante"].Value?.ToString() ?? string.Empty;
                    txtPasivoCirculante.Text = selectedRow.Cells["PasivoCirculante"].Value?.ToString() ?? string.Empty;
                    txtInventario.Text = selectedRow.Cells["Inventario"].Value?.ToString() ?? string.Empty;
                    txtActivoTotal.Text = selectedRow.Cells["ActivoTotal"].Value?.ToString() ?? string.Empty;
                    txtPasivoTotal.Text = selectedRow.Cells["PasivoTotal"].Value?.ToString() ?? string.Empty;
                    txtCapitalContable.Text = selectedRow.Cells["CapitalContable"].Value?.ToString() ?? string.Empty;
                    txtActivosFijos.Text = selectedRow.Cells["ActivoFijo"].Value?.ToString() ?? string.Empty;
                    txtInteresesPagados.Text = selectedRow.Cells["InteresesPagados"].Value?.ToString() ?? string.Empty;
                    txtCuentasPorCobrar.Text = selectedRow.Cells["CuentasPorCobrar"].Value?.ToString() ?? string.Empty;
                    txtUtilidadOperativa.Text = selectedRow.Cells["UtilidadOperativa"].Value?.ToString() ?? string.Empty;
                    txtVentasNetas.Text = selectedRow.Cells["VentasNetas"].Value?.ToString() ?? string.Empty;
                    txtCostoVentas.Text = selectedRow.Cells["CostoVentas"].Value?.ToString() ?? string.Empty;
                    txtVentasAnuales.Text = selectedRow.Cells["VentasAnuales"].Value?.ToString() ?? string.Empty;
                    txtUtilidadAntesImpuestos.Text = selectedRow.Cells["UtilidadAntesDeImpuestos"].Value?.ToString() ?? string.Empty;
                    txtUtilidadNeta.Text = selectedRow.Cells["UtilidadNeta"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar la fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
