namespace WindowsForm
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            btnRegistro = new Button();
            panelTitulo = new Panel();
            panel2 = new Panel();
            btnER = new Button();
            btnRazonesFinancieras = new Button();
            panelContenedor = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(26, 32, 40);
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.Image = (Image)resources.GetObject("btnRegistro.Image");
            btnRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistro.Location = new Point(10, 28);
            btnRegistro.Margin = new Padding(3, 2, 3, 2);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(258, 46);
            btnRegistro.TabIndex = 0;
            btnRegistro.Text = "Balance General";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 80, 200);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Margin = new Padding(3, 2, 3, 2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1199, 32);
            panelTitulo.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(btnER);
            panel2.Controls.Add(btnRazonesFinancieras);
            panel2.Controls.Add(btnRegistro);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 32);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 530);
            panel2.TabIndex = 6;
            // 
            // btnER
            // 
            btnER.BackColor = Color.FromArgb(26, 32, 40);
            btnER.FlatAppearance.BorderSize = 0;
            btnER.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnER.FlatStyle = FlatStyle.Flat;
            btnER.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnER.ForeColor = Color.White;
            btnER.Image = (Image)resources.GetObject("btnER.Image");
            btnER.ImageAlign = ContentAlignment.MiddleLeft;
            btnER.Location = new Point(10, 86);
            btnER.Margin = new Padding(3, 2, 3, 2);
            btnER.Name = "btnER";
            btnER.Size = new Size(203, 71);
            btnER.TabIndex = 7;
            btnER.Text = "Estado de Resultado";
            btnER.UseVisualStyleBackColor = false;
            btnER.Click += btnER_Click;
            // 
            // btnRazonesFinancieras
            // 
            btnRazonesFinancieras.BackColor = Color.FromArgb(26, 32, 40);
            btnRazonesFinancieras.FlatAppearance.BorderSize = 0;
            btnRazonesFinancieras.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnRazonesFinancieras.FlatStyle = FlatStyle.Flat;
            btnRazonesFinancieras.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRazonesFinancieras.ForeColor = Color.White;
            btnRazonesFinancieras.Image = (Image)resources.GetObject("btnRazonesFinancieras.Image");
            btnRazonesFinancieras.ImageAlign = ContentAlignment.MiddleLeft;
            btnRazonesFinancieras.Location = new Point(10, 146);
            btnRazonesFinancieras.Margin = new Padding(3, 2, 3, 2);
            btnRazonesFinancieras.Name = "btnRazonesFinancieras";
            btnRazonesFinancieras.Size = new Size(203, 97);
            btnRazonesFinancieras.TabIndex = 6;
            btnRazonesFinancieras.Text = "Razones Financieras";
            btnRazonesFinancieras.UseVisualStyleBackColor = false;
            btnRazonesFinancieras.Click += btnRazonesFinancieras_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1199, 562);
            panelContenedor.TabIndex = 0;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1199, 562);
            Controls.Add(panel2);
            Controls.Add(panelTitulo);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistro;
        private Panel panelTitulo;
        private Panel panel2;
        private Button btnER;
        private Button btnRazonesFinancieras;
        private Panel panelContenedor;
        private Button btnNombreBG;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
    }
}
