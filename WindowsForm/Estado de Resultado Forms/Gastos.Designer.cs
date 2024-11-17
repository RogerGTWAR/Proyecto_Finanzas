namespace WindowsForm.Estado_de_Resultado_Forms
{
    partial class Gastos
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
            label1 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            txtNombreCuenta = new TextBox();
            txtMonto = new TextBox();
            dgvGastos = new DataGridView();
            label4 = new Label();
            cboClasificacion = new ComboBox();
            cboEstadoDeResult = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(962, 118);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 7;
            label1.Text = "Monto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(737, 118);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 8;
            label2.Text = "Nombre de la cuenta";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(674, 228);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 49);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombreCuenta
            // 
            txtNombreCuenta.Location = new Point(771, 156);
            txtNombreCuenta.Name = "txtNombreCuenta";
            txtNombreCuenta.Size = new Size(125, 27);
            txtNombreCuenta.TabIndex = 10;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(941, 156);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 11;
            // 
            // dgvGastos
            // 
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastos.Location = new Point(357, 300);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.RowHeadersWidth = 51;
            dgvGastos.Size = new Size(709, 188);
            dgvGastos.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(519, 31);
            label4.Name = "label4";
            label4.Size = new Size(402, 38);
            label4.TabIndex = 13;
            label4.Text = "Gastos del Estado de Resultado";
            // 
            // cboClasificacion
            // 
            cboClasificacion.FormattingEnabled = true;
            cboClasificacion.Location = new Point(545, 155);
            cboClasificacion.Name = "cboClasificacion";
            cboClasificacion.Size = new Size(151, 28);
            cboClasificacion.TabIndex = 14;
            // 
            // cboEstadoDeResult
            // 
            cboEstadoDeResult.FormattingEnabled = true;
            cboEstadoDeResult.Location = new Point(357, 156);
            cboEstadoDeResult.Name = "cboEstadoDeResult";
            cboEstadoDeResult.Size = new Size(151, 28);
            cboEstadoDeResult.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(560, 118);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 16;
            label3.Text = "Clasificacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(333, 118);
            label5.Name = "label5";
            label5.Size = new Size(189, 28);
            label5.TabIndex = 17;
            label5.Text = "Estado de Resultado";
            // 
            // Gastos
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
            Controls.Add(dgvGastos);
            Controls.Add(txtMonto);
            Controls.Add(txtNombreCuenta);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Gastos";
            Text = "Gastos";
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAgregar;
        private TextBox txtNombreCuenta;
        private TextBox txtMonto;
        private DataGridView dgvGastos;
        private Label label4;
        private ComboBox cboClasificacion;
        private ComboBox cboEstadoDeResult;
        private Label label3;
        private Label label5;
    }
}