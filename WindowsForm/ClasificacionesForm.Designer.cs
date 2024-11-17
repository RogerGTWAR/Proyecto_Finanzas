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
            components = new System.ComponentModel.Container();
            dgvClasificaciones = new DataGridView();
            iDClasificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clasificacionBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClasificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clasificacionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvClasificaciones
            // 
            dgvClasificaciones.AutoGenerateColumns = false;
            dgvClasificaciones.BackgroundColor = Color.White;
            dgvClasificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasificaciones.Columns.AddRange(new DataGridViewColumn[] { iDClasificacionDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            dgvClasificaciones.DataSource = clasificacionBindingSource;
            dgvClasificaciones.Location = new Point(815, 177);
            dgvClasificaciones.Name = "dgvClasificaciones";
            dgvClasificaciones.ReadOnly = true;
            dgvClasificaciones.RowHeadersWidth = 51;
            dgvClasificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasificaciones.Size = new Size(308, 188);
            dgvClasificaciones.TabIndex = 0;
            // 
            // iDClasificacionDataGridViewTextBoxColumn
            // 
            iDClasificacionDataGridViewTextBoxColumn.DataPropertyName = "ID_Clasificacion";
            iDClasificacionDataGridViewTextBoxColumn.HeaderText = "ID";
            iDClasificacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDClasificacionDataGridViewTextBoxColumn.Name = "iDClasificacionDataGridViewTextBoxColumn";
            iDClasificacionDataGridViewTextBoxColumn.ReadOnly = true;
            iDClasificacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // clasificacionBindingSource
            // 
            clasificacionBindingSource.DataSource = typeof(Models.Clasificacion);
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(1163, 223);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 70);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(905, 116);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(161, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(930, 85);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 6;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(839, 47);
            label1.Name = "label1";
            label1.Size = new Size(338, 38);
            label1.TabIndex = 7;
            label1.Text = "Clasificaciones de cuentas";
            // 
            // ClasificacionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1360, 568);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(dgvClasificaciones);
            ForeColor = Color.White;
            Name = "ClasificacionesForm";
            Text = "ClasificacionesForm";
            Load += ClasificacionesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)clasificacionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClasificaciones;
        private Button btnAgregar;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn iDClasificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private BindingSource clasificacionBindingSource;
    }
}