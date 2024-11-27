namespace WindowsForm
{
    partial class PasivoCapitalBalanceForm
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
            btnAgregar = new Button();
            dgvPasivosCapital = new DataGridView();
            iDPasivoCapitalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDatosBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDClasificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCuentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pasivoCapitalBindingSource = new BindingSource(components);
            btnEliminar = new Button();
            txtMonto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CbID_Balance = new ComboBox();
            label4 = new Label();
            btnActualizar = new Button();
            txtCuenta = new TextBox();
            cbClasificacioID = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtTotal = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPasivosCapital).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasivoCapitalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAgregar.Location = new Point(498, 113);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 33);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvPasivosCapital
            // 
            dgvPasivosCapital.AutoGenerateColumns = false;
            dgvPasivosCapital.BackgroundColor = Color.White;
            dgvPasivosCapital.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasivosCapital.Columns.AddRange(new DataGridViewColumn[] { iDPasivoCapitalDataGridViewTextBoxColumn, iDDatosBalanceDataGridViewTextBoxColumn, iDClasificacionDataGridViewTextBoxColumn, nombreCuentaDataGridViewTextBoxColumn, montoDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn });
            dgvPasivosCapital.DataSource = pasivoCapitalBindingSource;
            dgvPasivosCapital.Location = new Point(382, 148);
            dgvPasivosCapital.Margin = new Padding(3, 2, 3, 2);
            dgvPasivosCapital.Name = "dgvPasivosCapital";
            dgvPasivosCapital.ReadOnly = true;
            dgvPasivosCapital.RowHeadersWidth = 51;
            dgvPasivosCapital.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasivosCapital.Size = new Size(688, 237);
            dgvPasivosCapital.TabIndex = 2;
            // 
            // iDPasivoCapitalDataGridViewTextBoxColumn
            // 
            iDPasivoCapitalDataGridViewTextBoxColumn.DataPropertyName = "ID_Pasivo_Capital";
            iDPasivoCapitalDataGridViewTextBoxColumn.HeaderText = "ID";
            iDPasivoCapitalDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDPasivoCapitalDataGridViewTextBoxColumn.Name = "iDPasivoCapitalDataGridViewTextBoxColumn";
            iDPasivoCapitalDataGridViewTextBoxColumn.ReadOnly = true;
            iDPasivoCapitalDataGridViewTextBoxColumn.Width = 70;
            // 
            // iDDatosBalanceDataGridViewTextBoxColumn
            // 
            iDDatosBalanceDataGridViewTextBoxColumn.DataPropertyName = "ID_DatosBalance";
            iDDatosBalanceDataGridViewTextBoxColumn.HeaderText = "ID del Balance";
            iDDatosBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDatosBalanceDataGridViewTextBoxColumn.Name = "iDDatosBalanceDataGridViewTextBoxColumn";
            iDDatosBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            iDDatosBalanceDataGridViewTextBoxColumn.Width = 70;
            // 
            // iDClasificacionDataGridViewTextBoxColumn
            // 
            iDClasificacionDataGridViewTextBoxColumn.DataPropertyName = "ID_Clasificacion";
            iDClasificacionDataGridViewTextBoxColumn.HeaderText = "Clasificacion";
            iDClasificacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDClasificacionDataGridViewTextBoxColumn.Name = "iDClasificacionDataGridViewTextBoxColumn";
            iDClasificacionDataGridViewTextBoxColumn.ReadOnly = true;
            iDClasificacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreCuentaDataGridViewTextBoxColumn
            // 
            nombreCuentaDataGridViewTextBoxColumn.DataPropertyName = "NombreCuenta";
            nombreCuentaDataGridViewTextBoxColumn.HeaderText = "Nombre de la Cuenta";
            nombreCuentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreCuentaDataGridViewTextBoxColumn.Name = "nombreCuentaDataGridViewTextBoxColumn";
            nombreCuentaDataGridViewTextBoxColumn.ReadOnly = true;
            nombreCuentaDataGridViewTextBoxColumn.Width = 120;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            montoDataGridViewTextBoxColumn.ReadOnly = true;
            montoDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // pasivoCapitalBindingSource
            // 
            pasivoCapitalBindingSource.DataSource = typeof(Models.Pasivo_Capital);
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEliminar.Location = new Point(687, 115);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(845, 77);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(110, 23);
            txtMonto.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(863, 52);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 6;
            label1.Text = "Monto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(724, 51);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 7;
            label2.Text = "Cuenta";
            // 
            // CbID_Balance
            // 
            CbID_Balance.FormattingEnabled = true;
            CbID_Balance.Location = new Point(362, 76);
            CbID_Balance.Margin = new Padding(3, 2, 3, 2);
            CbID_Balance.Name = "CbID_Balance";
            CbID_Balance.Size = new Size(133, 23);
            CbID_Balance.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(375, 52);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 11;
            label4.Text = "Balance ID";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SeaGreen;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnActualizar.Location = new Point(897, 115);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 29);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(706, 76);
            txtCuenta.Margin = new Padding(3, 2, 3, 2);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(110, 23);
            txtCuenta.TabIndex = 13;
            // 
            // cbClasificacioID
            // 
            cbClasificacioID.FormattingEnabled = true;
            cbClasificacioID.Location = new Point(520, 77);
            cbClasificacioID.Margin = new Padding(3, 2, 3, 2);
            cbClasificacioID.Name = "cbClasificacioID";
            cbClasificacioID.Size = new Size(169, 23);
            cbClasificacioID.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(541, 51);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 15;
            label5.Text = "Clasificacion ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(601, 9);
            label6.Name = "label6";
            label6.Size = new Size(255, 30);
            label6.TabIndex = 16;
            label6.Text = "Pasivo y Capital Contable";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(995, 77);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1018, 52);
            label7.Name = "label7";
            label7.Size = new Size(52, 25);
            label7.TabIndex = 18;
            label7.Text = "Total";
            // 
            // PasivoCapitalBalanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1199, 562);
            Controls.Add(label7);
            Controls.Add(txtTotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbClasificacioID);
            Controls.Add(txtCuenta);
            Controls.Add(btnActualizar);
            Controls.Add(label4);
            Controls.Add(CbID_Balance);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(btnEliminar);
            Controls.Add(dgvPasivosCapital);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PasivoCapitalBalanceForm";
            Text = "Pasivo y Capital";
            Load += ActivosCirculantesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPasivosCapital).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasivoCapitalBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private DataGridView dgvPasivosCapital;
        private Button btnEliminar;
        private TextBox txtMonto;
        private Label label1;
        private Label label2;
        private ComboBox CbID_Balance;
        private Label label4;
        private Button btnActualizar;
        private TextBox txtCuenta;
        private ComboBox cbClasificacioID;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn iDPasivoCapitalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDatosBalanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDClasificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCuentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private BindingSource pasivoCapitalBindingSource;
        private TextBox txtTotal;
        private Label label7;
    }
}