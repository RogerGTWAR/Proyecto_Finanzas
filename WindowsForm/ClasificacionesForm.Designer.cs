namespace WindowsForm
{
    partial class ClasificacionesForm
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
            dgvClasificaciones = new DataGridView();
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClasificaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvClasificaciones
            // 
            dgvClasificaciones.BackgroundColor = Color.White;
            dgvClasificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasificaciones.Location = new Point(365, 177);
            dgvClasificaciones.Name = "dgvClasificaciones";
            dgvClasificaciones.ReadOnly = true;
            dgvClasificaciones.RowHeadersWidth = 51;
            dgvClasificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasificaciones.Size = new Size(335, 188);
            dgvClasificaciones.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(706, 177);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 70);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(455, 116);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(161, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(480, 85);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 6;
            label2.Text = "Descripcion";
            // 
            // ClasificacionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(963, 568);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(dgvClasificaciones);
            Name = "ClasificacionesForm";
            Text = "ClasificacionesForm";
            Load += ClasificacionesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClasificaciones;
        private Button btnAgregar;
        private TextBox txtDescripcion;
        private Label label2;
    }
}