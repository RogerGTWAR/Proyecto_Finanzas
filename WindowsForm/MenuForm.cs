using System.Net.Http;
namespace WindowsForm
{
    public partial class MenuForm : Form
    {
        private MenuBalanceForm balanceForm;
        private RazonesFinancierasForm razonesform;
        private MenuERForm menuERForm;
        public MenuForm()
        {
            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LimpiarPanelPrincipal()
        {
            panelContenedor.Controls.Clear();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            MostrarRegistroForm();
        }

        private void MostrarRegistroForm()
        {
            LimpiarPanelPrincipal();
            balanceForm = new MenuBalanceForm();
            balanceForm.TopLevel = false;
            balanceForm.FormBorderStyle = FormBorderStyle.None;
            balanceForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(balanceForm);
            balanceForm.Show();
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            //LimpiarPanelPrincipal();
            //ingresosForm = new IngresosyDeduccionesForm(_httpClient);
            //ingresosForm.TopLevel = false;
            //ingresosForm.FormBorderStyle = FormBorderStyle.None;
            //ingresosForm.Dock = DockStyle.Fill;
            //panelContenedor.Controls.Add(ingresosForm);
            //ingresosForm.Show();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
        }

        private void btnRazonesFinancieras_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            razonesform = new RazonesFinancierasForm();
            razonesform.TopLevel = false;
            razonesform.FormBorderStyle = FormBorderStyle.None;
            razonesform.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(razonesform);
            razonesform.Show();
        }

        private void btnER_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            menuERForm = new MenuERForm();
            menuERForm.TopLevel = false;
            menuERForm.FormBorderStyle = FormBorderStyle.None;
            menuERForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(menuERForm);
            menuERForm.Show();
        }
    }
}
