﻿namespace WindowsForm
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
            txtTotal = new TextBox();
            txtMonto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRefresh = new Button();
            CbID_Balance = new ComboBox();
            label4 = new Label();
            btnActualizar = new Button();
            txtCuenta = new TextBox();
            cbClasificacioID = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPasivosCapital).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasivoCapitalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAgregar.Location = new Point(618, 145);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 44);
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
            dgvPasivosCapital.Location = new Point(682, 212);
            dgvPasivosCapital.Name = "dgvPasivosCapital";
            dgvPasivosCapital.ReadOnly = true;
            dgvPasivosCapital.RowHeadersWidth = 51;
            dgvPasivosCapital.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasivosCapital.Size = new Size(662, 316);
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
            btnEliminar.Location = new Point(834, 148);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1313, 100);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 4;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(1163, 100);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1184, 66);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 6;
            label1.Text = "Monto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1025, 65);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 7;
            label2.Text = "Cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1352, 66);
            label3.Name = "label3";
            label3.Size = new Size(63, 31);
            label3.TabIndex = 8;
            label3.Text = "Total";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SeaGreen;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnRefresh.Location = new Point(1305, 148);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 39);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refrescar";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CbID_Balance
            // 
            CbID_Balance.FormattingEnabled = true;
            CbID_Balance.Location = new Point(611, 99);
            CbID_Balance.Name = "CbID_Balance";
            CbID_Balance.Size = new Size(151, 28);
            CbID_Balance.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(626, 66);
            label4.Name = "label4";
            label4.Size = new Size(121, 31);
            label4.TabIndex = 11;
            label4.Text = "Balance ID";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SeaGreen;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnActualizar.Location = new Point(1074, 148);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(137, 39);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(1005, 99);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(125, 27);
            txtCuenta.TabIndex = 13;
            // 
            // cbClasificacioID
            // 
            cbClasificacioID.FormattingEnabled = true;
            cbClasificacioID.Location = new Point(792, 100);
            cbClasificacioID.Name = "cbClasificacioID";
            cbClasificacioID.Size = new Size(193, 28);
            cbClasificacioID.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(816, 65);
            label5.Name = "label5";
            label5.Size = new Size(169, 31);
            label5.TabIndex = 15;
            label5.Text = "Clasificacion ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(876, 9);
            label6.Name = "label6";
            label6.Size = new Size(326, 38);
            label6.TabIndex = 16;
            label6.Text = "Pasivo y Capital Contable";
            // 
            // PasivoCapitalBalanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1485, 827);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbClasificacioID);
            Controls.Add(txtCuenta);
            Controls.Add(btnActualizar);
            Controls.Add(label4);
            Controls.Add(CbID_Balance);
            Controls.Add(btnRefresh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(txtTotal);
            Controls.Add(btnEliminar);
            Controls.Add(dgvPasivosCapital);
            Controls.Add(btnAgregar);
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
        private TextBox txtTotal;
        private TextBox txtMonto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRefresh;
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
    }
}