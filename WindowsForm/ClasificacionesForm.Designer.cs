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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dgvClasificaciones.Location = new Point(551, 153);
            dgvClasificaciones.Margin = new Padding(3, 2, 3, 2);
            dgvClasificaciones.Name = "dgvClasificaciones";
            dgvClasificaciones.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClasificaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClasificaciones.RowHeadersWidth = 51;
            dgvClasificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasificaciones.Size = new Size(306, 141);
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
            btnAgregar.Location = new Point(863, 184);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 52);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(637, 104);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(141, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(659, 81);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 6;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(579, 52);
            label1.Name = "label1";
            label1.Size = new Size(261, 30);
            label1.TabIndex = 7;
            label1.Text = "Clasificaciones de cuentas";
            // 
            // ClasificacionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1190, 426);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(dgvClasificaciones);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
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