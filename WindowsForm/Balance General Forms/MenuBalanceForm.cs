using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Models;

namespace WindowsForm
{
    public partial class MenuBalanceForm : Form
    {
        private ActivosBalanceForm cuentasBalanceForm;
        private DatosBalanceForm crearNumeroDeBalance;
        private ClasificacionesForm clasificacionform;
        private PasivoCapitalBalanceForm pasivoCapitalBalanceForm;
        public MenuBalanceForm()
        {
            InitializeComponent();
        }
        private void btnActivosCirculantes_Click(object sender, EventArgs e)
        {

            LimpiarPanelPrincipal();
            cuentasBalanceForm = new ActivosBalanceForm();
            cuentasBalanceForm.TopLevel = false;
            cuentasBalanceForm.FormBorderStyle = FormBorderStyle.None;
            cuentasBalanceForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(cuentasBalanceForm);
            cuentasBalanceForm.Show();
        }
        private void LimpiarPanelPrincipal()
        {
            panelContenedor.Controls.Clear();
        }

        private void BalanceGeneralForm_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBalances_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            crearNumeroDeBalance = new DatosBalanceForm();
            crearNumeroDeBalance.TopLevel = false;
            crearNumeroDeBalance.FormBorderStyle = FormBorderStyle.None;
            crearNumeroDeBalance.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(crearNumeroDeBalance);
            crearNumeroDeBalance.Show();
        }

        private void btnClasificaciones_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            clasificacionform = new ClasificacionesForm();
            clasificacionform.TopLevel = false;
            clasificacionform.FormBorderStyle = FormBorderStyle.None;
            clasificacionform.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(clasificacionform);
            clasificacionform.Show();
        }

        private void btnMostrarBalance_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            pasivoCapitalBalanceForm = new PasivoCapitalBalanceForm();
            pasivoCapitalBalanceForm.TopLevel = false;
            pasivoCapitalBalanceForm.FormBorderStyle = FormBorderStyle.None;
            pasivoCapitalBalanceForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(pasivoCapitalBalanceForm);
            pasivoCapitalBalanceForm.Show();
        }
    }
}
