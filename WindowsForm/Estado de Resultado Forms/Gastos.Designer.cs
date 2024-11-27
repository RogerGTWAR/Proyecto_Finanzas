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
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1201, 71);
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
            label2.Location = new Point(976, 71);
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
            btnAgregar.Location = new Point(612, 189);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 49);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombreCuenta
            // 
            txtNombreCuenta.Location = new Point(1010, 109);
            txtNombreCuenta.Name = "txtNombreCuenta";
            txtNombreCuenta.Size = new Size(125, 27);
            txtNombreCuenta.TabIndex = 10;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(1179, 109);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 11;
            // 
            // dgvGastos
            // 
            dgvGastos.BackgroundColor = Color.White;
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastos.Location = new Point(595, 253);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.RowHeadersWidth = 51;
            dgvGastos.Size = new Size(709, 188);
            dgvGastos.TabIndex = 12;
            dgvGastos.CellClick += dgvGastos_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(771, 12);
            label4.Name = "label4";
            label4.Size = new Size(389, 37);
            label4.TabIndex = 13;
            label4.Text = "Gastos del Estado de Resultado";
            // 
            // cboClasificacion
            // 
            cboClasificacion.FormattingEnabled = true;
            cboClasificacion.Location = new Point(784, 108);
            cboClasificacion.Name = "cboClasificacion";
            cboClasificacion.Size = new Size(151, 28);
            cboClasificacion.TabIndex = 14;
            // 
            // cboEstadoDeResult
            // 
            cboEstadoDeResult.FormattingEnabled = true;
            cboEstadoDeResult.Location = new Point(595, 109);
            cboEstadoDeResult.Name = "cboEstadoDeResult";
            cboEstadoDeResult.Size = new Size(151, 28);
            cboEstadoDeResult.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(799, 71);
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
            label5.Location = new Point(571, 71);
            label5.Name = "label5";
            label5.Size = new Size(189, 28);
            label5.TabIndex = 17;
            label5.Text = "Estado de Resultado";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SeaGreen;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(904, 189);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 49);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Editar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SeaGreen;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1179, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 49);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Gastos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1317, 756);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
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
        private Button btnUpdate;
        private Button btnDelete;
    }
}