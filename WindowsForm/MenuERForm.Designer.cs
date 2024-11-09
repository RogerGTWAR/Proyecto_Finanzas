namespace WindowsForm
{
    partial class MenuERForm
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
            btnIngresos = new Button();
            btnClasificacion = new Button();
            btnER = new Button();
            panelContenedor = new Panel();
            btnEgresos = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEgresos);
            panel1.Controls.Add(btnIngresos);
            panel1.Controls.Add(btnClasificacion);
            panel1.Controls.Add(btnER);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 212);
            panel1.TabIndex = 0;
            // 
            // btnIngresos
            // 
            btnIngresos.BackColor = Color.SeaGreen;
            btnIngresos.FlatStyle = FlatStyle.Popup;
            btnIngresos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresos.ForeColor = SystemColors.ControlText;
            btnIngresos.Location = new Point(412, 67);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(191, 42);
            btnIngresos.TabIndex = 4;
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseVisualStyleBackColor = false;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // btnClasificacion
            // 
            btnClasificacion.BackColor = Color.SeaGreen;
            btnClasificacion.FlatStyle = FlatStyle.Popup;
            btnClasificacion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClasificacion.ForeColor = SystemColors.ControlText;
            btnClasificacion.Location = new Point(412, 141);
            btnClasificacion.Name = "btnClasificacion";
            btnClasificacion.Size = new Size(191, 42);
            btnClasificacion.TabIndex = 2;
            btnClasificacion.Text = "Clasificaciones";
            btnClasificacion.UseVisualStyleBackColor = false;
            btnClasificacion.Click += btnClasificacion_Click;
            // 
            // btnER
            // 
            btnER.BackColor = Color.SeaGreen;
            btnER.FlatStyle = FlatStyle.Popup;
            btnER.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnER.ForeColor = SystemColors.ControlText;
            btnER.Location = new Point(673, 142);
            btnER.Name = "btnER";
            btnER.Size = new Size(139, 41);
            btnER.TabIndex = 0;
            btnER.Text = "Crear ER";
            btnER.UseVisualStyleBackColor = false;
            btnER.Click += btnER_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 212);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1370, 571);
            panelContenedor.TabIndex = 1;
            // 
            // btnEgresos
            // 
            btnEgresos.BackColor = Color.SeaGreen;
            btnEgresos.FlatStyle = FlatStyle.Popup;
            btnEgresos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEgresos.ForeColor = SystemColors.ControlText;
            btnEgresos.Location = new Point(673, 67);
            btnEgresos.Name = "btnEgresos";
            btnEgresos.Size = new Size(139, 42);
            btnEgresos.TabIndex = 5;
            btnEgresos.Text = "Egresos";
            btnEgresos.UseVisualStyleBackColor = false;
            btnEgresos.Click += btnEgresos_Click;
            // 
            // MenuERForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1370, 783);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Name = "MenuERForm";
            Text = "MenuERForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClasificacion;
        private Button btnER;
        private Panel panelContenedor;
        private Button btnIngresos;
        private Button btnEgresos;
    }
}