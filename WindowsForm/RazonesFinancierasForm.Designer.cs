namespace WindowsForm
{
    partial class RazonesFinancierasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtMargenUtilidadNeta = new TextBox();
            txtRazonEndeudamiento = new TextBox();
            txtPruebaAcida = new TextBox();
            txtRazonCorriente = new TextBox();
            txtRotacionInventario = new TextBox();
            txtPeriodoPromedioCobro = new TextBox();
            txtRotacionCuentasPorCobrar = new TextBox();
            txtCapitalTrabajo = new TextBox();
            txtMargenBruto = new TextBox();
            btnRazonesFinancieras = new Button();
            label17 = new Label();
            label18 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            txtRotacionActivosFijos = new TextBox();
            txtRotacionActivosTotales = new TextBox();
            txtMargenUtilidadOperativa = new TextBox();
            txtRazonPasivoCapital = new TextBox();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            txtRotaciondeiau = new TextBox();
            groupBox4 = new GroupBox();
            cbID_DatosER = new ComboBox();
            cbID_CuentasDeRazones = new ComboBox();
            cbID_DatosBalance = new ComboBox();
            dgvRazones = new DataGridView();
            iDRazonesFinancierasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDCuentasDeRazonesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDatosBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDatosERDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capitalTrabajoNetoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razonCirculanteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pruebaAcidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rotacionInventarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            periodoPromedioCobroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rotacionActivosFijosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rotacionActivosTotalesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razonDeudaTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razonPasivoCapitalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mUBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mUODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mUNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razonesFinancieraBindingSource = new BindingSource(components);
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRazones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)razonesFinancieraBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(657, 24);
            label1.Name = "label1";
            label1.Size = new Size(298, 41);
            label1.TabIndex = 1;
            label1.Text = "Razones Financieras";
            // 
            // txtMargenUtilidadNeta
            // 
            txtMargenUtilidadNeta.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMargenUtilidadNeta.Location = new Point(72, 187);
            txtMargenUtilidadNeta.Name = "txtMargenUtilidadNeta";
            txtMargenUtilidadNeta.Size = new Size(155, 25);
            txtMargenUtilidadNeta.TabIndex = 30;
            // 
            // txtRazonEndeudamiento
            // 
            txtRazonEndeudamiento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRazonEndeudamiento.Location = new Point(82, 65);
            txtRazonEndeudamiento.Name = "txtRazonEndeudamiento";
            txtRazonEndeudamiento.Size = new Size(155, 27);
            txtRazonEndeudamiento.TabIndex = 32;
            // 
            // txtPruebaAcida
            // 
            txtPruebaAcida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPruebaAcida.Location = new Point(33, 208);
            txtPruebaAcida.Name = "txtPruebaAcida";
            txtPruebaAcida.Size = new Size(155, 27);
            txtPruebaAcida.TabIndex = 33;
            // 
            // txtRazonCorriente
            // 
            txtRazonCorriente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRazonCorriente.Location = new Point(30, 136);
            txtRazonCorriente.Name = "txtRazonCorriente";
            txtRazonCorriente.Size = new Size(155, 27);
            txtRazonCorriente.TabIndex = 34;
            // 
            // txtRotacionInventario
            // 
            txtRotacionInventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotacionInventario.Location = new Point(54, 65);
            txtRotacionInventario.Name = "txtRotacionInventario";
            txtRotacionInventario.Size = new Size(155, 27);
            txtRotacionInventario.TabIndex = 36;
            // 
            // txtPeriodoPromedioCobro
            // 
            txtPeriodoPromedioCobro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeriodoPromedioCobro.Location = new Point(307, 65);
            txtPeriodoPromedioCobro.Name = "txtPeriodoPromedioCobro";
            txtPeriodoPromedioCobro.Size = new Size(155, 27);
            txtPeriodoPromedioCobro.TabIndex = 38;
            // 
            // txtRotacionCuentasPorCobrar
            // 
            txtRotacionCuentasPorCobrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotacionCuentasPorCobrar.Location = new Point(47, 136);
            txtRotacionCuentasPorCobrar.Name = "txtRotacionCuentasPorCobrar";
            txtRotacionCuentasPorCobrar.Size = new Size(155, 27);
            txtRotacionCuentasPorCobrar.TabIndex = 39;
            // 
            // txtCapitalTrabajo
            // 
            txtCapitalTrabajo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapitalTrabajo.Location = new Point(30, 66);
            txtCapitalTrabajo.Name = "txtCapitalTrabajo";
            txtCapitalTrabajo.Size = new Size(155, 27);
            txtCapitalTrabajo.TabIndex = 40;
            // 
            // txtMargenBruto
            // 
            txtMargenBruto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMargenBruto.Location = new Point(72, 65);
            txtMargenBruto.Name = "txtMargenBruto";
            txtMargenBruto.Size = new Size(155, 27);
            txtMargenBruto.TabIndex = 41;
            // 
            // btnRazonesFinancieras
            // 
            btnRazonesFinancieras.BackColor = Color.White;
            btnRazonesFinancieras.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRazonesFinancieras.Location = new Point(130, 344);
            btnRazonesFinancieras.Name = "btnRazonesFinancieras";
            btnRazonesFinancieras.Size = new Size(131, 52);
            btnRazonesFinancieras.TabIndex = 42;
            btnRazonesFinancieras.Text = "Calculo";
            btnRazonesFinancieras.UseVisualStyleBackColor = false;
            btnRazonesFinancieras.Click += btnRazonesFinancieras_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(31, 34);
            label17.Name = "label17";
            label17.Size = new Size(233, 28);
            label17.TabIndex = 43;
            label17.Text = "Margen de Utilidad Bruta";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(30, 34);
            label18.Name = "label18";
            label18.Size = new Size(169, 28);
            label18.TabIndex = 44;
            label18.Text = "Capital de Trabajo";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(23, 34);
            label20.Name = "label20";
            label20.Size = new Size(209, 28);
            label20.TabIndex = 46;
            label20.Text = "Rotacion de Inventario";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(27, 105);
            label21.Name = "label21";
            label21.Size = new Size(158, 28);
            label21.TabIndex = 47;
            label21.Text = "Razon Circulante";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(33, 180);
            label22.Name = "label22";
            label22.Size = new Size(132, 28);
            label22.TabIndex = 48;
            label22.Text = "Razon Rapida";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.White;
            label24.Location = new Point(23, 105);
            label24.Name = "label24";
            label24.Size = new Size(261, 28);
            label24.TabIndex = 50;
            label24.Text = "Rotacion Cuentas por cobrar";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.White;
            label25.Location = new Point(272, 34);
            label25.Name = "label25";
            label25.Size = new Size(256, 28);
            label25.TabIndex = 51;
            label25.Text = "Periodo promedio de cobro";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.White;
            label26.Location = new Point(62, 34);
            label26.Name = "label26";
            label26.Size = new Size(202, 28);
            label26.TabIndex = 52;
            label26.Text = "Razon de Deuda Total";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.White;
            label27.Location = new Point(35, 156);
            label27.Name = "label27";
            label27.Size = new Size(229, 28);
            label27.TabIndex = 53;
            label27.Text = "Margen de Utilidad Neta";
            // 
            // txtRotacionActivosFijos
            // 
            txtRotacionActivosFijos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotacionActivosFijos.Location = new Point(306, 136);
            txtRotacionActivosFijos.Name = "txtRotacionActivosFijos";
            txtRotacionActivosFijos.Size = new Size(155, 27);
            txtRotacionActivosFijos.TabIndex = 58;
            // 
            // txtRotacionActivosTotales
            // 
            txtRotacionActivosTotales.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotacionActivosTotales.Location = new Point(157, 211);
            txtRotacionActivosTotales.Name = "txtRotacionActivosTotales";
            txtRotacionActivosTotales.Size = new Size(155, 27);
            txtRotacionActivosTotales.TabIndex = 59;
            // 
            // txtMargenUtilidadOperativa
            // 
            txtMargenUtilidadOperativa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMargenUtilidadOperativa.Location = new Point(72, 126);
            txtMargenUtilidadOperativa.Name = "txtMargenUtilidadOperativa";
            txtMargenUtilidadOperativa.Size = new Size(155, 27);
            txtMargenUtilidadOperativa.TabIndex = 60;
            // 
            // txtRazonPasivoCapital
            // 
            txtRazonPasivoCapital.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRazonPasivoCapital.Location = new Point(78, 136);
            txtRazonPasivoCapital.Name = "txtRazonPasivoCapital";
            txtRazonPasivoCapital.Size = new Size(155, 27);
            txtRazonPasivoCapital.TabIndex = 61;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.White;
            label31.Location = new Point(17, 95);
            label31.Name = "label31";
            label31.Size = new Size(299, 28);
            label31.TabIndex = 62;
            label31.Text = "Margen de utilidad de operacion";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.ForeColor = Color.White;
            label32.Location = new Point(136, 180);
            label32.Name = "label32";
            label32.Size = new Size(228, 28);
            label32.TabIndex = 63;
            label32.Text = "Rotacion Activos Totales ";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label33.ForeColor = Color.White;
            label33.Location = new Point(290, 105);
            label33.Name = "label33";
            label33.Size = new Size(203, 28);
            label33.TabIndex = 64;
            label33.Text = "Rotacion Activos Fijos";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.White;
            label34.Location = new Point(62, 105);
            label34.Name = "label34";
            label34.Size = new Size(207, 28);
            label34.TabIndex = 65;
            label34.Text = "Razon Pasivo a Capital";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(txtCapitalTrabajo);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(txtRazonCorriente);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(txtPruebaAcida);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(22, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 249);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Razones Liquidas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(txtRotacionInventario);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(label33);
            groupBox2.Controls.Add(txtRotacionCuentasPorCobrar);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(txtRotacionActivosTotales);
            groupBox2.Controls.Add(txtPeriodoPromedioCobro);
            groupBox2.Controls.Add(txtRotacionActivosFijos);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(256, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 249);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Razones de Actividad";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtRotaciondeiau);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(txtRazonEndeudamiento);
            groupBox3.Controls.Add(label34);
            groupBox3.Controls.Add(txtRazonPasivoCapital);
            groupBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(837, 68);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 249);
            groupBox3.TabIndex = 68;
            groupBox3.TabStop = false;
            groupBox3.Text = "Razones de Endeudamiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 180);
            label2.Name = "label2";
            label2.Size = new Size(284, 28);
            label2.TabIndex = 70;
            label2.Text = "Rotacion de interes a utilidades";
            // 
            // txtRotaciondeiau
            // 
            txtRotaciondeiau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotaciondeiau.Location = new Point(80, 211);
            txtRotaciondeiau.Name = "txtRotaciondeiau";
            txtRotaciondeiau.Size = new Size(155, 27);
            txtRotaciondeiau.TabIndex = 69;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(txtMargenBruto);
            groupBox4.Controls.Add(label31);
            groupBox4.Controls.Add(txtMargenUtilidadOperativa);
            groupBox4.Controls.Add(label27);
            groupBox4.Controls.Add(txtMargenUtilidadNeta);
            groupBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(1251, 68);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(325, 249);
            groupBox4.TabIndex = 69;
            groupBox4.TabStop = false;
            groupBox4.Text = "Razones de Rentabilidad";
            // 
            // cbID_DatosER
            // 
            cbID_DatosER.FormattingEnabled = true;
            cbID_DatosER.Location = new Point(872, 361);
            cbID_DatosER.Name = "cbID_DatosER";
            cbID_DatosER.Size = new Size(151, 28);
            cbID_DatosER.TabIndex = 71;
            // 
            // cbID_CuentasDeRazones
            // 
            cbID_CuentasDeRazones.FormattingEnabled = true;
            cbID_CuentasDeRazones.Location = new Point(413, 361);
            cbID_CuentasDeRazones.Name = "cbID_CuentasDeRazones";
            cbID_CuentasDeRazones.Size = new Size(151, 28);
            cbID_CuentasDeRazones.TabIndex = 72;
            // 
            // cbID_DatosBalance
            // 
            cbID_DatosBalance.FormattingEnabled = true;
            cbID_DatosBalance.Location = new Point(639, 361);
            cbID_DatosBalance.Name = "cbID_DatosBalance";
            cbID_DatosBalance.Size = new Size(151, 28);
            cbID_DatosBalance.TabIndex = 73;
            // 
            // dgvRazones
            // 
            dgvRazones.AutoGenerateColumns = false;
            dgvRazones.BackgroundColor = Color.White;
            dgvRazones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazones.Columns.AddRange(new DataGridViewColumn[] { iDRazonesFinancierasDataGridViewTextBoxColumn, iDCuentasDeRazonesDataGridViewTextBoxColumn, iDDatosBalanceDataGridViewTextBoxColumn, iDDatosERDataGridViewTextBoxColumn, capitalTrabajoNetoDataGridViewTextBoxColumn, razonCirculanteDataGridViewTextBoxColumn, pruebaAcidaDataGridViewTextBoxColumn, rotacionInventarioDataGridViewTextBoxColumn, rotacionCuentasPorCobrarDataGridViewTextBoxColumn, periodoPromedioCobroDataGridViewTextBoxColumn, rotacionActivosFijosDataGridViewTextBoxColumn, rotacionActivosTotalesDataGridViewTextBoxColumn, razonDeudaTotalDataGridViewTextBoxColumn, razonPasivoCapitalDataGridViewTextBoxColumn, razonRotacionInteresUtilidadDataGridViewTextBoxColumn, mUBDataGridViewTextBoxColumn, mUODataGridViewTextBoxColumn, mUNDataGridViewTextBoxColumn });
            dgvRazones.DataSource = razonesFinancieraBindingSource;
            dgvRazones.Dock = DockStyle.Bottom;
            dgvRazones.Location = new Point(0, 428);
            dgvRazones.Name = "dgvRazones";
            dgvRazones.ReadOnly = true;
            dgvRazones.RowHeadersWidth = 51;
            dgvRazones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRazones.Size = new Size(1576, 621);
            dgvRazones.TabIndex = 74;
            // 
            // iDRazonesFinancierasDataGridViewTextBoxColumn
            // 
            iDRazonesFinancierasDataGridViewTextBoxColumn.DataPropertyName = "ID_RazonesFinancieras";
            iDRazonesFinancierasDataGridViewTextBoxColumn.HeaderText = "ID";
            iDRazonesFinancierasDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDRazonesFinancierasDataGridViewTextBoxColumn.Name = "iDRazonesFinancierasDataGridViewTextBoxColumn";
            iDRazonesFinancierasDataGridViewTextBoxColumn.ReadOnly = true;
            iDRazonesFinancierasDataGridViewTextBoxColumn.Width = 70;
            // 
            // iDCuentasDeRazonesDataGridViewTextBoxColumn
            // 
            iDCuentasDeRazonesDataGridViewTextBoxColumn.DataPropertyName = "ID_CuentasDeRazones";
            iDCuentasDeRazonesDataGridViewTextBoxColumn.HeaderText = "ID de las Cuentas";
            iDCuentasDeRazonesDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDCuentasDeRazonesDataGridViewTextBoxColumn.Name = "iDCuentasDeRazonesDataGridViewTextBoxColumn";
            iDCuentasDeRazonesDataGridViewTextBoxColumn.ReadOnly = true;
            iDCuentasDeRazonesDataGridViewTextBoxColumn.Width = 80;
            // 
            // iDDatosBalanceDataGridViewTextBoxColumn
            // 
            iDDatosBalanceDataGridViewTextBoxColumn.DataPropertyName = "ID_DatosBalance";
            iDDatosBalanceDataGridViewTextBoxColumn.HeaderText = "ID del Balance";
            iDDatosBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDatosBalanceDataGridViewTextBoxColumn.Name = "iDDatosBalanceDataGridViewTextBoxColumn";
            iDDatosBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            iDDatosBalanceDataGridViewTextBoxColumn.Width = 80;
            // 
            // iDDatosERDataGridViewTextBoxColumn
            // 
            iDDatosERDataGridViewTextBoxColumn.DataPropertyName = "ID_DatosER";
            iDDatosERDataGridViewTextBoxColumn.HeaderText = "ID del Estado de Resultado";
            iDDatosERDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDatosERDataGridViewTextBoxColumn.Name = "iDDatosERDataGridViewTextBoxColumn";
            iDDatosERDataGridViewTextBoxColumn.ReadOnly = true;
            iDDatosERDataGridViewTextBoxColumn.Width = 90;
            // 
            // capitalTrabajoNetoDataGridViewTextBoxColumn
            // 
            capitalTrabajoNetoDataGridViewTextBoxColumn.DataPropertyName = "CapitalTrabajoNeto";
            capitalTrabajoNetoDataGridViewTextBoxColumn.HeaderText = "Capital Trabajo";
            capitalTrabajoNetoDataGridViewTextBoxColumn.MinimumWidth = 6;
            capitalTrabajoNetoDataGridViewTextBoxColumn.Name = "capitalTrabajoNetoDataGridViewTextBoxColumn";
            capitalTrabajoNetoDataGridViewTextBoxColumn.ReadOnly = true;
            capitalTrabajoNetoDataGridViewTextBoxColumn.Width = 120;
            // 
            // razonCirculanteDataGridViewTextBoxColumn
            // 
            razonCirculanteDataGridViewTextBoxColumn.DataPropertyName = "RazonCirculante";
            razonCirculanteDataGridViewTextBoxColumn.HeaderText = "Razon Circulante";
            razonCirculanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            razonCirculanteDataGridViewTextBoxColumn.Name = "razonCirculanteDataGridViewTextBoxColumn";
            razonCirculanteDataGridViewTextBoxColumn.ReadOnly = true;
            razonCirculanteDataGridViewTextBoxColumn.Width = 120;
            // 
            // pruebaAcidaDataGridViewTextBoxColumn
            // 
            pruebaAcidaDataGridViewTextBoxColumn.DataPropertyName = "PruebaAcida";
            pruebaAcidaDataGridViewTextBoxColumn.HeaderText = "Prueba Acida";
            pruebaAcidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            pruebaAcidaDataGridViewTextBoxColumn.Name = "pruebaAcidaDataGridViewTextBoxColumn";
            pruebaAcidaDataGridViewTextBoxColumn.ReadOnly = true;
            pruebaAcidaDataGridViewTextBoxColumn.Width = 120;
            // 
            // rotacionInventarioDataGridViewTextBoxColumn
            // 
            rotacionInventarioDataGridViewTextBoxColumn.DataPropertyName = "RotacionInventario";
            rotacionInventarioDataGridViewTextBoxColumn.HeaderText = "Rotacion Inventario";
            rotacionInventarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            rotacionInventarioDataGridViewTextBoxColumn.Name = "rotacionInventarioDataGridViewTextBoxColumn";
            rotacionInventarioDataGridViewTextBoxColumn.ReadOnly = true;
            rotacionInventarioDataGridViewTextBoxColumn.Width = 120;
            // 
            // rotacionCuentasPorCobrarDataGridViewTextBoxColumn
            // 
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.DataPropertyName = "RotacionCuentasPorCobrar";
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.HeaderText = "Rotacion de CxC";
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.MinimumWidth = 6;
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.Name = "rotacionCuentasPorCobrarDataGridViewTextBoxColumn";
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.ReadOnly = true;
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.Width = 125;
            // 
            // periodoPromedioCobroDataGridViewTextBoxColumn
            // 
            periodoPromedioCobroDataGridViewTextBoxColumn.DataPropertyName = "PeriodoPromedioCobro";
            periodoPromedioCobroDataGridViewTextBoxColumn.HeaderText = "Periodo Promedio Cobro";
            periodoPromedioCobroDataGridViewTextBoxColumn.MinimumWidth = 6;
            periodoPromedioCobroDataGridViewTextBoxColumn.Name = "periodoPromedioCobroDataGridViewTextBoxColumn";
            periodoPromedioCobroDataGridViewTextBoxColumn.ReadOnly = true;
            periodoPromedioCobroDataGridViewTextBoxColumn.Width = 120;
            // 
            // rotacionActivosFijosDataGridViewTextBoxColumn
            // 
            rotacionActivosFijosDataGridViewTextBoxColumn.DataPropertyName = "RotacionActivosFijos";
            rotacionActivosFijosDataGridViewTextBoxColumn.HeaderText = "Rotacion Activos Fijos";
            rotacionActivosFijosDataGridViewTextBoxColumn.MinimumWidth = 6;
            rotacionActivosFijosDataGridViewTextBoxColumn.Name = "rotacionActivosFijosDataGridViewTextBoxColumn";
            rotacionActivosFijosDataGridViewTextBoxColumn.ReadOnly = true;
            rotacionActivosFijosDataGridViewTextBoxColumn.Width = 120;
            // 
            // rotacionActivosTotalesDataGridViewTextBoxColumn
            // 
            rotacionActivosTotalesDataGridViewTextBoxColumn.DataPropertyName = "RotacionActivosTotales";
            rotacionActivosTotalesDataGridViewTextBoxColumn.HeaderText = "Rotacion Activos Totales";
            rotacionActivosTotalesDataGridViewTextBoxColumn.MinimumWidth = 6;
            rotacionActivosTotalesDataGridViewTextBoxColumn.Name = "rotacionActivosTotalesDataGridViewTextBoxColumn";
            rotacionActivosTotalesDataGridViewTextBoxColumn.ReadOnly = true;
            rotacionActivosTotalesDataGridViewTextBoxColumn.Width = 120;
            // 
            // razonDeudaTotalDataGridViewTextBoxColumn
            // 
            razonDeudaTotalDataGridViewTextBoxColumn.DataPropertyName = "RazonDeudaTotal";
            razonDeudaTotalDataGridViewTextBoxColumn.HeaderText = "Razon Deuda Total";
            razonDeudaTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            razonDeudaTotalDataGridViewTextBoxColumn.Name = "razonDeudaTotalDataGridViewTextBoxColumn";
            razonDeudaTotalDataGridViewTextBoxColumn.ReadOnly = true;
            razonDeudaTotalDataGridViewTextBoxColumn.Width = 120;
            // 
            // razonPasivoCapitalDataGridViewTextBoxColumn
            // 
            razonPasivoCapitalDataGridViewTextBoxColumn.DataPropertyName = "RazonPasivoCapital";
            razonPasivoCapitalDataGridViewTextBoxColumn.HeaderText = "Razon Pasivo Capital";
            razonPasivoCapitalDataGridViewTextBoxColumn.MinimumWidth = 6;
            razonPasivoCapitalDataGridViewTextBoxColumn.Name = "razonPasivoCapitalDataGridViewTextBoxColumn";
            razonPasivoCapitalDataGridViewTextBoxColumn.ReadOnly = true;
            razonPasivoCapitalDataGridViewTextBoxColumn.Width = 120;
            // 
            // razonRotacionInteresUtilidadDataGridViewTextBoxColumn
            // 
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.DataPropertyName = "RazonRotacionInteresUtilidad";
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.HeaderText = "Razon Rotacion Interes Utilidad";
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.Name = "razonRotacionInteresUtilidadDataGridViewTextBoxColumn";
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.ReadOnly = true;
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.Width = 120;
            // 
            // mUBDataGridViewTextBoxColumn
            // 
            mUBDataGridViewTextBoxColumn.DataPropertyName = "MUB";
            mUBDataGridViewTextBoxColumn.HeaderText = "MUB";
            mUBDataGridViewTextBoxColumn.MinimumWidth = 6;
            mUBDataGridViewTextBoxColumn.Name = "mUBDataGridViewTextBoxColumn";
            mUBDataGridViewTextBoxColumn.ReadOnly = true;
            mUBDataGridViewTextBoxColumn.Width = 120;
            // 
            // mUODataGridViewTextBoxColumn
            // 
            mUODataGridViewTextBoxColumn.DataPropertyName = "MUO";
            mUODataGridViewTextBoxColumn.HeaderText = "MUO";
            mUODataGridViewTextBoxColumn.MinimumWidth = 6;
            mUODataGridViewTextBoxColumn.Name = "mUODataGridViewTextBoxColumn";
            mUODataGridViewTextBoxColumn.ReadOnly = true;
            mUODataGridViewTextBoxColumn.Width = 125;
            // 
            // mUNDataGridViewTextBoxColumn
            // 
            mUNDataGridViewTextBoxColumn.DataPropertyName = "MUN";
            mUNDataGridViewTextBoxColumn.HeaderText = "MUN";
            mUNDataGridViewTextBoxColumn.MinimumWidth = 6;
            mUNDataGridViewTextBoxColumn.Name = "mUNDataGridViewTextBoxColumn";
            mUNDataGridViewTextBoxColumn.ReadOnly = true;
            mUNDataGridViewTextBoxColumn.Width = 125;
            // 
            // razonesFinancieraBindingSource
            // 
            razonesFinancieraBindingSource.DataSource = typeof(Models.RazonesFinanciera);
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvRazones);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnRazonesFinancieras);
            panel1.Controls.Add(cbID_DatosBalance);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(cbID_CuentasDeRazones);
            panel1.Controls.Add(cbID_DatosER);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox4);
            panel1.Location = new Point(291, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1576, 1049);
            panel1.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(872, 330);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 76;
            label5.Text = "Balance General";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(619, 330);
            label4.Name = "label4";
            label4.Size = new Size(189, 28);
            label4.TabIndex = 75;
            label4.Text = "Estado de Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(446, 330);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 65;
            label3.Text = "Cuentas";
            // 
            // RazonesFinancierasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1914, 1096);
            Controls.Add(panel1);
            Name = "RazonesFinancierasForm";
            Text = "  RazonesFinancierasForm";
            Load += RazonesFinancierasForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRazones).EndInit();
            ((System.ComponentModel.ISupportInitialize)razonesFinancieraBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtMargenUtilidadNeta;
        private TextBox txtRazonEndeudamiento;
        private TextBox txtPruebaAcida;
        private TextBox txtRazonCorriente;
        private TextBox txtRotacionInventario;
        private TextBox txtPeriodoPromedioCobro;
        private TextBox txtRotacionCuentasPorCobrar;
        private TextBox txtCapitalTrabajo;
        private TextBox txtMargenBruto;
        private Button btnRazonesFinancieras;
        private Label label17;
        private Label label18;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private TextBox txtRotacionActivosFijos;
        private TextBox txtRotacionActivosTotales;
        private TextBox txtMargenUtilidadOperativa;
        private TextBox txtRazonPasivoCapital;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox txtRotaciondeiau;
        private GroupBox groupBox4;
        private ComboBox cbID_DatosER;
        private ComboBox cbID_CuentasDeRazones;
        private ComboBox cbID_DatosBalance;
        private DataGridView dgvRazones;
        private BindingSource razonesFinancieraBindingSource;
        private DataGridViewTextBoxColumn iDRazonesFinancierasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDCuentasDeRazonesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDatosBalanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDatosERDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capitalTrabajoNetoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razonCirculanteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pruebaAcidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rotacionInventarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rotacionCuentasPorCobrarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn periodoPromedioCobroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rotacionActivosFijosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rotacionActivosTotalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razonDeudaTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razonPasivoCapitalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razonRotacionInteresUtilidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mUBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mUODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mUNDataGridViewTextBoxColumn;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}