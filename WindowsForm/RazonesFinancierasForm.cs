using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Models;

namespace WindowsForm
{
    public partial class RazonesFinancierasForm : Form
    {
        public RazonesFinancierasForm()
        {
            InitializeComponent();
        }
        //Me falta
        private void RazonesFinancierasForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRazonesFinancieras_Click(object sender, EventArgs e)
        {
            Razones razones = new Razones
            {
                ActivoCirculante = ConvertToDecimalOrZero(TxtActivoCorriente),
                PasivoCirculante = ConvertToDecimalOrZero(txtPasivoCorriente),
                Inventario = ConvertToDecimalOrZero(txtInventario),
                ActivoTotal = ConvertToDecimalOrZero(txtActivoTotal),
                PasivoTotal = ConvertToDecimalOrZero(txtPasivoTotal),
                InteresesPagados = ConvertToDecimalOrZero(txtInteresesPagados),
                UtilidadOperativa = ConvertToDecimalOrZero(txtUtilidadOperativa),
                VentasNetas = ConvertToDecimalOrZero(txtVentasNetas),
                UtilidadNeta = ConvertToDecimalOrZero(txtUtilidadNeta),
                InventarioPromedio = ConvertToDecimalOrZero(txtInventarioPromedio),
                CostoVentas = ConvertToDecimalOrZero(txtCostoVentas),
                CapitalContable = ConvertToDecimalOrZero(txtCapitalContable),
                CuentasPorCobrar = ConvertToDecimalOrZero(txtCuentasPorCobrar),
                VentasAnuales = ConvertToDecimalOrZero(txtVentasAnuales)
            };

            txtRazonCorriente.Text = razones.CalcularRazonCorriente().ToString("N2");
            txtPruebaAcida.Text = razones.CalcularPruebaAcida().ToString("N2");
            txtRazonEndeudamiento.Text = razones.CalcularRazonEndeudamiento().ToString("N2");
            txtCoberturaIntereses.Text = razones.CalcularCoberturaIntereses().ToString("N2");
            txtMargenUtilidadNeta.Text = razones.CalcularMargenUtilidadNeta().ToString("N2");
            txtRetornoActivos.Text = razones.CalcularRetornoSobreActivos().ToString("N2");
            txtRotacionInventario.Text = razones.CalcularRotacionInventario().ToString("N2");
            txtRetornoCapital.Text = razones.CalcularRetornoSobreCapital().ToString("N2");
            txtRotacionCuentasPorCobrar.Text = razones.CalcularRotacionCuentasPorCobrar().ToString("N2");
            txtPeriodoPromedioCobro.Text = razones.CalcularPeriodoPromedioCobro().ToString("N2");
            txtMargenBruto.Text = razones.CalcularMargenBruto().ToString("N2");
            txtCapitalTrabajo.Text = razones.CalcularRazonCapitalTrabajo().ToString("N2");
        }
        private decimal ConvertToDecimalOrZero(TextBox textBox)
        {
            return decimal.TryParse(textBox.Text, out decimal value) ? value : 0;
        }

    }
}
