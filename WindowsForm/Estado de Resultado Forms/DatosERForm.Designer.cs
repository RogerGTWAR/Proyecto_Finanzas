namespace WindowsForm
{
    partial class DatosERForm
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
            dgvDatosER = new DataGridView();
            txtNombreER = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFIn = new DateTimePicker();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            datosERBindingSource = new BindingSource(components);
            iDDatosERDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreERDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaInicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechafinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatosER).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datosERBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvDatosER
            // 
            dgvDatosER.AutoGenerateColumns = false;
            dgvDatosER.BackgroundColor = Color.White;
            dgvDatosER.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosER.Columns.AddRange(new DataGridViewColumn[] { iDDatosERDataGridViewTextBoxColumn, nombreERDataGridViewTextBoxColumn, fechaInicioDataGridViewTextBoxColumn, fechafinDataGridViewTextBoxColumn });
            dgvDatosER.DataSource = datosERBindingSource;
            dgvDatosER.Location = new Point(434, 231);
            dgvDatosER.Name = "dgvDatosER";
            dgvDatosER.ReadOnly = true;
            dgvDatosER.RowHeadersWidth = 51;
            dgvDatosER.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosER.Size = new Size(521, 188);
            dgvDatosER.TabIndex = 0;
            // 
            // txtNombreER
            // 
            txtNombreER.Location = new Point(448, 131);
            txtNombreER.Name = "txtNombreER";
            txtNombreER.Size = new Size(167, 27);
            txtNombreER.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(648, 129);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(104, 27);
            dtpFechaInicio.TabIndex = 2;
            // 
            // dtpFechaFIn
            // 
            dtpFechaFIn.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFIn.Format = DateTimePickerFormat.Short;
            dtpFechaFIn.Location = new Point(786, 127);
            dtpFechaFIn.Name = "dtpFechaFIn";
            dtpFechaFIn.Size = new Size(104, 27);
            dtpFechaFIn.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(640, 176);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 49);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(460, 100);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 5;
            label1.Text = "Nombre del ER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(667, 100);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 6;
            label2.Text = "Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(820, 100);
            label3.Name = "label3";
            label3.Size = new Size(38, 28);
            label3.TabIndex = 7;
            label3.Text = "Fin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(469, 51);
            label4.Name = "label4";
            label4.Size = new Size(421, 38);
            label4.TabIndex = 8;
            label4.Text = "Creacion de Estado de Resultado";
            // 
            // datosERBindingSource
            // 
            datosERBindingSource.DataSource = typeof(Models.DatosER);
            // 
            // iDDatosERDataGridViewTextBoxColumn
            // 
            iDDatosERDataGridViewTextBoxColumn.DataPropertyName = "ID_DatosER";
            iDDatosERDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDatosERDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDatosERDataGridViewTextBoxColumn.Name = "iDDatosERDataGridViewTextBoxColumn";
            iDDatosERDataGridViewTextBoxColumn.ReadOnly = true;
            iDDatosERDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreERDataGridViewTextBoxColumn
            // 
            nombreERDataGridViewTextBoxColumn.DataPropertyName = "NombreER";
            nombreERDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreERDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreERDataGridViewTextBoxColumn.Name = "nombreERDataGridViewTextBoxColumn";
            nombreERDataGridViewTextBoxColumn.ReadOnly = true;
            nombreERDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            fechaInicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            fechaInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechafinDataGridViewTextBoxColumn
            // 
            fechafinDataGridViewTextBoxColumn.DataPropertyName = "Fechafin";
            fechafinDataGridViewTextBoxColumn.HeaderText = "Fecha de Finalizacion";
            fechafinDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechafinDataGridViewTextBoxColumn.Name = "fechafinDataGridViewTextBoxColumn";
            fechafinDataGridViewTextBoxColumn.ReadOnly = true;
            fechafinDataGridViewTextBoxColumn.Width = 125;
            // 
            // DatosERForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1222, 756);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaFIn);
            Controls.Add(dtpFechaInicio);
            Controls.Add(txtNombreER);
            Controls.Add(dgvDatosER);
            Name = "DatosERForm";
            Text = "DatosER";
            Load += DatosER_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatosER).EndInit();
            ((System.ComponentModel.ISupportInitialize)datosERBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatosER;
        private TextBox txtNombreER;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFIn;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn iDDatosERDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreERDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechafinDataGridViewTextBoxColumn;
        private BindingSource datosERBindingSource;
    }
}