namespace WindowsForm
{
    partial class BalanceGeneralForm
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
            btnActivos.Location = new Point(364, 85);
            btnActivos.Name = "btnActivos";
            btnActivos.Size = new Size(239, 40);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1473, 233);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnClasificaciones
            // 
            btnClasificaciones.BackColor = Color.SeaGreen;
            btnClasificaciones.FlatStyle = FlatStyle.Popup;
            btnClasificaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClasificaciones.Location = new Point(364, 146);
            btnClasificaciones.Name = "btnClasificaciones";
            btnClasificaciones.Size = new Size(239, 40);
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
            btnBalances.Location = new Point(656, 146);
            btnBalances.Name = "btnBalances";
            btnBalances.Size = new Size(251, 40);
            btnBalances.TabIndex = 9;
            btnBalances.Text = "Numero De Balances";
            btnBalances.UseVisualStyleBackColor = false;
            btnBalances.Click += btnBalances_Click;
            // 
            // btnPasivoYCapital
            // 
            btnPasivoYCapital.BackColor = Color.SeaGreen;
            btnPasivoYCapital.FlatStyle = FlatStyle.Popup;
            btnPasivoYCapital.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPasivoYCapital.Location = new Point(656, 82);
            btnPasivoYCapital.Name = "btnPasivoYCapital";
            btnPasivoYCapital.Size = new Size(239, 46);
            btnPasivoYCapital.TabIndex = 8;
            btnPasivoYCapital.Text = "Pasivo y Capital";
            btnPasivoYCapital.UseVisualStyleBackColor = false;
            btnPasivoYCapital.Click += btnMostrarBalance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(552, 51);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 2;
            label1.Text = "Balance General";
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 233);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1473, 551);
            panelContenedor.TabIndex = 3;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // BalanceGeneralForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1473, 784);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Name = "BalanceGeneralForm";
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