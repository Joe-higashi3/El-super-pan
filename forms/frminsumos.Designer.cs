
namespace WindowsFormsApp2.forms
{
    partial class frminsumos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iNSUMOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtsPanesito = new WindowsFormsApp2.dtsPanesito();
            this.iNSUMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInsumosp = new WindowsFormsApp2.dsInsumosp();
            this.iNSUMOTableAdapter = new WindowsFormsApp2.dsInsumospTableAdapters.INSUMOTableAdapter();
            this.uNIDADBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet4 = new WindowsFormsApp2.panesitoDataSet4();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsunidad = new WindowsFormsApp2.dsunidad();
            this.uNIDADTableAdapter = new WindowsFormsApp2.dsunidadTableAdapters.UNIDADTableAdapter();
            this.iNSUMOTableAdapter1 = new WindowsFormsApp2.dtsPanesitoTableAdapters.INSUMOTableAdapter();
            this.uNIDADTableAdapter1 = new WindowsFormsApp2.panesitoDataSet4TableAdapters.UNIDADTableAdapter();
            this.cmbxunidad = new System.Windows.Forms.ComboBox();
            this.uNIDADBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoUnidad = new WindowsFormsApp2.panesitoUnidad();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxistatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgvinsumos = new System.Windows.Forms.DataGridView();
            this.inidinsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSUMOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoInsumo = new WindowsFormsApp2.panesitoInsumo();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iNSUMOTableAdapter2 = new WindowsFormsApp2.panesitoInsumoTableAdapters.INSUMOTableAdapter();
            this.uNIDADTableAdapter2 = new WindowsFormsApp2.panesitoUnidadTableAdapters.UNIDADTableAdapter();
            this.txtnombre = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtcosto = new WindowsFormsApp2.Utilerias.Validacion();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPanesito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInsumosp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsunidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // iNSUMOBindingSource1
            // 
            this.iNSUMOBindingSource1.DataMember = "INSUMO";
            this.iNSUMOBindingSource1.DataSource = this.dtsPanesito;
            // 
            // dtsPanesito
            // 
            this.dtsPanesito.DataSetName = "dtsPanesito";
            this.dtsPanesito.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNSUMOBindingSource
            // 
            this.iNSUMOBindingSource.DataMember = "INSUMO";
            this.iNSUMOBindingSource.DataSource = this.dsInsumosp;
            // 
            // dsInsumosp
            // 
            this.dsInsumosp.DataSetName = "dsInsumosp";
            this.dsInsumosp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNSUMOTableAdapter
            // 
            this.iNSUMOTableAdapter.ClearBeforeFill = true;
            // 
            // uNIDADBindingSource1
            // 
            this.uNIDADBindingSource1.DataMember = "UNIDAD";
            this.uNIDADBindingSource1.DataSource = this.panesitoDataSet4;
            // 
            // panesitoDataSet4
            // 
            this.panesitoDataSet4.DataSetName = "panesitoDataSet4";
            this.panesitoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.dsunidad;
            // 
            // dsunidad
            // 
            this.dsunidad.DataSetName = "dsunidad";
            this.dsunidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
            // 
            // iNSUMOTableAdapter1
            // 
            this.iNSUMOTableAdapter1.ClearBeforeFill = true;
            // 
            // uNIDADTableAdapter1
            // 
            this.uNIDADTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbxunidad
            // 
            this.cmbxunidad.DataSource = this.uNIDADBindingSource2;
            this.cmbxunidad.DisplayMember = "un_descripcion";
            this.cmbxunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxunidad.FormattingEnabled = true;
            this.cmbxunidad.Location = new System.Drawing.Point(468, 114);
            this.cmbxunidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxunidad.Name = "cmbxunidad";
            this.cmbxunidad.Size = new System.Drawing.Size(160, 24);
            this.cmbxunidad.TabIndex = 31;
            this.cmbxunidad.ValueMember = "un_id_unidad";
            // 
            // uNIDADBindingSource2
            // 
            this.uNIDADBindingSource2.DataMember = "UNIDAD";
            this.uNIDADBindingSource2.DataSource = this.panesitoUnidad;
            // 
            // panesitoUnidad
            // 
            this.panesitoUnidad.DataSetName = "panesitoUnidad";
            this.panesitoUnidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Unidad:";
            // 
            // cmbxistatus
            // 
            this.cmbxistatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxistatus.FormattingEnabled = true;
            this.cmbxistatus.Items.AddRange(new object[] {
            "Activo",
            "Cancelado"});
            this.cmbxistatus.Location = new System.Drawing.Point(796, 34);
            this.cmbxistatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxistatus.Name = "cmbxistatus";
            this.cmbxistatus.Size = new System.Drawing.Size(160, 24);
            this.cmbxistatus.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Status:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(857, 187);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(145, 33);
            this.btncancelar.TabIndex = 34;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(663, 187);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(145, 33);
            this.btnguardar.TabIndex = 33;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgvinsumos
            // 
            this.dgvinsumos.AllowUserToAddRows = false;
            this.dgvinsumos.AllowUserToDeleteRows = false;
            this.dgvinsumos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvinsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inidinsumoDataGridViewTextBoxColumn,
            this.innombreDataGridViewTextBoxColumn,
            this.un_descripcion,
            this.instatusDataGridViewTextBoxColumn});
            this.dgvinsumos.DataSource = this.iNSUMOBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvinsumos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvinsumos.Location = new System.Drawing.Point(16, 242);
            this.dgvinsumos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvinsumos.Name = "dgvinsumos";
            this.dgvinsumos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinsumos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvinsumos.Size = new System.Drawing.Size(1035, 278);
            this.dgvinsumos.TabIndex = 38;
            this.dgvinsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinsumos_CellContentClick);
            // 
            // inidinsumoDataGridViewTextBoxColumn
            // 
            this.inidinsumoDataGridViewTextBoxColumn.DataPropertyName = "in_id_insumo";
            this.inidinsumoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.inidinsumoDataGridViewTextBoxColumn.Name = "inidinsumoDataGridViewTextBoxColumn";
            this.inidinsumoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // innombreDataGridViewTextBoxColumn
            // 
            this.innombreDataGridViewTextBoxColumn.DataPropertyName = "in_nombre";
            this.innombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.innombreDataGridViewTextBoxColumn.Name = "innombreDataGridViewTextBoxColumn";
            this.innombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // un_descripcion
            // 
            this.un_descripcion.DataPropertyName = "un_descripcion";
            this.un_descripcion.HeaderText = "UNIDAD";
            this.un_descripcion.Name = "un_descripcion";
            this.un_descripcion.ReadOnly = true;
            // 
            // instatusDataGridViewTextBoxColumn
            // 
            this.instatusDataGridViewTextBoxColumn.DataPropertyName = "in_status";
            this.instatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.instatusDataGridViewTextBoxColumn.Name = "instatusDataGridViewTextBoxColumn";
            this.instatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNSUMOBindingSource2
            // 
            this.iNSUMOBindingSource2.DataMember = "INSUMO";
            this.iNSUMOBindingSource2.DataSource = this.panesitoInsumo;
            // 
            // panesitoInsumo
            // 
            this.panesitoInsumo.DataSetName = "panesitoInsumo";
            this.panesitoInsumo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(107, 34);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 22);
            this.txtid.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id:";
            // 
            // iNSUMOTableAdapter2
            // 
            this.iNSUMOTableAdapter2.ClearBeforeFill = true;
            // 
            // uNIDADTableAdapter2
            // 
            this.uNIDADTableAdapter2.ClearBeforeFill = true;
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(107, 110);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(132, 22);
            this.txtnombre.SoloLetras = false;
            this.txtnombre.SoloNumeros = false;
            this.txtnombre.TabIndex = 41;
            this.txtnombre.Validar = true;
            this.txtnombre.VRFC = false;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(468, 36);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(132, 22);
            this.txtcosto.SoloLetras = false;
            this.txtcosto.SoloNumeros = false;
            this.txtcosto.TabIndex = 42;
            this.txtcosto.Validar = true;
            this.txtcosto.VRFC = false;
            this.txtcosto.TextChanged += new System.EventHandler(this.txtcosto_TextChanged);
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // frminsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cmbxunidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbxistatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvinsumos);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frminsumos";
            this.Text = "INSUMOS";
            this.Load += new System.EventHandler(this.frminsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPanesito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInsumosp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsunidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dsInsumosp dsInsumosp;
        private System.Windows.Forms.BindingSource iNSUMOBindingSource;
        private dsInsumospTableAdapters.INSUMOTableAdapter iNSUMOTableAdapter;
        private dsunidad dsunidad;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private dsunidadTableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private dtsPanesito dtsPanesito;
        private System.Windows.Forms.BindingSource iNSUMOBindingSource1;
        private dtsPanesitoTableAdapters.INSUMOTableAdapter iNSUMOTableAdapter1;
        private panesitoDataSet4 panesitoDataSet4;
        private System.Windows.Forms.BindingSource uNIDADBindingSource1;
        private panesitoDataSet4TableAdapters.UNIDADTableAdapter uNIDADTableAdapter1;
        private System.Windows.Forms.ComboBox cmbxunidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxistatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvinsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn inidinsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn un_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn instatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private panesitoInsumo panesitoInsumo;
        private System.Windows.Forms.BindingSource iNSUMOBindingSource2;
        private panesitoInsumoTableAdapters.INSUMOTableAdapter iNSUMOTableAdapter2;
        private panesitoUnidad panesitoUnidad;
        private System.Windows.Forms.BindingSource uNIDADBindingSource2;
        private panesitoUnidadTableAdapters.UNIDADTableAdapter uNIDADTableAdapter2;
        private Utilerias.Validacion txtnombre;
        private Utilerias.Validacion txtcosto;
        private System.Windows.Forms.ErrorProvider errorValidacion;
    }
}