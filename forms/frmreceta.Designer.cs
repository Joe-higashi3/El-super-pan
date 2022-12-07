namespace WindowsFormsApp2.forms
{
    partial class frmreceta
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
            this.rECETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet3 = new WindowsFormsApp2.panesitoDataSet3();
            this.rECETATableAdapter = new WindowsFormsApp2.panesitoDataSet3TableAdapters.RECETATableAdapter();
            this.gRUPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposDataSet2 = new WindowsFormsApp2.gruposDataSet2();
            this.gruposDataSet = new WindowsFormsApp2.gruposDataSet();
            this.eSTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADOTableAdapter = new WindowsFormsApp2.gruposDataSetTableAdapters.ESTADOTableAdapter();
            this.gRUPOTableAdapter = new WindowsFormsApp2.gruposDataSet2TableAdapters.GRUPOTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid_receta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rECETABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pRECETA1 = new WindowsFormsApp2.PRECETA1();
            this.rECETABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rECETAP = new WindowsFormsApp2.RECETAP();
            this.rECETADETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetaDetalle = new WindowsFormsApp2.RecetaDetalle();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBInsumo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.rECETA_DETALLETableAdapter = new WindowsFormsApp2.RecetaDetalleTableAdapters.RECETA_DETALLETableAdapter();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.rECETATableAdapter1 = new WindowsFormsApp2.RECETAPTableAdapters.RECETATableAdapter();
            this.txtIdInsumo = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtcosto = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtcantidad = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtinsumo = new WindowsFormsApp2.Utilerias.Validacion();
            this.txt_nombre = new WindowsFormsApp2.Utilerias.Validacion();
            this.rECETATableAdapter2 = new WindowsFormsApp2.PRECETA1TableAdapters.RECETATableAdapter();
            this.ridrecetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rd_id_receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rd_id_insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rd_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rd_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRECETA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETADETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // rECETABindingSource
            // 
            this.rECETABindingSource.DataMember = "RECETA";
            this.rECETABindingSource.DataSource = this.panesitoDataSet3;
            // 
            // panesitoDataSet3
            // 
            this.panesitoDataSet3.DataSetName = "panesitoDataSet3";
            this.panesitoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECETATableAdapter
            // 
            this.rECETATableAdapter.ClearBeforeFill = true;
            // 
            // gRUPOBindingSource
            // 
            this.gRUPOBindingSource.DataMember = "GRUPO";
            this.gRUPOBindingSource.DataSource = this.gruposDataSet2;
            // 
            // gruposDataSet2
            // 
            this.gruposDataSet2.DataSetName = "gruposDataSet2";
            this.gruposDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruposDataSet
            // 
            this.gruposDataSet.DataSetName = "gruposDataSet";
            this.gruposDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTADOBindingSource
            // 
            this.eSTADOBindingSource.DataMember = "ESTADO";
            this.eSTADOBindingSource.DataSource = this.gruposDataSet;
            // 
            // eSTADOTableAdapter
            // 
            this.eSTADOTableAdapter.ClearBeforeFill = true;
            // 
            // gRUPOTableAdapter
            // 
            this.gRUPOTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Receta:";
            // 
            // txtid_receta
            // 
            this.txtid_receta.Location = new System.Drawing.Point(86, 16);
            this.txtid_receta.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_receta.Name = "txtid_receta";
            this.txtid_receta.Size = new System.Drawing.Size(76, 20);
            this.txtid_receta.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ridrecetaDataGridViewTextBoxColumn,
            this.rd_id_receta,
            this.rd_id_insumo,
            this.rd_cantidad,
            this.rd_costo,
            this.in_nombre,
            this.rnombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rECETABindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 182);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 201);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // rECETABindingSource2
            // 
            this.rECETABindingSource2.DataMember = "RECETA";
            this.rECETABindingSource2.DataSource = this.pRECETA1;
            // 
            // pRECETA1
            // 
            this.pRECETA1.DataSetName = "PRECETA1";
            this.pRECETA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECETABindingSource1
            // 
            this.rECETABindingSource1.DataMember = "RECETA";
            this.rECETABindingSource1.DataSource = this.rECETAP;
            // 
            // rECETAP
            // 
            this.rECETAP.DataSetName = "RECETAP";
            this.rECETAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECETADETALLEBindingSource
            // 
            this.rECETADETALLEBindingSource.DataMember = "RECETA_DETALLE";
            this.rECETADETALLEBindingSource.DataSource = this.recetaDetalle;
            // 
            // recetaDetalle
            // 
            this.recetaDetalle.DataSetName = "RecetaDetalle";
            this.recetaDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(621, 88);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(89, 33);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(622, 139);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(88, 33);
            this.btnnuevo.TabIndex = 12;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Insumo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Costo:";
            // 
            // btnBInsumo
            // 
            this.btnBInsumo.Location = new System.Drawing.Point(421, 54);
            this.btnBInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBInsumo.Name = "btnBInsumo";
            this.btnBInsumo.Size = new System.Drawing.Size(89, 41);
            this.btnBInsumo.TabIndex = 30;
            this.btnBInsumo.Text = "BUSCAR INSUMO";
            this.btnBInsumo.UseVisualStyleBackColor = true;
            this.btnBInsumo.Click += new System.EventHandler(this.btnBInsumo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "ID Insumo:";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(421, 106);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(89, 27);
            this.btnagregar.TabIndex = 33;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // rECETA_DETALLETableAdapter
            // 
            this.rECETA_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(421, 142);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(89, 27);
            this.btnQuitar.TabIndex = 34;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // rECETATableAdapter1
            // 
            this.rECETATableAdapter1.ClearBeforeFill = true;
            // 
            // txtIdInsumo
            // 
            this.txtIdInsumo.Location = new System.Drawing.Point(71, 109);
            this.txtIdInsumo.Name = "txtIdInsumo";
            this.txtIdInsumo.Size = new System.Drawing.Size(117, 20);
            this.txtIdInsumo.SoloLetras = false;
            this.txtIdInsumo.SoloNumeros = false;
            this.txtIdInsumo.TabIndex = 32;
            this.txtIdInsumo.Validar = true;
            this.txtIdInsumo.VRFC = false;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(272, 113);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(113, 20);
            this.txtcosto.SoloLetras = false;
            this.txtcosto.SoloNumeros = false;
            this.txtcosto.TabIndex = 29;
            this.txtcosto.Validar = true;
            this.txtcosto.VRFC = false;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(272, 149);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(113, 20);
            this.txtcantidad.SoloLetras = false;
            this.txtcantidad.SoloNumeros = false;
            this.txtcantidad.TabIndex = 27;
            this.txtcantidad.Validar = true;
            this.txtcantidad.VRFC = false;
            // 
            // txtinsumo
            // 
            this.txtinsumo.Location = new System.Drawing.Point(71, 149);
            this.txtinsumo.Name = "txtinsumo";
            this.txtinsumo.Size = new System.Drawing.Size(117, 20);
            this.txtinsumo.SoloLetras = false;
            this.txtinsumo.SoloNumeros = false;
            this.txtinsumo.TabIndex = 25;
            this.txtinsumo.Validar = true;
            this.txtinsumo.VRFC = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(86, 51);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(144, 20);
            this.txt_nombre.SoloLetras = false;
            this.txt_nombre.SoloNumeros = false;
            this.txt_nombre.TabIndex = 23;
            this.txt_nombre.Validar = true;
            this.txt_nombre.VRFC = false;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // rECETATableAdapter2
            // 
            this.rECETATableAdapter2.ClearBeforeFill = true;
            // 
            // ridrecetaDataGridViewTextBoxColumn
            // 
            this.ridrecetaDataGridViewTextBoxColumn.DataPropertyName = "r_id_receta";
            this.ridrecetaDataGridViewTextBoxColumn.HeaderText = "r_id_receta";
            this.ridrecetaDataGridViewTextBoxColumn.Name = "ridrecetaDataGridViewTextBoxColumn";
            this.ridrecetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rd_id_receta
            // 
            this.rd_id_receta.DataPropertyName = "rd_id_receta";
            this.rd_id_receta.HeaderText = "rd_id_receta";
            this.rd_id_receta.Name = "rd_id_receta";
            this.rd_id_receta.ReadOnly = true;
            // 
            // rd_id_insumo
            // 
            this.rd_id_insumo.DataPropertyName = "rd_id_insumo";
            this.rd_id_insumo.HeaderText = "rd_id_insumo";
            this.rd_id_insumo.Name = "rd_id_insumo";
            this.rd_id_insumo.ReadOnly = true;
            // 
            // rd_cantidad
            // 
            this.rd_cantidad.DataPropertyName = "rd_cantidad";
            this.rd_cantidad.HeaderText = "rd_cantidad";
            this.rd_cantidad.Name = "rd_cantidad";
            this.rd_cantidad.ReadOnly = true;
            // 
            // rd_costo
            // 
            this.rd_costo.DataPropertyName = "rd_costo";
            this.rd_costo.HeaderText = "rd_costo";
            this.rd_costo.Name = "rd_costo";
            this.rd_costo.ReadOnly = true;
            // 
            // in_nombre
            // 
            this.in_nombre.DataPropertyName = "in_nombre";
            this.in_nombre.HeaderText = "in_nombre";
            this.in_nombre.Name = "in_nombre";
            this.in_nombre.ReadOnly = true;
            // 
            // rnombreDataGridViewTextBoxColumn
            // 
            this.rnombreDataGridViewTextBoxColumn.DataPropertyName = "r_nombre";
            this.rnombreDataGridViewTextBoxColumn.HeaderText = "r_nombre";
            this.rnombreDataGridViewTextBoxColumn.Name = "rnombreDataGridViewTextBoxColumn";
            this.rnombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmreceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 398);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtIdInsumo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBInsumo);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtinsumo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid_receta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmreceta";
            this.Text = "frmreceta";
            this.Load += new System.EventHandler(this.frmreceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRECETA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETADETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private panesitoDataSet3 panesitoDataSet3;
        private System.Windows.Forms.BindingSource rECETABindingSource;
        private panesitoDataSet3TableAdapters.RECETATableAdapter rECETATableAdapter;
        private gruposDataSet gruposDataSet;
        private System.Windows.Forms.BindingSource eSTADOBindingSource;
        private gruposDataSetTableAdapters.ESTADOTableAdapter eSTADOTableAdapter;
        private gruposDataSet2 gruposDataSet2;
        private System.Windows.Forms.BindingSource gRUPOBindingSource;
        private gruposDataSet2TableAdapters.GRUPOTableAdapter gRUPOTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid_receta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private Utilerias.Validacion txt_nombre;
        private Utilerias.Validacion txtinsumo;
        private System.Windows.Forms.Label label5;
        private Utilerias.Validacion txtcantidad;
        private System.Windows.Forms.Label label6;
        private Utilerias.Validacion txtcosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBInsumo;
        private Utilerias.Validacion txtIdInsumo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnagregar;
        private RecetaDetalle recetaDetalle;
        private System.Windows.Forms.BindingSource rECETADETALLEBindingSource;
        private RecetaDetalleTableAdapters.RECETA_DETALLETableAdapter rECETA_DETALLETableAdapter;
        private System.Windows.Forms.Button btnQuitar;
        private RECETAP rECETAP;
        private System.Windows.Forms.BindingSource rECETABindingSource1;
        private RECETAPTableAdapters.RECETATableAdapter rECETATableAdapter1;
        private PRECETA1 pRECETA1;
        private System.Windows.Forms.BindingSource rECETABindingSource2;
        private PRECETA1TableAdapters.RECETATableAdapter rECETATableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridrecetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rd_id_receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn rd_id_insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rd_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn rd_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnombreDataGridViewTextBoxColumn;
    }
}