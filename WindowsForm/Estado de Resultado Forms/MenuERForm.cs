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
    public partial class MenuERForm : Form
    {
        private DatosERForm datosERForm;
        private ClasificacionesForm clasificacionform;
        public MenuERForm()
        {
            InitializeComponent();
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            LimpiarPanelPrincipal();
            clasificacionform = new ClasificacionesForm();
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

        }
    }
}
