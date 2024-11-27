using WindowsForm.Models;
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
using WindowsForm.IRepository.Repository;
using WindowsForm.IRepository;

namespace WindowsForm
{
    public partial class PasivoCapitalBalanceForm : Form
    {
        private readonly IRepository<Pasivo_Capital> pasivocapitalrepository;
        private readonly IRepository<DatosBalanceG> balanceRepository;
        private readonly IRepository<Clasificacion> clasificacionrepository;
        private readonly CalculosBalanceRepository _repository;

        public PasivoCapitalBalanceForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            pasivocapitalrepository = new Pasivo_CapitalRepository(connectionString);
            balanceRepository = new BalanceRepository(connectionString);
            clasificacionrepository = new ClasificacionRepository(connectionString);
            CargarBalancesComboBox();
            CargarClasificacionesComboBox();
            RefreshData();
            txtMonto.TextChanged += (sender, args) => ActualizarTotal();
            _repository = new CalculosBalanceRepository(connectionString);

        }

        private void ActualizarTotal()
        {
            try
            {
                decimal total = 0;
                if (CbID_Balance.SelectedValue != null)
                {
                    int selectedBalanceId = Convert.ToInt32(CbID_Balance.SelectedValue);
                    var cuentas = pasivocapitalrepository.GetAll()
                                                   .Where(c => c.ID_DatosBalance == selectedBalanceId)
                                                   .ToList();
                    total = cuentas.Sum(c => c.Monto);
                    if (decimal.TryParse(txtMonto.Text, out decimal monto) && monto > 0)
                    {
                        if (txtCuenta.Text.Contains("Deducciones"))
                        {
                            total -= monto;
                        }
                        else
                        {
                            total += monto;
                        }
                    }
                    txtTotal.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el total: " + ex.Message);
            }

        }


        private void RefreshData()
        {
            try
            {
                var cuentas = pasivocapitalrepository.GetAll().ToList();
                dgvPasivosCapital.DataSource = cuentas;
                if (!cuentas.Any())
                {
                    txtTotal.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas. Error: " + ex.Message);
            }

        }

        private void ActivosCirculantesForm_Load(object sender, EventArgs e)
        {
            CargarBalancesComboBox();
            CargarClasificacionesComboBox();
            ActualizarTotal();
        }

        private void CargarBalancesComboBox()
        {
            try
            {
                var balances = balanceRepository.GetAll();
                CbID_Balance.DataSource = balances;
                CbID_Balance.DisplayMember = "NombreBG";
                CbID_Balance.ValueMember = "ID_DatosBalance";
                CbID_Balance.SelectedIndexChanged += (sender, args) => RefreshData();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar balances.");
            }
        }

        private void CargarClasificacionesComboBox()
        {
            try
            {
                var clasificaciones = clasificacionrepository.GetAll();
                cbClasificacioID.DataSource = clasificaciones;
                cbClasificacioID.DisplayMember = "Descripcion";
                cbClasificacioID.ValueMember = "ID_Clasificacion";
                cbClasificacioID.SelectedIndexChanged += (sender, args) => RefreshData();

                Console.WriteLine("Clasificaciones cargadas: " + clasificaciones.Count());
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las clasificaciones.");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCuenta.Text) || !decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("La cuenta debe ser seleccionada y el monto debe ser mayor que cero.");
                    return;
                }

                if (cbClasificacioID.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una clasificación.");
                    return;
                }

                int idClasificacion = Convert.ToInt32(cbClasificacioID.SelectedValue);

                int selectedBalanceId = Convert.ToInt32(CbID_Balance.SelectedValue);

                decimal totalAcumulado = pasivocapitalrepository.GetAll()
                                                         .Where(c => c.ID_DatosBalance == selectedBalanceId)
                                                         .Sum(c => c.Monto);

                if (txtCuenta.Text == "Deducciones")
                {
                    totalAcumulado -= monto;
                }
                else
                {
                    totalAcumulado += monto;
                }
                Activo newCuenta = new Activo
                {
                    NombreCuenta = txtCuenta.Text,
                    Monto = monto,
                    ID_DatosBalance = selectedBalanceId,
                    Total = totalAcumulado,
                    ID_Clasificacion = idClasificacion
                };

                pasivocapitalrepository.Add(newCuenta);
                RefreshData();
                txtMonto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la cuenta: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPasivosCapital.CurrentRow != null)
                {
                    Pasivo_Capital selectedCuenta = (Pasivo_Capital)dgvPasivosCapital.CurrentRow.DataBoundItem;
                    pasivocapitalrepository.Delete(selectedCuenta.ID_Pasivo_Capital);
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la cuenta: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnBalanceID_Click(object sender, EventArgs e)
        {
            DatosBalanceForm balanceForm = new DatosBalanceForm();
            balanceForm.Show();
        }
        private bool IsValidMonto(out decimal monto)
        {
            return decimal.TryParse(txtMonto.Text, out monto) && monto > 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPasivosCapital.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona una cuenta de pasivo para actualizar.");
                    return;
                }
                Pasivo_Capital selectedCuenta = (Pasivo_Capital)dgvPasivosCapital.CurrentRow.DataBoundItem;
                if (string.IsNullOrEmpty(txtCuenta.Text) || !decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("La cuenta debe ser seleccionada y el monto debe ser mayor que cero.");
                    return;
                }
                if (cbClasificacioID.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una clasificación.");
                    return;
                }
                int idClasificacion = Convert.ToInt32(cbClasificacioID.SelectedValue);
                int selectedBalanceId = Convert.ToInt32(CbID_Balance.SelectedValue);
                selectedCuenta.NombreCuenta = txtCuenta.Text;
                selectedCuenta.Monto = monto;
                selectedCuenta.ID_Clasificacion = idClasificacion;
                decimal totalAcumulado = pasivocapitalrepository.GetAll()
                                                          .Where(c => c.ID_DatosBalance == selectedBalanceId)
                                                          .Sum(c => c.Monto);
                if (txtCuenta.Text == "Deducciones")
                {
                    totalAcumulado -= monto;
                }
                else
                {
                    totalAcumulado += monto;
                }
                selectedCuenta.Total = totalAcumulado;
                pasivocapitalrepository.Update(selectedCuenta);
                RefreshData();
                ActualizarTotal();
                txtMonto.Clear();
                txtCuenta.Clear();
                cbClasificacioID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la cuenta de pasivo: {ex.Message}");
            }

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string nombreBG = CbID_Balance.Text;

        //        if (string.IsNullOrWhiteSpace(nombreBG))
        //        {
        //            MessageBox.Show("Por favor, ingresa un nombre de balance válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        decimal totalActivosCirculantes = _repository.GetCapitalSocial(nombreBG);

        //        textBox1.Text = totalActivosCirculantes.ToString("C"); // Formato de moneda
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
