namespace WindowsFormsApp2.forms
{
    partial class frmbuscarproducto1
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
            this.dgvbusquedaproductos = new System.Windows.Forms.DataGridView();
            this.pr_id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarproducto = new WindowsFormsApp2.Buscarproducto();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pRODUCTOTableAdapter = new WindowsFormsApp2.BuscarproductoTableAdapters.PRODUCTOTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedaproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbusquedaproductos
            // 
            this.dgvbusquedaproductos.AllowUserToAddRows = false;
            this.dgvbusquedaproductos.AllowUserToDeleteRows = false;
            this.dgvbusquedaproductos.AutoGenerateColumns = false;
            this.dgvbusquedaproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbusquedaproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pr_id_producto,
            this.prnombreDataGridViewTextBoxColumn});
            this.dgvbusquedaproductos.DataSource = this.pRODUCTOBindingSource;
            this.dgvbusquedaproductos.Location = new System.Drawing.Point(4, 172);
            this.dgvbusquedaproductos.Name = "dgvbusquedaproductos";
            this.dgvbusquedaproductos.ReadOnly = true;
            this.dgvbusquedaproductos.RowTemplate.Height = 24;
            this.dgvbusquedaproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbusquedaproductos.Size = new System.Drawing.Size(773, 302);
            this.dgvbusquedaproductos.TabIndex = 85;
            // 
            // pr_id_producto
            // 
            this.pr_id_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pr_id_producto.DataPropertyName = "pr_id_producto";
            this.pr_id_producto.HeaderText = "Codigo_producto";
            this.pr_id_producto.Name = "pr_id_producto";
            this.pr_id_producto.ReadOnly = true;
            this.pr_id_producto.Width = 145;
            // 
            // prnombreDataGridViewTextBoxColumn
            // 
            this.prnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.prnombreDataGridViewTextBoxColumn.DataPropertyName = "pr_nombre";
            this.prnombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.prnombreDataGridViewTextBoxColumn.Name = "prnombreDataGridViewTextBoxColumn";
            this.prnombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.prnombreDataGridViewTextBoxColumn.Width = 87;
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.buscarproducto;
            // 
            // buscarproducto
            // 
            this.buscarproducto.DataSetName = "Buscarproducto";
            this.buscarproducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMBRE.Location = new System.Drawing.Point(133, 59);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(337, 30);
            this.TXTNOMBRE.TabIndex = 83;
            this.TXTNOMBRE.TextChanged += new System.EventHandler(this.TXTNOMBRE_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nombre:";
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(133, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(78, 30);
            this.txtId.TabIndex = 86;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "ID:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(646, 480);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 32);
            this.btnAceptar.TabIndex = 88;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmbuscarproducto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 524);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvbusquedaproductos);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label2);
            this.Name = "frmbuscarproducto1";
            this.Text = "Buscar Productos";
            this.Load += new System.EventHandler(this.frmbuscarproducto1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedaproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvbusquedaproductos;
        public System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnombreDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        public Buscarproducto buscarproducto;
        public System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        public BuscarproductoTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private System.Windows.Forms.Button btnAceptar;
    }
}