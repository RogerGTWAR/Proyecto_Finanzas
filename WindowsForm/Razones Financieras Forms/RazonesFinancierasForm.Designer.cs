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
            iDRazonFinancieraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            utilidadporAccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razonPrecioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorenLibrosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorenLibrosporAccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razonesFinancieraBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            groupBox5 = new GroupBox();
            label9 = new Label();
            txtValorenLibrosA = new TextBox();
            label6 = new Label();
            txtUtilidadporAccion = new TextBox();
            label7 = new Label();
            txtRazonPrecio = new TextBox();
            label8 = new Label();
            txtValorenLibros = new TextBox();
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
            groupBox5.SuspendLayout();
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
            txtMargenUtilidadNeta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMargenUtilidadNeta.Location = new Point(57, 187);
            txtMargenUtilidadNeta.Name = "txtMargenUtilidadNeta";
            txtMargenUtilidadNeta.Size = new Size(155, 27);
            txtMargenUtilidadNeta.TabIndex = 30;
            // 
            // txtRazonEndeudamiento
            // 
            txtRazonEndeudamiento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRazonEndeudamiento.Location = new Point(53, 65);
            txtRazonEndeudamiento.Name = "txtRazonEndeudamiento";
            txtRazonEndeudamiento.Size = new Size(155, 27);
            txtRazonEndeudamiento.TabIndex = 32;
            // 
            // txtPruebaAcida
            // 
            txtPruebaAcida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPruebaAcida.Location = new Point(6, 211);
            txtPruebaAcida.Name = "txtPruebaAcida";
            txtPruebaAcida.Size = new Size(155, 27);
            txtPruebaAcida.TabIndex = 33;
            // 
            // txtRazonCorriente
            // 
            txtRazonCorriente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRazonCorriente.Location = new Point(6, 136);
            txtRazonCorriente.Name = "txtRazonCorriente";
            txtRazonCorriente.Size = new Size(155, 27);
            txtRazonCorriente.TabIndex = 34;
            // 
            // txtRotacionInventario
            // 
            txtRotacionInventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotacionInventario.Location = new Point(37, 65);
            txtRotacionInventario.Name = "txtRotacionInventario";
            txtRotacionInventario.Size = new Size(155, 27);
            txtRotacionInventario.TabIndex = 36;
            // 
            // txtPeriodoPromedioCobro
            // 
            txtPeriodoPromedioCobro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeriodoPromedioCobro.Location = new Point(283, 65);
            txtPeriodoPromedioCobro.Name = "txtPeriodoPromedioCobro";
            txtPeriodoPromedioCobro.Size = new Size(155, 27);
            txtPeriodoPromedioCobro.TabIndex = 38;
            // 
            // txtRotacionCuentasPorCobrar
            // 
            txtRotacionCuentasPorCobrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotacionCuentasPorCobrar.Location = new Point(30, 136);
            txtRotacionCuentasPorCobrar.Name = "txtRotacionCuentasPorCobrar";
            txtRotacionCuentasPorCobrar.Size = new Size(155, 27);
            txtRotacionCuentasPorCobrar.TabIndex = 39;
            // 
            // txtCapitalTrabajo
            // 
            txtCapitalTrabajo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapitalTrabajo.Location = new Point(6, 66);
            txtCapitalTrabajo.Name = "txtCapitalTrabajo";
            txtCapitalTrabajo.Size = new Size(155, 27);
            txtCapitalTrabajo.TabIndex = 40;
            // 
            // txtMargenBruto
            // 
            txtMargenBruto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMargenBruto.Location = new Point(57, 65);
            txtMargenBruto.Name = "txtMargenBruto";
            txtMargenBruto.Size = new Size(155, 27);
            txtMargenBruto.TabIndex = 41;
            // 
            // btnRazonesFinancieras
            // 
            btnRazonesFinancieras.BackColor = Color.SeaGreen;
            btnRazonesFinancieras.FlatStyle = FlatStyle.Popup;
            btnRazonesFinancieras.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRazonesFinancieras.Location = new Point(45, 344);
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
            label17.Location = new Point(16, 34);
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
            label18.Location = new Point(6, 34);
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
            label20.Location = new Point(6, 34);
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
            label21.Location = new Point(3, 105);
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
            label22.Location = new Point(9, 180);
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
            label24.Location = new Point(6, 105);
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
            label25.Location = new Point(242, 34);
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
            label26.Location = new Point(33, 34);
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
            label27.Location = new Point(20, 156);
            label27.Name = "label27";
            label27.Size = new Size(229, 28);
            label27.TabIndex = 53;
            label27.Text = "Margen de Utilidad Neta";
            // 
            // txtRotacionActivosFijos
            // 
            txtRotacionActivosFijos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotacionActivosFijos.Location = new Point(282, 136);
            txtRotacionActivosFijos.Name = "txtRotacionActivosFijos";
            txtRotacionActivosFijos.Size = new Size(155, 27);
            txtRotacionActivosFijos.TabIndex = 58;
            // 
            // txtRotacionActivosTotales
            // 
            txtRotacionActivosTotales.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotacionActivosTotales.Location = new Point(126, 211);
            txtRotacionActivosTotales.Name = "txtRotacionActivosTotales";
            txtRotacionActivosTotales.Size = new Size(155, 27);
            txtRotacionActivosTotales.TabIndex = 59;
            // 
            // txtMargenUtilidadOperativa
            // 
            txtMargenUtilidadOperativa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMargenUtilidadOperativa.Location = new Point(57, 126);
            txtMargenUtilidadOperativa.Name = "txtMargenUtilidadOperativa";
            txtMargenUtilidadOperativa.Size = new Size(155, 27);
            txtMargenUtilidadOperativa.TabIndex = 60;
            // 
            // txtRazonPasivoCapital
            // 
            txtRazonPasivoCapital.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRazonPasivoCapital.Location = new Point(49, 136);
            txtRazonPasivoCapital.Name = "txtRazonPasivoCapital";
            txtRazonPasivoCapital.Size = new Size(155, 27);
            txtRazonPasivoCapital.TabIndex = 61;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.White;
            label31.Location = new Point(2, 95);
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
            label32.Location = new Point(100, 180);
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
            label33.Location = new Point(266, 105);
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
            label34.Location = new Point(33, 105);
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
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(22, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 249);
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
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(210, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 249);
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
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(720, 68);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(292, 249);
            groupBox3.TabIndex = 68;
            groupBox3.TabStop = false;
            groupBox3.Text = "Razones de Endeudamiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 180);
            label2.Name = "label2";
            label2.Size = new Size(284, 28);
            label2.TabIndex = 70;
            label2.Text = "Rotacion de interes a utilidades";
            // 
            // txtRotaciondeiau
            // 
            txtRotaciondeiau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRotaciondeiau.Location = new Point(51, 211);
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
            groupBox4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(1018, 68);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 249);
            groupBox4.TabIndex = 69;
            groupBox4.TabStop = false;
            groupBox4.Text = "Razones de Rentabilidad";
            // 
            // cbID_DatosER
            // 
            cbID_DatosER.FormattingEnabled = true;
            cbID_DatosER.Location = new Point(484, 38);
            cbID_DatosER.Name = "cbID_DatosER";
            cbID_DatosER.Size = new Size(151, 28);
            cbID_DatosER.TabIndex = 71;
            // 
            // cbID_CuentasDeRazones
            // 
            cbID_CuentasDeRazones.FormattingEnabled = true;
            cbID_CuentasDeRazones.Location = new Point(25, 38);
            cbID_CuentasDeRazones.Name = "cbID_CuentasDeRazones";
            cbID_CuentasDeRazones.Size = new Size(151, 28);
            cbID_CuentasDeRazones.TabIndex = 72;
            // 
            // cbID_DatosBalance
            // 
            cbID_DatosBalance.FormattingEnabled = true;
            cbID_DatosBalance.Location = new Point(251, 38);
            cbID_DatosBalance.Name = "cbID_DatosBalance";
            cbID_DatosBalance.Size = new Size(151, 28);
            cbID_DatosBalance.TabIndex = 73;
            // 
            // dgvRazones
            // 
            dgvRazones.AutoGenerateColumns = false;
            dgvRazones.BackgroundColor = Color.White;
            dgvRazones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazones.Columns.AddRange(new DataGridViewColumn[] { iDRazonFinancieraDataGridViewTextBoxColumn, iDCuentasDeRazonesDataGridViewTextBoxColumn, iDDatosBalanceDataGridViewTextBoxColumn, iDDatosERDataGridViewTextBoxColumn, capitalTrabajoNetoDataGridViewTextBoxColumn, razonCirculanteDataGridViewTextBoxColumn, pruebaAcidaDataGridViewTextBoxColumn, rotacionInventarioDataGridViewTextBoxColumn, rotacionCuentasPorCobrarDataGridViewTextBoxColumn, periodoPromedioCobroDataGridViewTextBoxColumn, rotacionActivosFijosDataGridViewTextBoxColumn, rotacionActivosTotalesDataGridViewTextBoxColumn, razonDeudaTotalDataGridViewTextBoxColumn, razonPasivoCapitalDataGridViewTextBoxColumn, razonRotacionInteresUtilidadDataGridViewTextBoxColumn, mUBDataGridViewTextBoxColumn, mUODataGridViewTextBoxColumn, mUNDataGridViewTextBoxColumn, utilidadporAccionDataGridViewTextBoxColumn, razonPrecioDataGridViewTextBoxColumn, valorenLibrosDataGridViewTextBoxColumn, valorenLibrosporAccionDataGridViewTextBoxColumn });
            dgvRazones.DataSource = razonesFinancieraBindingSource;
            dgvRazones.Dock = DockStyle.Bottom;
            dgvRazones.Location = new Point(0, 404);
            dgvRazones.Name = "dgvRazones";
            dgvRazones.ReadOnly = true;
            dgvRazones.RowHeadersWidth = 51;
            dgvRazones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRazones.Size = new Size(1572, 277);
            dgvRazones.TabIndex = 74;
            // 
            // iDRazonFinancieraDataGridViewTextBoxColumn
            // 
            iDRazonFinancieraDataGridViewTextBoxColumn.DataPropertyName = "ID_RazonFinanciera";
            iDRazonFinancieraDataGridViewTextBoxColumn.HeaderText = "ID_RazonFinanciera";
            iDRazonFinancieraDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDRazonFinancieraDataGridViewTextBoxColumn.Name = "iDRazonFinancieraDataGridViewTextBoxColumn";
            iDRazonFinancieraDataGridViewTextBoxColumn.ReadOnly = true;
            iDRazonFinancieraDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCuentasDeRazonesDataGridViewTextBoxColumn
            // 
            iDCuentasDeRazonesDataGridViewTextBoxColumn.DataPropertyName = "ID_CuentasDeRazones";
            iDCuentasDeRazonesDataGridViewTextBoxColumn.HeaderText = "ID_CuentasDeRazones";
            iDCuentasDeRazonesDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDCuentasDeRazonesDataGridViewTextBoxColumn.Name = "iDCuentasDeRazonesDataGridViewTextBoxColumn";
            iDCuentasDeRazonesDataGridViewTextBoxColumn.ReadOnly = true;
            iDCuentasDeRazonesDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDatosBalanceDataGridViewTextBoxColumn
            // 
            iDDatosBalanceDataGridViewTextBoxColumn.DataPropertyName = "ID_DatosBalance";
            iDDatosBalanceDataGridViewTextBoxColumn.HeaderText = "ID_DatosBalance";
            iDDatosBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDatosBalanceDataGridViewTextBoxColumn.Name = "iDDatosBalanceDataGridViewTextBoxColumn";
            iDDatosBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            iDDatosBalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDatosERDataGridViewTextBoxColumn
            // 
            iDDatosERDataGridViewTextBoxColumn.DataPropertyName = "ID_DatosER";
            iDDatosERDataGridViewTextBoxColumn.HeaderText = "ID_DatosER";
            iDDatosERDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDatosERDataGridViewTextBoxColumn.Name = "iDDatosERDataGridViewTextBoxColumn";
            iDDatosERDataGridViewTextBoxColumn.ReadOnly = true;
            iDDatosERDataGridViewTextBoxColumn.Width = 125;
            // 
            // capitalTrabajoNetoDataGridViewTextBoxColumn
            // 
            capitalTrabajoNetoDataGridViewTextBoxColumn.DataPropertyName = "CapitalTrabajoNeto";
            capitalTrabajoNetoDataGridViewTextBoxColumn.HeaderText = "CapitalTrabajoNeto";
            capitalTrabajoNetoDataGridViewTextBoxColumn.MinimumWidth = 6;
            capitalTrabajoNetoDataGridViewTextBoxColumn.Name = "capitalTrabajoNetoDataGridViewTextBoxColumn";
            capitalTrabajoNetoDataGridViewTextBoxColumn.ReadOnly = true;
            capitalTrabajoNetoDataGridViewTextBoxColumn.Width = 125;
            // 
            // razonCirculanteDataGridViewTextBoxColumn
            // 
            razonCirculanteDataGridViewTextBoxColumn.DataPropertyName = "RazonCirculante";
            razonCirculanteDataGridViewTextBoxColumn.HeaderText = "RazonCirculante";
            razonCirculanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            razonCirculanteDataGridViewTextBoxColumn.Name = "razonCirculanteDataGridViewTextBoxColumn";
            razonCirculanteDataGridViewTextBoxColumn.ReadOnly = true;
            razonCirculanteDataGridViewTextBoxColumn.Width = 125;
            // 
            // pruebaAcidaDataGridViewTextBoxColumn
            // 
            pruebaAcidaDataGridViewTextBoxColumn.DataPropertyName = "PruebaAcida";
            pruebaAcidaDataGridViewTextBoxColumn.HeaderText = "PruebaAcida";
            pruebaAcidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            pruebaAcidaDataGridViewTextBoxColumn.Name = "pruebaAcidaDataGridViewTextBoxColumn";
            pruebaAcidaDataGridViewTextBoxColumn.ReadOnly = true;
            pruebaAcidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // rotacionInventarioDataGridViewTextBoxColumn
            // 
            rotacionInventarioDataGridViewTextBoxColumn.DataPropertyName = "RotacionInventario";
            rotacionInventarioDataGridViewTextBoxColumn.HeaderText = "RotacionInventario";
            rotacionInventarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            rotacionInventarioDataGridViewTextBoxColumn.Name = "rotacionInventarioDataGridViewTextBoxColumn";
            rotacionInventarioDataGridViewTextBoxColumn.ReadOnly = true;
            rotacionInventarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // rotacionCuentasPorCobrarDataGridViewTextBoxColumn
            // 
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.DataPropertyName = "RotacionCuentasPorCobrar";
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.HeaderText = "RotacionCuentasPorCobrar";
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.MinimumWidth = 6;
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.Name = "rotacionCuentasPorCobrarDataGridViewTextBoxColumn";
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.ReadOnly = true;
            rotacionCuentasPorCobrarDataGridViewTextBoxColumn.Width = 125;
            // 
            // periodoPromedioCobroDataGridViewTextBoxColumn
            // 
            periodoPromedioCobroDataGridViewTextBoxColumn.DataPropertyName = "PeriodoPromedioCobro";
            periodoPromedioCobroDataGridViewTextBoxColumn.HeaderText = "PeriodoPromedioCobro";
            periodoPromedioCobroDataGridViewTextBoxColumn.MinimumWidth = 6;
            periodoPromedioCobroDataGridViewTextBoxColumn.Name = "periodoPromedioCobroDataGridViewTextBoxColumn";
            periodoPromedioCobroDataGridViewTextBoxColumn.ReadOnly = true;
            periodoPromedioCobroDataGridViewTextBoxColumn.Width = 125;
            // 
            // rotacionActivosFijosDataGridViewTextBoxColumn
            // 
            rotacionActivosFijosDataGridViewTextBoxColumn.DataPropertyName = "RotacionActivosFijos";
            rotacionActivosFijosDataGridViewTextBoxColumn.HeaderText = "RotacionActivosFijos";
            rotacionActivosFijosDataGridViewTextBoxColumn.MinimumWidth = 6;
            rotacionActivosFijosDataGridViewTextBoxColumn.Name = "rotacionActivosFijosDataGridViewTextBoxColumn";
            rotacionActivosFijosDataGridViewTextBoxColumn.ReadOnly = true;
            rotacionActivosFijosDataGridViewTextBoxColumn.Width = 125;
            // 
            // rotacionActivosTotalesDataGridViewTextBoxColumn
            // 
            rotacionActivosTotalesDataGridViewTextBoxColumn.DataPropertyName = "RotacionActivosTotales";
            rotacionActivosTotalesDataGridViewTextBoxColumn.HeaderText = "RotacionActivosTotales";
            rotacionActivosTotalesDataGridViewTextBoxColumn.MinimumWidth = 6;
            rotacionActivosTotalesDataGridViewTextBoxColumn.Name = "rotacionActivosTotalesDataGridViewTextBoxColumn";
            rotacionActivosTotalesDataGridViewTextBoxColumn.ReadOnly = true;
            rotacionActivosTotalesDataGridViewTextBoxColumn.Width = 125;
            // 
            // razonDeudaTotalDataGridViewTextBoxColumn
            // 
            razonDeudaTotalDataGridViewTextBoxColumn.DataPropertyName = "RazonDeudaTotal";
            razonDeudaTotalDataGridViewTextBoxColumn.HeaderText = "RazonDeudaTotal";
            razonDeudaTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            razonDeudaTotalDataGridViewTextBoxColumn.Name = "razonDeudaTotalDataGridViewTextBoxColumn";
            razonDeudaTotalDataGridViewTextBoxColumn.ReadOnly = true;
            razonDeudaTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // razonPasivoCapitalDataGridViewTextBoxColumn
            // 
            razonPasivoCapitalDataGridViewTextBoxColumn.DataPropertyName = "RazonPasivoCapital";
            razonPasivoCapitalDataGridViewTextBoxColumn.HeaderText = "RazonPasivoCapital";
            razonPasivoCapitalDataGridViewTextBoxColumn.MinimumWidth = 6;
            razonPasivoCapitalDataGridViewTextBoxColumn.Name = "razonPasivoCapitalDataGridViewTextBoxColumn";
            razonPasivoCapitalDataGridViewTextBoxColumn.ReadOnly = true;
            razonPasivoCapitalDataGridViewTextBoxColumn.Width = 125;
            // 
            // razonRotacionInteresUtilidadDataGridViewTextBoxColumn
            // 
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.DataPropertyName = "RazonRotacionInteresUtilidad";
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.HeaderText = "RazonRotacionInteresUtilidad";
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.Name = "razonRotacionInteresUtilidadDataGridViewTextBoxColumn";
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.ReadOnly = true;
            razonRotacionInteresUtilidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUBDataGridViewTextBoxColumn
            // 
            mUBDataGridViewTextBoxColumn.DataPropertyName = "MUB";
            mUBDataGridViewTextBoxColumn.HeaderText = "MUB";
            mUBDataGridViewTextBoxColumn.MinimumWidth = 6;
            mUBDataGridViewTextBoxColumn.Name = "mUBDataGridViewTextBoxColumn";
            mUBDataGridViewTextBoxColumn.ReadOnly = true;
            mUBDataGridViewTextBoxColumn.Width = 125;
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
            // utilidadporAccionDataGridViewTextBoxColumn
            // 
            utilidadporAccionDataGridViewTextBoxColumn.DataPropertyName = "UtilidadporAccion";
            utilidadporAccionDataGridViewTextBoxColumn.HeaderText = "UtilidadporAccion";
            utilidadporAccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            utilidadporAccionDataGridViewTextBoxColumn.Name = "utilidadporAccionDataGridViewTextBoxColumn";
            utilidadporAccionDataGridViewTextBoxColumn.ReadOnly = true;
            utilidadporAccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // razonPrecioDataGridViewTextBoxColumn
            // 
            razonPrecioDataGridViewTextBoxColumn.DataPropertyName = "RazonPrecio";
            razonPrecioDataGridViewTextBoxColumn.HeaderText = "RazonPrecio";
            razonPrecioDataGridViewTextBoxColumn.MinimumWidth = 6;
            razonPrecioDataGridViewTextBoxColumn.Name = "razonPrecioDataGridViewTextBoxColumn";
            razonPrecioDataGridViewTextBoxColumn.ReadOnly = true;
            razonPrecioDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorenLibrosDataGridViewTextBoxColumn
            // 
            valorenLibrosDataGridViewTextBoxColumn.DataPropertyName = "ValorenLibros";
            valorenLibrosDataGridViewTextBoxColumn.HeaderText = "ValorenLibros";
            valorenLibrosDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorenLibrosDataGridViewTextBoxColumn.Name = "valorenLibrosDataGridViewTextBoxColumn";
            valorenLibrosDataGridViewTextBoxColumn.ReadOnly = true;
            valorenLibrosDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorenLibrosporAccionDataGridViewTextBoxColumn
            // 
            valorenLibrosporAccionDataGridViewTextBoxColumn.DataPropertyName = "ValorenLibrosporAccion";
            valorenLibrosporAccionDataGridViewTextBoxColumn.HeaderText = "ValorenLibrosporAccion";
            valorenLibrosporAccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorenLibrosporAccionDataGridViewTextBoxColumn.Name = "valorenLibrosporAccionDataGridViewTextBoxColumn";
            valorenLibrosporAccionDataGridViewTextBoxColumn.ReadOnly = true;
            valorenLibrosporAccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // razonesFinancieraBindingSource
            // 
            razonesFinancieraBindingSource.DataSource = typeof(Models.RazonesFinanciera);
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(groupBox5);
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
            panel1.Size = new Size(1572, 681);
            panel1.TabIndex = 75;
            panel1.Paint += panel1_Paint;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1136, 346);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 52);
            btnEliminar.TabIndex = 79;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SeaGreen;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(753, 346);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 52);
            btnActualizar.TabIndex = 78;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(392, 346);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 52);
            btnAgregar.TabIndex = 77;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(txtValorenLibrosA);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(txtUtilidadporAccion);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(txtRazonPrecio);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(txtValorenLibros);
            groupBox5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(1332, 68);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(240, 290);
            groupBox5.TabIndex = 70;
            groupBox5.TabStop = false;
            groupBox5.Text = "Razones de Mercado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(5, 221);
            label9.Name = "label9";
            label9.Size = new Size(234, 28);
            label9.TabIndex = 64;
            label9.Text = "Valor en libros por accion";
            // 
            // txtValorenLibrosA
            // 
            txtValorenLibrosA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorenLibrosA.Location = new Point(36, 252);
            txtValorenLibrosA.Name = "txtValorenLibrosA";
            txtValorenLibrosA.Size = new Size(155, 27);
            txtValorenLibrosA.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 34);
            label6.Name = "label6";
            label6.Size = new Size(182, 28);
            label6.TabIndex = 43;
            label6.Text = "Utilidad por Accion";
            // 
            // txtUtilidadporAccion
            // 
            txtUtilidadporAccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUtilidadporAccion.Location = new Point(39, 65);
            txtUtilidadporAccion.Name = "txtUtilidadporAccion";
            txtUtilidadporAccion.Size = new Size(155, 27);
            txtUtilidadporAccion.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 95);
            label7.Name = "label7";
            label7.Size = new Size(201, 28);
            label7.TabIndex = 62;
            label7.Text = "Razón Precio Unitario";
            // 
            // txtRazonPrecio
            // 
            txtRazonPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRazonPrecio.Location = new Point(39, 126);
            txtRazonPrecio.Name = "txtRazonPrecio";
            txtRazonPrecio.Size = new Size(155, 27);
            txtRazonPrecio.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(39, 156);
            label8.Name = "label8";
            label8.Size = new Size(141, 28);
            label8.TabIndex = 53;
            label8.Text = "Valor en Libros";
            // 
            // txtValorenLibros
            // 
            txtValorenLibros.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorenLibros.Location = new Point(39, 187);
            txtValorenLibros.Name = "txtValorenLibros";
            txtValorenLibros.Size = new Size(155, 27);
            txtValorenLibros.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(490, 7);
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
            label4.Location = new Point(237, 7);
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
            label3.Location = new Point(64, 7);
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
            ClientSize = new Size(2120, 1096);
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
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox5;
        private Label label6;
        private TextBox txtUtilidadporAccion;
        private Label label7;
        private TextBox txtRazonPrecio;
        private Label label8;
        private TextBox txtValorenLibros;
        private Label label9;
        private TextBox txtValorenLibrosA;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn iDRazonFinancieraDataGridViewTextBoxColumn;
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
        private DataGridViewTextBoxColumn utilidadporAccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razonPrecioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorenLibrosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorenLibrosporAccionDataGridViewTextBoxColumn;
        private BindingSource razonesFinancieraBindingSource;
    }
}