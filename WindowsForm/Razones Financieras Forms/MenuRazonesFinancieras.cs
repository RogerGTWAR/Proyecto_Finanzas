using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class MenuRazonesFinancieras : Form
    {
        CuentasRazonesForm cuentasRazonesform;
        RazonesFinancierasForm razonesFinancierasForm;

        public MenuRazonesFinancieras()
        {
            InitializeComponent();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            cuentasRazonesform = new CuentasRazonesForm();
            cuentasRazonesform.TopLevel = false;
            cuentasRazonesform.FormBorderStyle = FormBorderStyle.None;
            cuentasRazonesform.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(cuentasRazonesform);
            cuentasRazonesform.Show();
        }

        private void LimpiarPanelPrincipal()
        {
            panelContenedor.Controls.Clear();
        }

        private void btnRazones_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            razonesFinancierasForm = new RazonesFinancierasForm();
            razonesFinancierasForm.TopLevel = false;
            razonesFinancierasForm.FormBorderStyle = FormBorderStyle.None;
            razonesFinancierasForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(razonesFinancierasForm);
            razonesFinancierasForm.Show();
        }
    }
}
