namespace WindowsForm
{
    partial class DatosBalanceForm
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
            btnAgregar = new Button();
            txtNombreBalance = new TextBox();
            dgvBalance = new DataGridView();
            datosBalanceGBindingSource = new BindingSource(components);
            balanceRepositoryBindingSource = new BindingSource(components);
            label1 = new Label();
            btnEliminar = new Button();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ID_DatosBalance = new DataGridViewTextBoxColumn();
            nombreBG = new DataGridViewTextBoxColumn();
            fechaInicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechafinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datosBalanceGBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)balanceRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(409, 363);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 53);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombreBalance
            // 
            txtNombreBalance.Location = new Point(407, 107);
            txtNombreBalance.Name = "txtNombreBalance";
            txtNombreBalance.Size = new Size(190, 27);
            txtNombreBalance.TabIndex = 1;
            // 
            // dgvBalance
            // 
            dgvBalance.AutoGenerateColumns = false;
            dgvBalance.BackgroundColor = Color.White;
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Columns.AddRange(new DataGridViewColumn[] { ID_DatosBalance, nombreBG, fechaInicioDataGridViewTextBoxColumn, fechafinDataGridViewTextBoxColumn });
            dgvBalance.DataSource = datosBalanceGBindingSource;
            dgvBalance.Location = new Point(409, 149);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.ReadOnly = true;
            dgvBalance.RowHeadersWidth = 51;
            dgvBalance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBalance.Size = new Size(487, 188);
            dgvBalance.TabIndex = 2;
            // 
            // datosBalanceGBindingSource
            // 
            datosBalanceGBindingSource.DataSource = typeof(Models.DatosBalanceG);
            // 
            // balanceRepositoryBindingSource
            // 
            balanceRepositoryBindingSource.DataSource = typeof(IRepository.Repository.BalanceRepository);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(394, 73);
            label1.Name = "label1";
            label1.Size = new Size(215, 31);
            label1.TabIndex = 3;
            label1.Text = "Nombre de Balance";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(767, 363);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 53);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(629, 109);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(133, 30);
            dtpFechaInicio.TabIndex = 5;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(789, 107);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(133, 30);
            dtpFechaFin.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(660, 73);
            label2.Name = "label2";
            label2.Size = new Size(69, 31);
            label2.TabIndex = 7;
            label2.Text = "Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(831, 73);
            label3.Name = "label3";
            label3.Size = new Size(44, 31);
            label3.TabIndex = 8;
            label3.Text = "Fin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(485, 35);
            label4.Name = "label4";
            label4.Size = new Size(371, 38);
            label4.TabIndex = 9;
            label4.Text = "Creacion de Balance General";
            // 
            // ID_DatosBalance
            // 
            ID_DatosBalance.DataPropertyName = "ID_DatosBalance";
            ID_DatosBalance.HeaderText = "ID";
            ID_DatosBalance.MinimumWidth = 6;
            ID_DatosBalance.Name = "ID_DatosBalance";
            ID_DatosBalance.ReadOnly = true;
            ID_DatosBalance.Width = 50;
            // 
            // nombreBG
            // 
            nombreBG.DataPropertyName = "NombreBG";
            nombreBG.HeaderText = "Nombre";
            nombreBG.MinimumWidth = 6;
            nombreBG.Name = "nombreBG";
            nombreBG.ReadOnly = true;
            nombreBG.Width = 125;
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
            // DatosBalanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1189, 693);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(dgvBalance);
            Controls.Add(txtNombreBalance);
            Controls.Add(btnAgregar);
            Name = "DatosBalanceForm";
            Text = "CrearNumeroDeBalance";
            Load += CrearBalanceID_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)datosBalanceGBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)balanceRepositoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtNombreBalance;
        private DataGridView dgvBalance;
        private Label label1;
        private Button btnEliminar;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Label label2;
        private Label label3;
        private Label label4;
        private BindingSource balanceRepositoryBindingSource;
        private BindingSource datosBalanceGBindingSource;
        private DataGridViewTextBoxColumn ID_DatosBalance;
        private DataGridViewTextBoxColumn nombreBG;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechafinDataGridViewTextBoxColumn;
    }
}