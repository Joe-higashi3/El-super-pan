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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxstatus = new System.Windows.Forms.ComboBox();
            this.cbxgrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid_receta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdidrecetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdidinsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdcantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdcostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECETADETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetaDetalle = new WindowsFormsApp2.RecetaDetalle();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txt_nombre = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtinsumo = new WindowsFormsApp2.Utilerias.Validacion();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcantidad = new WindowsFormsApp2.Utilerias.Validacion();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcosto = new WindowsFormsApp2.Utilerias.Validacion();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBInsumo = new System.Windows.Forms.Button();
            this.txtIdInsumo = new WindowsFormsApp2.Utilerias.Validacion();
            this.label8 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.rECETA_DETALLETableAdapter = new WindowsFormsApp2.RecetaDetalleTableAdapters.RECETA_DETALLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Status:";
            // 
            // cmbxstatus
            // 
            this.cmbxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxstatus.FormattingEnabled = true;
            this.cmbxstatus.Items.AddRange(new object[] {
            "Activo",
            "Cancelado"});
            this.cmbxstatus.Location = new System.Drawing.Point(338, 16);
            this.cmbxstatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxstatus.Name = "cmbxstatus";
            this.cmbxstatus.Size = new System.Drawing.Size(92, 21);
            this.cmbxstatus.TabIndex = 21;
            // 
            // cbxgrupo
            // 
            this.cbxgrupo.DataSource = this.gRUPOBindingSource;
            this.cbxgrupo.DisplayMember = "g_descripcion";
            this.cbxgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxgrupo.FormattingEnabled = true;
            this.cbxgrupo.Location = new System.Drawing.Point(338, 51);
            this.cbxgrupo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxgrupo.Name = "cbxgrupo";
            this.cbxgrupo.Size = new System.Drawing.Size(92, 21);
            this.cbxgrupo.TabIndex = 20;
            this.cbxgrupo.ValueMember = "g_id_grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Grupo:";
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
            this.rdidrecetaDataGridViewTextBoxColumn,
            this.rdidinsumoDataGridViewTextBoxColumn,
            this.rdcantidadDataGridViewTextBoxColumn,
            this.rdcostoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rECETADETALLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 182);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 201);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // rdidrecetaDataGridViewTextBoxColumn
            // 
            this.rdidrecetaDataGridViewTextBoxColumn.DataPropertyName = "rd_id_receta";
            this.rdidrecetaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.rdidrecetaDataGridViewTextBoxColumn.Name = "rdidrecetaDataGridViewTextBoxColumn";
            this.rdidrecetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rdidinsumoDataGridViewTextBoxColumn
            // 
            this.rdidinsumoDataGridViewTextBoxColumn.DataPropertyName = "rd_id_insumo";
            this.rdidinsumoDataGridViewTextBoxColumn.HeaderText = "ID INSUMO";
            this.rdidinsumoDataGridViewTextBoxColumn.Name = "rdidinsumoDataGridViewTextBoxColumn";
            this.rdidinsumoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rdcantidadDataGridViewTextBoxColumn
            // 
            this.rdcantidadDataGridViewTextBoxColumn.DataPropertyName = "rd_cantidad";
            this.rdcantidadDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.rdcantidadDataGridViewTextBoxColumn.Name = "rdcantidadDataGridViewTextBoxColumn";
            this.rdcantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rdcostoDataGridViewTextBoxColumn
            // 
            this.rdcostoDataGridViewTextBoxColumn.DataPropertyName = "rd_costo";
            this.rdcostoDataGridViewTextBoxColumn.HeaderText = "COSTO";
            this.rdcostoDataGridViewTextBoxColumn.Name = "rdcostoDataGridViewTextBoxColumn";
            this.rdcostoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.btnBInsumo.Location = new System.Drawing.Point(421, 98);
            this.btnBInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBInsumo.Name = "btnBInsumo";
            this.btnBInsumo.Size = new System.Drawing.Size(89, 41);
            this.btnBInsumo.TabIndex = 30;
            this.btnBInsumo.Text = "BUSCAR INSUMO";
            this.btnBInsumo.UseVisualStyleBackColor = true;
            this.btnBInsumo.Click += new System.EventHandler(this.btnBInsumo_Click);
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
            this.btnagregar.Location = new System.Drawing.Point(421, 145);
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
            // frmreceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 398);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbxstatus);
            this.Controls.Add(this.cbxgrupo);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxstatus;
        private System.Windows.Forms.ComboBox cbxgrupo;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn rdidrecetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdidinsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdcantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdcostoDataGridViewTextBoxColumn;
    }
}