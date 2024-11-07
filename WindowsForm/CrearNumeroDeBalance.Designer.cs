namespace WindowsForm
{
    partial class CrearNumeroDeBalance
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
            btnAgregar = new Button();
            txtNumeroDeBalance = new TextBox();
            dgvBalance = new DataGridView();
            label1 = new Label();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(789, 163);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 53);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNumeroDeBalance
            // 
            txtNumeroDeBalance.Location = new Point(511, 103);
            txtNumeroDeBalance.Name = "txtNumeroDeBalance";
            txtNumeroDeBalance.Size = new Size(125, 27);
            txtNumeroDeBalance.TabIndex = 1;
            // 
            // dgvBalance
            // 
            dgvBalance.BackgroundColor = Color.White;
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Location = new Point(427, 136);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.ReadOnly = true;
            dgvBalance.RowHeadersWidth = 51;
            dgvBalance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBalance.Size = new Size(341, 188);
            dgvBalance.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(471, 69);
            label1.Name = "label1";
            label1.Size = new Size(216, 31);
            label1.TabIndex = 3;
            label1.Text = "Numero De Balance";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(789, 230);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 53);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // CrearNumeroDeBalance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1301, 693);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(dgvBalance);
            Controls.Add(txtNumeroDeBalance);
            Controls.Add(btnAgregar);
            Name = "CrearNumeroDeBalance";
            Text = "CrearNumeroDeBalance";
            Load += CrearBalanceID_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtNumeroDeBalance;
        private DataGridView dgvBalance;
        private Label label1;
        private Button btnEliminar;
    }
}