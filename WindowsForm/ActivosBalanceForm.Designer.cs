﻿namespace WindowsForm
{
    partial class ActivosBalanceForm
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
            btnAgregar = new Button();
            dgvActivos = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAgregar.Location = new Point(338, 184);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 44);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvActivos
            // 
            dgvActivos.BackgroundColor = Color.White;
            dgvActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivos.Location = new Point(338, 239);
            dgvActivos.Name = "dgvActivos";
            dgvActivos.ReadOnly = true;
            dgvActivos.RowHeadersWidth = 51;
            dgvActivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivos.Size = new Size(816, 326);
            dgvActivos.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEliminar.Location = new Point(554, 187);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1029, 76);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 4;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(878, 76);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(898, 41);
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
            label2.Location = new Point(734, 41);
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
            label3.Location = new Point(1065, 41);
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
            btnRefresh.Location = new Point(1025, 187);
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
            CbID_Balance.Location = new Point(327, 75);
            CbID_Balance.Name = "CbID_Balance";
            CbID_Balance.Size = new Size(151, 28);
            CbID_Balance.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(294, 41);
            label4.Name = "label4";
            label4.Size = new Size(216, 31);
            label4.TabIndex = 11;
            label4.Text = "Numero De Balance";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SeaGreen;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnActualizar.Location = new Point(794, 187);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(129, 39);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(719, 76);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(125, 27);
            txtCuenta.TabIndex = 13;
            // 
            // cbClasificacioID
            // 
            cbClasificacioID.FormattingEnabled = true;
            cbClasificacioID.Location = new Point(532, 75);
            cbClasificacioID.Name = "cbClasificacioID";
            cbClasificacioID.Size = new Size(151, 28);
            cbClasificacioID.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(532, 41);
            label5.Name = "label5";
            label5.Size = new Size(169, 31);
            label5.TabIndex = 15;
            label5.Text = "Clasificacion ID";
            // 
            // ActivosBalanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1343, 827);
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
            Controls.Add(dgvActivos);
            Controls.Add(btnAgregar);
            Name = "ActivosBalanceForm";
            Text = "CuentasBalanceForm";
            Load += ActivosCirculantesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private DataGridView dgvActivos;
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
    }
}