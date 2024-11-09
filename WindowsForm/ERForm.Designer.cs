namespace WindowsForm
{
    partial class ERForm
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
            dgvIngresos = new DataGridView();
            button1 = new Button();
            txtVentasTotales = new TextBox();
            txtDescuentosV = new TextBox();
            txtDevolucionessV = new TextBox();
            txtCostoVentas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtVentasNetas = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            SuspendLayout();
            // 
            // dgvIngresos
            // 
            dgvIngresos.BackgroundColor = Color.White;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.Location = new Point(322, 413);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.RowHeadersWidth = 51;
            dgvIngresos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngresos.Size = new Size(858, 216);
            dgvIngresos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(939, 328);
            button1.Name = "button1";
            button1.Size = new Size(106, 33);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtVentasTotales
            // 
            txtVentasTotales.Location = new Point(322, 98);
            txtVentasTotales.Name = "txtVentasTotales";
            txtVentasTotales.Size = new Size(159, 30);
            txtVentasTotales.TabIndex = 2;
            // 
            // txtDescuentosV
            // 
            txtDescuentosV.Location = new Point(531, 98);
            txtDescuentosV.Name = "txtDescuentosV";
            txtDescuentosV.Size = new Size(159, 30);
            txtDescuentosV.TabIndex = 3;
            // 
            // txtDevolucionessV
            // 
            txtDevolucionessV.Location = new Point(762, 98);
            txtDevolucionessV.Name = "txtDevolucionessV";
            txtDevolucionessV.Size = new Size(159, 30);
            txtDevolucionessV.TabIndex = 4;
            // 
            // txtCostoVentas
            // 
            txtCostoVentas.Location = new Point(322, 197);
            txtCostoVentas.Name = "txtCostoVentas";
            txtCostoVentas.Size = new Size(159, 30);
            txtCostoVentas.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(322, 64);
            label1.Name = "label1";
            label1.Size = new Size(159, 31);
            label1.TabIndex = 6;
            label1.Text = "Ventas Totales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(513, 64);
            label2.Name = "label2";
            label2.Size = new Size(209, 31);
            label2.TabIndex = 7;
            label2.Text = "Descuentos/Ventas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(762, 64);
            label3.Name = "label3";
            label3.Size = new Size(227, 31);
            label3.TabIndex = 8;
            label3.Text = "Devoluciones/Ventas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1020, 64);
            label4.Name = "label4";
            label4.Size = new Size(147, 31);
            label4.TabIndex = 9;
            label4.Text = "Ventas Netas";
            // 
            // txtVentasNetas
            // 
            txtVentasNetas.Location = new Point(1008, 98);
            txtVentasNetas.Name = "txtVentasNetas";
            txtVentasNetas.Size = new Size(159, 30);
            txtVentasNetas.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(322, 163);
            label5.Name = "label5";
            label5.Size = new Size(182, 31);
            label5.TabIndex = 11;
            label5.Text = "Compras Totales";
            // 
            // ERForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1241, 741);
            Controls.Add(label5);
            Controls.Add(txtVentasNetas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCostoVentas);
            Controls.Add(txtDevolucionessV);
            Controls.Add(txtDescuentosV);
            Controls.Add(txtVentasTotales);
            Controls.Add(button1);
            Controls.Add(dgvIngresos);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ERForm";
            Text = "ERForm";
            Load += MenuERForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIngresos;
        private Button button1;
        private TextBox txtVentasTotales;
        private TextBox txtDescuentosV;
        private TextBox txtDevolucionessV;
        private TextBox txtCostoVentas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtVentasNetas;
        private Label label5;
    }
}