namespace WindowsForm
{
    partial class MenuRazonesFinancieras
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
            panel1 = new Panel();
            label1 = new Label();
            btnRazones = new Button();
            btnCuentas = new Button();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRazones);
            panel1.Controls.Add(btnCuentas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1545, 185);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(720, 56);
            label1.Name = "label1";
            label1.Size = new Size(588, 50);
            label1.TabIndex = 0;
            label1.Text = "Menu de las Razones Financieras";
            // 
            // btnRazones
            // 
            btnRazones.BackColor = Color.SeaGreen;
            btnRazones.FlatStyle = FlatStyle.Popup;
            btnRazones.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRazones.ForeColor = SystemColors.ControlText;
            btnRazones.Location = new Point(1058, 127);
            btnRazones.Name = "btnRazones";
            btnRazones.Size = new Size(175, 40);
            btnRazones.TabIndex = 1;
            btnRazones.Text = "Razones";
            btnRazones.UseVisualStyleBackColor = false;
            btnRazones.Click += btnRazones_Click;
            // 
            // btnCuentas
            // 
            btnCuentas.BackColor = Color.SeaGreen;
            btnCuentas.FlatStyle = FlatStyle.Popup;
            btnCuentas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCuentas.ForeColor = SystemColors.ControlText;
            btnCuentas.Location = new Point(801, 127);
            btnCuentas.Name = "btnCuentas";
            btnCuentas.Size = new Size(175, 40);
            btnCuentas.TabIndex = 0;
            btnCuentas.Text = "Cuentas";
            btnCuentas.UseVisualStyleBackColor = false;
            btnCuentas.Click += btnCuentas_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 185);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1545, 540);
            panelContenedor.TabIndex = 1;
            // 
            // MenuRazonesFinancieras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1545, 725);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "MenuRazonesFinancieras";
            Text = "MenuRazonesFinancieras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRazones;
        private Button btnCuentas;
        private Panel panelContenedor;
        private Label label1;
    }
}