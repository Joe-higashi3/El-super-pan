namespace WindowsFormsApp2.forms
{
    partial class frmproductos
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbxunidad = new System.Windows.Forms.ComboBox();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoUnidad2 = new WindowsFormsApp2.panesitoUnidad2();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoCategoria1 = new WindowsFormsApp2.panesitoCategoria1();
            this.cmbxstatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panesitoProducto = new WindowsFormsApp2.panesitoProducto();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOTableAdapter = new WindowsFormsApp2.panesitoProductoTableAdapters.PRODUCTOTableAdapter();
            this.dvgproductos = new System.Windows.Forms.DataGridView();
            this.pridproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prprecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIATableAdapter = new WindowsFormsApp2.panesitoCategoria1TableAdapters.CATEGORIATableAdapter();
            this.uNIDADTableAdapter = new WindowsFormsApp2.panesitoUnidad2TableAdapters.UNIDADTableAdapter();
            this.txtprecio = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnombre = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtdescripcion = new WindowsFormsApp2.Utilerias.Validacion();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoUnidad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoCategoria1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 69;
            this.label7.Text = "Unidad:";
            // 
            // cbxunidad
            // 
            this.cbxunidad.DataSource = this.uNIDADBindingSource;
            this.cbxunidad.DisplayMember = "un_descripcion";
            this.cbxunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxunidad.FormattingEnabled = true;
            this.cbxunidad.Location = new System.Drawing.Point(593, 4);
            this.cbxunidad.Name = "cbxunidad";
            this.cbxunidad.Size = new System.Drawing.Size(159, 33);
            this.cbxunidad.TabIndex = 64;
            this.cbxunidad.ValueMember = "un_id_unidad";
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.panesitoUnidad2;
            // 
            // panesitoUnidad2
            // 
            this.panesitoUnidad2.DataSetName = "panesitoUnidad2";
            this.panesitoUnidad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.DataSource = this.cATEGORIABindingSource;
            this.cbxcategoria.DisplayMember = "ca_descripcion";
            this.cbxcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(150, 117);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(302, 33);
            this.cbxcategoria.TabIndex = 63;
            this.cbxcategoria.ValueMember = "ca_id";
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.panesitoCategoria1;
            // 
            // panesitoCategoria1
            // 
            this.panesitoCategoria1.DataSetName = "panesitoCategoria1";
            this.panesitoCategoria1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbxstatus
            // 
            this.cmbxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxstatus.FormattingEnabled = true;
            this.cmbxstatus.Items.AddRange(new object[] {
            "Activo",
            "Deshabilitado"});
            this.cmbxstatus.Location = new System.Drawing.Point(593, 53);
            this.cmbxstatus.Name = "cmbxstatus";
            this.cmbxstatus.Size = new System.Drawing.Size(159, 33);
            this.cmbxstatus.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Nombre:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(716, 98);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(154, 39);
            this.btncancelar.TabIndex = 67;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(526, 98);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(154, 39);
            this.btnGuardarProducto.TabIndex = 66;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(150, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(78, 30);
            this.txtid.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID:";
            // 
            // panesitoProducto
            // 
            this.panesitoProducto.DataSetName = "panesitoProducto";
            this.panesitoProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.panesitoProducto;
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // dvgproductos
            // 
            this.dvgproductos.AllowUserToAddRows = false;
            this.dvgproductos.AllowUserToDeleteRows = false;
            this.dvgproductos.AutoGenerateColumns = false;
            this.dvgproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgproductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pridproductoDataGridViewTextBoxColumn,
            this.prnombreDataGridViewTextBoxColumn,
            this.pr_descripcion,
            this.ca_descripcion,
            this.un_descripcion,
            this.prprecioDataGridViewTextBoxColumn,
            this.prstatusDataGridViewTextBoxColumn});
            this.dvgproductos.DataSource = this.pRODUCTOBindingSource;
            this.dvgproductos.Location = new System.Drawing.Point(0, 167);
            this.dvgproductos.Name = "dvgproductos";
            this.dvgproductos.ReadOnly = true;
            this.dvgproductos.RowTemplate.Height = 24;
            this.dvgproductos.Size = new System.Drawing.Size(921, 297);
            this.dvgproductos.TabIndex = 70;
            this.dvgproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgproductos_CellContentClick);
            // 
            // pridproductoDataGridViewTextBoxColumn
            // 
            this.pridproductoDataGridViewTextBoxColumn.DataPropertyName = "pr_id_producto";
            this.pridproductoDataGridViewTextBoxColumn.HeaderText = "pr_id_producto";
            this.pridproductoDataGridViewTextBoxColumn.Name = "pridproductoDataGridViewTextBoxColumn";
            this.pridproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pridproductoDataGridViewTextBoxColumn.Width = 185;
            // 
            // prnombreDataGridViewTextBoxColumn
            // 
            this.prnombreDataGridViewTextBoxColumn.DataPropertyName = "pr_nombre";
            this.prnombreDataGridViewTextBoxColumn.HeaderText = "pr_nombre";
            this.prnombreDataGridViewTextBoxColumn.Name = "prnombreDataGridViewTextBoxColumn";
            this.prnombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.prnombreDataGridViewTextBoxColumn.Width = 144;
            // 
            // pr_descripcion
            // 
            this.pr_descripcion.DataPropertyName = "pr_descripcion";
            this.pr_descripcion.HeaderText = "pr_descripcion";
            this.pr_descripcion.Name = "pr_descripcion";
            this.pr_descripcion.ReadOnly = true;
            this.pr_descripcion.Width = 182;
            // 
            // ca_descripcion
            // 
            this.ca_descripcion.DataPropertyName = "ca_descripcion";
            this.ca_descripcion.HeaderText = "ca_descripcion";
            this.ca_descripcion.Name = "ca_descripcion";
            this.ca_descripcion.ReadOnly = true;
            this.ca_descripcion.Width = 186;
            // 
            // un_descripcion
            // 
            this.un_descripcion.DataPropertyName = "un_descripcion";
            this.un_descripcion.HeaderText = "un_descripcion";
            this.un_descripcion.Name = "un_descripcion";
            this.un_descripcion.ReadOnly = true;
            this.un_descripcion.Width = 187;
            // 
            // prprecioDataGridViewTextBoxColumn
            // 
            this.prprecioDataGridViewTextBoxColumn.DataPropertyName = "pr_precio";
            this.prprecioDataGridViewTextBoxColumn.HeaderText = "pr_precio";
            this.prprecioDataGridViewTextBoxColumn.Name = "prprecioDataGridViewTextBoxColumn";
            this.prprecioDataGridViewTextBoxColumn.ReadOnly = true;
            this.prprecioDataGridViewTextBoxColumn.Width = 131;
            // 
            // prstatusDataGridViewTextBoxColumn
            // 
            this.prstatusDataGridViewTextBoxColumn.DataPropertyName = "pr_status";
            this.prstatusDataGridViewTextBoxColumn.HeaderText = "pr_status";
            this.prstatusDataGridViewTextBoxColumn.Name = "prstatusDataGridViewTextBoxColumn";
            this.prstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.prstatusDataGridViewTextBoxColumn.Width = 130;
            // 
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(304, 12);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(148, 30);
            this.txtprecio.SoloLetras = false;
            this.txtprecio.SoloNumeros = false;
            this.txtprecio.TabIndex = 71;
            this.txtprecio.Validar = true;
            this.txtprecio.VRFC = false;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(150, 50);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(302, 30);
            this.txtnombre.SoloLetras = true;
            this.txtnombre.SoloNumeros = false;
            this.txtnombre.TabIndex = 72;
            this.txtnombre.Validar = true;
            this.txtnombre.VRFC = false;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Location = new System.Drawing.Point(150, 79);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(302, 30);
            this.txtdescripcion.SoloLetras = true;
            this.txtdescripcion.SoloNumeros = false;
            this.txtdescripcion.TabIndex = 73;
            this.txtdescripcion.Validar = true;
            this.txtdescripcion.VRFC = false;
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 505);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.dvgproductos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxunidad);
            this.Controls.Add(this.cbxcategoria);
            this.Controls.Add(this.cmbxstatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmproductos";
            this.Text = "frmproductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoUnidad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoCategoria1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxunidad;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.ComboBox cmbxstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private panesitoProducto panesitoProducto;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private panesitoProductoTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridView dvgproductos;
        private panesitoCategoria1 panesitoCategoria1;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private panesitoCategoria1TableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private panesitoUnidad2 panesitoUnidad2;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private panesitoUnidad2TableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn un_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn prprecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prstatusDataGridViewTextBoxColumn;
        private Utilerias.Validacion txtprecio;
        private Utilerias.Validacion txtnombre;
        private Utilerias.Validacion txtdescripcion;
        private System.Windows.Forms.ErrorProvider errorValidacion;
    }
}