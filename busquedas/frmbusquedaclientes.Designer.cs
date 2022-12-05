namespace WindowsFormsApp2.busquedas
{
    partial class frmbusquedaclientes
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
            this.components = new System.ComponentModel.Container();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dgvbusquedacliente = new System.Windows.Forms.DataGridView();
            this.clidclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCliente = new WindowsFormsApp2.dsCliente();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTTELEFONO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cLIENTETableAdapter = new WindowsFormsApp2.dsClienteTableAdapters.CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedacliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(128, 27);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(337, 30);
            this.TXTNOMBRE.TabIndex = 31;
            this.TXTNOMBRE.TextChanged += new System.EventHandler(this.TXTNOMBRE_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(547, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 56);
            this.button7.TabIndex = 78;
            this.button7.Text = "Buscar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dgvbusquedacliente
            // 
            this.dgvbusquedacliente.AllowUserToAddRows = false;
            this.dgvbusquedacliente.AutoGenerateColumns = false;
            this.dgvbusquedacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbusquedacliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidclienteDataGridViewTextBoxColumn,
            this.cltelefonoDataGridViewTextBoxColumn,
            this.Nombre});
            this.dgvbusquedacliente.DataSource = this.cLIENTEBindingSource;
            this.dgvbusquedacliente.Location = new System.Drawing.Point(4, 148);
            this.dgvbusquedacliente.Name = "dgvbusquedacliente";
            this.dgvbusquedacliente.ReadOnly = true;
            this.dgvbusquedacliente.RowTemplate.Height = 24;
            this.dgvbusquedacliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbusquedacliente.Size = new System.Drawing.Size(773, 302);
            this.dgvbusquedacliente.TabIndex = 79;
            this.dgvbusquedacliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbusquedacliente_CellContentClick);
            // 
            // clidclienteDataGridViewTextBoxColumn
            // 
            this.clidclienteDataGridViewTextBoxColumn.DataPropertyName = "cl_id_cliente";
            this.clidclienteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.clidclienteDataGridViewTextBoxColumn.Name = "clidclienteDataGridViewTextBoxColumn";
            this.clidclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cltelefonoDataGridViewTextBoxColumn
            // 
            this.cltelefonoDataGridViewTextBoxColumn.DataPropertyName = "cl_telefono";
            this.cltelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.cltelefonoDataGridViewTextBoxColumn.Name = "cltelefonoDataGridViewTextBoxColumn";
            this.cltelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.dsCliente;
            // 
            // dsCliente
            // 
            this.dsCliente.DataSetName = "dsCliente";
            this.dsCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Telefono:";
            // 
            // TXTTELEFONO
            // 
            this.TXTTELEFONO.Location = new System.Drawing.Point(128, 63);
            this.TXTTELEFONO.Name = "TXTTELEFONO";
            this.TXTTELEFONO.Size = new System.Drawing.Size(154, 30);
            this.TXTTELEFONO.TabIndex = 81;
            this.TXTTELEFONO.TextChanged += new System.EventHandler(this.TXTTELEFONO_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 82;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // frmbusquedaclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTTELEFONO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvbusquedacliente);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmbusquedaclientes";
            this.Text = "frmbusquedaclientes";
            this.Load += new System.EventHandler(this.frmbusquedaclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedacliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTTELEFONO;
        private System.Windows.Forms.Button button1;
        private dsClienteTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        public System.Windows.Forms.DataGridView dgvbusquedacliente;
        public dsCliente dsCliente;
        public System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}