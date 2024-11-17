namespace WindowsForm.Estado_de_Resultado_Forms
{
    partial class Ingresos
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
            label2 = new Label();
            label1 = new Label();
            txtNombreCuenta = new TextBox();
            txtMonto = new TextBox();
            dgvIngresos = new DataGridView();
            btnAgregar = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            cboEstadoDeResult = new ComboBox();
            cboClasificacion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(788, 188);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 10;
            label2.Text = "Nombre de la cuenta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1023, 188);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 9;
            label1.Text = "Monto";
            // 
            // txtNombreCuenta
            // 
            txtNombreCuenta.Location = new Point(826, 238);
            txtNombreCuenta.Name = "txtNombreCuenta";
            txtNombreCuenta.Size = new Size(125, 27);
            txtNombreCuenta.TabIndex = 11;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(995, 238);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 12;
            // 
            // dgvIngresos
            // 
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.Location = new Point(410, 385);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.RowHeadersWidth = 51;
            dgvIngresos.Size = new Size(710, 188);
            dgvIngresos.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(718, 303);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 49);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(527, 98);
            label4.Name = "label4";
            label4.Size = new Size(424, 38);
            label4.TabIndex = 16;
            label4.Text = "Ingresos del Estado de Resultado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(410, 188);
            label5.Name = "label5";
            label5.Size = new Size(189, 28);
            label5.TabIndex = 21;
            label5.Text = "Estado de Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(636, 188);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 20;
            label3.Text = "Clasificacion";
            // 
            // cboEstadoDeResult
            // 
            cboEstadoDeResult.FormattingEnabled = true;
            cboEstadoDeResult.Location = new Point(429, 238);
            cboEstadoDeResult.Name = "cboEstadoDeResult";
            cboEstadoDeResult.Size = new Size(151, 28);
            cboEstadoDeResult.TabIndex = 19;
            // 
            // cboClasificacion
            // 
            cboClasificacion.FormattingEnabled = true;
            cboClasificacion.Location = new Point(626, 237);
            cboClasificacion.Name = "cboClasificacion";
            cboClasificacion.Size = new Size(151, 28);
            cboClasificacion.TabIndex = 18;
            // 
            // Ingresos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1222, 756);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(cboEstadoDeResult);
            Controls.Add(cboClasificacion);
            Controls.Add(label4);
            Controls.Add(btnAgregar);
            Controls.Add(dgvIngresos);
            Controls.Add(txtMonto);
            Controls.Add(txtNombreCuenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ingresos";
            Text = "Ingresos";
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtNombreCuenta;
        private TextBox txtMonto;
        private DataGridView dgvIngresos;
        private Button btnAgregar;
        private Label label4;
        private Label label5;
        private Label label3;
        private ComboBox cboEstadoDeResult;
        private ComboBox cboClasificacion;
    }
}