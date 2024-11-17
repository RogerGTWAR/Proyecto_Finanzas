namespace WindowsForm.Estado_de_Resultado_Forms
{
    partial class ClasificacionesER
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
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            dgvClasificaciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClasificaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(261, 102);
            label1.Name = "label1";
            label1.Size = new Size(595, 38);
            label1.TabIndex = 12;
            label1.Text = "Clasificaciones de cuentas Estado de Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(496, 162);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 11;
            label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(471, 193);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(161, 27);
            txtDescripcion.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(709, 254);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 70);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvClasificaciones
            // 
            dgvClasificaciones.BackgroundColor = Color.White;
            dgvClasificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasificaciones.Location = new Point(381, 254);
            dgvClasificaciones.Name = "dgvClasificaciones";
            dgvClasificaciones.ReadOnly = true;
            dgvClasificaciones.RowHeadersWidth = 51;
            dgvClasificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasificaciones.Size = new Size(308, 188);
            dgvClasificaciones.TabIndex = 8;
            // 
            // ClasificacionesER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(913, 555);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(dgvClasificaciones);
            Name = "ClasificacionesER";
            Text = "ClasificacionesER";
            ((System.ComponentModel.ISupportInitialize)dgvClasificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private DataGridView dgvClasificaciones;
    }
}