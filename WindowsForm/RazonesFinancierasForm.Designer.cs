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
            dgvRazones = new DataGridView();
            cbID_DatosER = new ComboBox();
            cbID_CuentasDeRazones = new ComboBox();
            cbID_DatosBalance = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRazones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(634, 9);
            label1.Name = "label1";
            label1.Size = new Size(298, 41);
            label1.TabIndex = 1;
            label1.Text = "Razones Financieras";
            // 
            // txtMargenUtilidadNeta
            // 
            txtMargenUtilidadNeta.Location = new Point(62, 222);
            txtMargenUtilidadNeta.Name = "txtMargenUtilidadNeta";
            txtMargenUtilidadNeta.Size = new Size(155, 38);
            txtMargenUtilidadNeta.TabIndex = 30;
            // 
            // txtRazonEndeudamiento
            // 
            txtRazonEndeudamiento.Location = new Point(82, 87);
            txtRazonEndeudamiento.Name = "txtRazonEndeudamiento";
            txtRazonEndeudamiento.Size = new Size(155, 38);
            txtRazonEndeudamiento.TabIndex = 32;
            // 
            // txtPruebaAcida
            // 
            txtPruebaAcida.Location = new Point(17, 281);
            txtPruebaAcida.Name = "txtPruebaAcida";
            txtPruebaAcida.Size = new Size(155, 38);
            txtPruebaAcida.TabIndex = 33;
            // 
            // txtRazonCorriente
            // 
            txtRazonCorriente.Location = new Point(17, 184);
            txtRazonCorriente.Name = "txtRazonCorriente";
            txtRazonCorriente.Size = new Size(155, 38);
            txtRazonCorriente.TabIndex = 34;
            // 
            // txtRotacionInventario
            // 
            txtRotacionInventario.Location = new Point(54, 87);
            txtRotacionInventario.Name = "txtRotacionInventario";
            txtRotacionInventario.Size = new Size(155, 38);
            txtRotacionInventario.TabIndex = 36;
            // 
            // txtPeriodoPromedioCobro
            // 
            txtPeriodoPromedioCobro.Location = new Point(312, 89);
            txtPeriodoPromedioCobro.Name = "txtPeriodoPromedioCobro";
            txtPeriodoPromedioCobro.Size = new Size(155, 38);
            txtPeriodoPromedioCobro.TabIndex = 38;
            // 
            // txtRotacionCuentasPorCobrar
            // 
            txtRotacionCuentasPorCobrar.Location = new Point(47, 181);
            txtRotacionCuentasPorCobrar.Name = "txtRotacionCuentasPorCobrar";
            txtRotacionCuentasPorCobrar.Size = new Size(155, 38);
            txtRotacionCuentasPorCobrar.TabIndex = 39;
            // 
            // txtCapitalTrabajo
            // 
            txtCapitalTrabajo.Location = new Point(17, 88);
            txtCapitalTrabajo.Name = "txtCapitalTrabajo";
            txtCapitalTrabajo.Size = new Size(155, 38);
            txtCapitalTrabajo.TabIndex = 40;
            // 
            // txtMargenBruto
            // 
            txtMargenBruto.Location = new Point(66, 67);
            txtMargenBruto.Name = "txtMargenBruto";
            txtMargenBruto.Size = new Size(155, 38);
            txtMargenBruto.TabIndex = 41;
            // 
            // btnRazonesFinancieras
            // 
            btnRazonesFinancieras.BackColor = Color.White;
            btnRazonesFinancieras.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRazonesFinancieras.Location = new Point(377, 529);
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
            label17.Location = new Point(21, 36);
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
            label18.Location = new Point(17, 57);
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
            label20.Location = new Point(23, 56);
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
            label21.Location = new Point(17, 153);
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
            label22.Location = new Point(17, 253);
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
            label24.Location = new Point(23, 150);
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
            label25.Location = new Point(277, 58);
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
            label26.Location = new Point(62, 56);
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
            label27.Location = new Point(35, 191);
            label27.Name = "label27";
            label27.Size = new Size(229, 28);
            label27.TabIndex = 53;
            label27.Text = "Margen de Utilidad Neta";
            // 
            // txtRotacionActivosFijos
            // 
            txtRotacionActivosFijos.Location = new Point(314, 183);
            txtRotacionActivosFijos.Name = "txtRotacionActivosFijos";
            txtRotacionActivosFijos.Size = new Size(155, 38);
            txtRotacionActivosFijos.TabIndex = 58;
            // 
            // txtRotacionActivosTotales
            // 
            txtRotacionActivosTotales.Location = new Point(161, 270);
            txtRotacionActivosTotales.Name = "txtRotacionActivosTotales";
            txtRotacionActivosTotales.Size = new Size(155, 38);
            txtRotacionActivosTotales.TabIndex = 59;
            // 
            // txtMargenUtilidadOperativa
            // 
            txtMargenUtilidadOperativa.Location = new Point(66, 144);
            txtMargenUtilidadOperativa.Name = "txtMargenUtilidadOperativa";
            txtMargenUtilidadOperativa.Size = new Size(155, 38);
            txtMargenUtilidadOperativa.TabIndex = 60;
            // 
            // txtRazonPasivoCapital
            // 
            txtRazonPasivoCapital.Location = new Point(78, 183);
            txtRazonPasivoCapital.Name = "txtRazonPasivoCapital";
            txtRazonPasivoCapital.Size = new Size(155, 38);
            txtRazonPasivoCapital.TabIndex = 61;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.White;
            label31.Location = new Point(11, 113);
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
            label32.Location = new Point(140, 239);
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
            label33.Location = new Point(298, 152);
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
            label34.Location = new Point(62, 152);
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
            groupBox1.Location = new Point(309, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 329);
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
            groupBox2.Location = new Point(543, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 330);
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
            groupBox3.Location = new Point(1124, 63);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 330);
            groupBox3.TabIndex = 68;
            groupBox3.TabStop = false;
            groupBox3.Text = "Razones de Endeudamiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 239);
            label2.Name = "label2";
            label2.Size = new Size(284, 28);
            label2.TabIndex = 70;
            label2.Text = "Rotacion de interes a utilidades";
            // 
            // txtRotaciondeiau
            // 
            txtRotaciondeiau.Location = new Point(82, 270);
            txtRotaciondeiau.Name = "txtRotaciondeiau";
            txtRotaciondeiau.Size = new Size(155, 38);
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
            groupBox4.Location = new Point(644, 399);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(316, 269);
            groupBox4.TabIndex = 69;
            groupBox4.TabStop = false;
            groupBox4.Text = "Razones de Rentabilidad";
            // 
            // dgvRazones
            // 
            dgvRazones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazones.Location = new Point(559, 705);
            dgvRazones.Name = "dgvRazones";
            dgvRazones.ReadOnly = true;
            dgvRazones.RowHeadersWidth = 51;
            dgvRazones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRazones.Size = new Size(300, 188);
            dgvRazones.TabIndex = 70;
            // 
            // cbID_DatosER
            // 
            cbID_DatosER.FormattingEnabled = true;
            cbID_DatosER.Location = new Point(1027, 399);
            cbID_DatosER.Name = "cbID_DatosER";
            cbID_DatosER.Size = new Size(151, 28);
            cbID_DatosER.TabIndex = 71;
            // 
            // cbID_CuentasDeRazones
            // 
            cbID_CuentasDeRazones.FormattingEnabled = true;
            cbID_CuentasDeRazones.Location = new Point(1027, 604);
            cbID_CuentasDeRazones.Name = "cbID_CuentasDeRazones";
            cbID_CuentasDeRazones.Size = new Size(151, 28);
            cbID_CuentasDeRazones.TabIndex = 72;
            // 
            // cbID_DatosBalance
            // 
            cbID_DatosBalance.FormattingEnabled = true;
            cbID_DatosBalance.Location = new Point(1027, 518);
            cbID_DatosBalance.Name = "cbID_DatosBalance";
            cbID_DatosBalance.Size = new Size(151, 28);
            cbID_DatosBalance.TabIndex = 73;
            // 
            // RazonesFinancierasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1503, 1096);
            Controls.Add(cbID_DatosBalance);
            Controls.Add(cbID_CuentasDeRazones);
            Controls.Add(cbID_DatosER);
            Controls.Add(dgvRazones);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnRazonesFinancieras);
            Controls.Add(label1);
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
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView dgvRazones;
        private ComboBox cbID_DatosER;
        private ComboBox cbID_CuentasDeRazones;
        private ComboBox cbID_DatosBalance;
    }
}