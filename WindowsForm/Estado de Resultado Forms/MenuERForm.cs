using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Estado_de_Resultado_Forms;

namespace WindowsForm
{
    public partial class MenuERForm : Form
    {
        private DatosERForm datosERForm;
        private ClasificacionesER clasificacionform;
        private Ingresos ing;
        private Gastos gastos;
        public MenuERForm()
        {
            InitializeComponent();
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            clasificacionform = new ClasificacionesER();
            clasificacionform.TopLevel = false;
            clasificacionform.FormBorderStyle = FormBorderStyle.None;
            clasificacionform.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(clasificacionform);
            clasificacionform.Show();
        }

        private void LimpiarPanelPrincipal()
        {
            panelContenedor.Controls.Clear();
        }
        //Falta
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            ing = new Ingresos();
            ing.TopLevel = false;
            ing.FormBorderStyle = FormBorderStyle.None;
            ing.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(ing);
            ing.Show();
        }

        private void btnER_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            datosERForm = new DatosERForm();
            datosERForm.TopLevel = false;
            datosERForm.FormBorderStyle = FormBorderStyle.None;
            datosERForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(datosERForm);
            datosERForm.Show();
        }
        //Falta
        private void btnEgresos_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            gastos = new Gastos();
            gastos.TopLevel = false;
            gastos.FormBorderStyle = FormBorderStyle.None;
            gastos.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(gastos);
            gastos.Show();
        }
    }
}
