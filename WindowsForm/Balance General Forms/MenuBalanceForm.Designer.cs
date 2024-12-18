﻿namespace WindowsForm
{
    partial class MenuBalanceForm
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
            btnActivos = new Button();
            panel1 = new Panel();
            btnClasificaciones = new Button();
            btnBalances = new Button();
            btnPasivoYCapital = new Button();
            label1 = new Label();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnActivos
            // 
            btnActivos.BackColor = Color.SeaGreen;
            btnActivos.FlatStyle = FlatStyle.Popup;
            btnActivos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivos.Location = new Point(580, 84);
            btnActivos.Margin = new Padding(3, 2, 3, 2);
            btnActivos.Name = "btnActivos";
            btnActivos.Size = new Size(209, 30);
            btnActivos.TabIndex = 0;
            btnActivos.Text = "Activo";
            btnActivos.UseVisualStyleBackColor = false;
            btnActivos.Click += btnActivosCirculantes_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClasificaciones);
            panel1.Controls.Add(btnBalances);
            panel1.Controls.Add(btnPasivoYCapital);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnActivos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 175);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnClasificaciones
            // 
            btnClasificaciones.BackColor = Color.SeaGreen;
            btnClasificaciones.FlatStyle = FlatStyle.Popup;
            btnClasificaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClasificaciones.Location = new Point(580, 130);
            btnClasificaciones.Margin = new Padding(3, 2, 3, 2);
            btnClasificaciones.Name = "btnClasificaciones";
            btnClasificaciones.Size = new Size(209, 30);
            btnClasificaciones.TabIndex = 10;
            btnClasificaciones.Text = "Clasificaciones";
            btnClasificaciones.UseVisualStyleBackColor = false;
            btnClasificaciones.Click += btnClasificaciones_Click;
            // 
            // btnBalances
            // 
            btnBalances.BackColor = Color.SeaGreen;
            btnBalances.FlatStyle = FlatStyle.Popup;
            btnBalances.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBalances.Location = new Point(848, 130);
            btnBalances.Margin = new Padding(3, 2, 3, 2);
            btnBalances.Name = "btnBalances";
            btnBalances.Size = new Size(220, 30);
            btnBalances.TabIndex = 9;
            btnBalances.Text = "Crear un Balance";
            btnBalances.UseVisualStyleBackColor = false;
            btnBalances.Click += btnBalances_Click;
            // 
            // btnPasivoYCapital
            // 
            btnPasivoYCapital.BackColor = Color.SeaGreen;
            btnPasivoYCapital.FlatStyle = FlatStyle.Popup;
            btnPasivoYCapital.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPasivoYCapital.Location = new Point(848, 84);
            btnPasivoYCapital.Margin = new Padding(3, 2, 3, 2);
            btnPasivoYCapital.Name = "btnPasivoYCapital";
            btnPasivoYCapital.Size = new Size(209, 34);
            btnPasivoYCapital.TabIndex = 8;
            btnPasivoYCapital.Text = "Pasivo y Capital";
            btnPasivoYCapital.UseVisualStyleBackColor = false;
            btnPasivoYCapital.Click += btnMostrarBalance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(630, 42);
            label1.Name = "label1";
            label1.Size = new Size(377, 40);
            label1.TabIndex = 2;
            label1.Text = "Menu del Balance General";
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 175);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1199, 387);
            panelContenedor.TabIndex = 3;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // MenuBalanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1199, 562);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuBalanceForm";
            Text = "BalanceGeneralForm";
            Load += BalanceGeneralForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnActivos;
        private Panel panel1;
        public Panel panelContenedor;
        public Label label1;
        private Button btnBalances;
        private Button btnClasificaciones;
        private Button btnPasivoYCapital;
    }
}