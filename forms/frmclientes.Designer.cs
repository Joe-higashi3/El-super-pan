namespace WindowsFormsApp2.forms
{
    partial class frmclientes
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtwclientes = new System.Windows.Forms.DataGridView();
            this.cLIENTEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet2 = new WindowsFormsApp2.panesitoDataSet2();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxMunicipio = new System.Windows.Forms.ComboBox();
            this.mUNICIPIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMunicipio = new WindowsFormsApp2.DsMunicipio();
            this.cmbxstatus = new System.Windows.Forms.ComboBox();
            this.cLIENTETableAdapter2 = new WindowsFormsApp2.panesitoDataSet2TableAdapters.CLIENTETableAdapter();
            this.mUNICIPIOTableAdapter = new WindowsFormsApp2.DsMunicipioTableAdapters.MUNICIPIOTableAdapter();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.txttelefono = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnombre = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtapellidop = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtapellidom = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtcolonia = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnumint = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnumext = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtcalle = new WindowsFormsApp2.Utilerias.Validacion();
            this.errorValidacionn = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.tIPOCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_cliente = new WindowsFormsApp2.Tipo_cliente();
            this.label12 = new System.Windows.Forms.Label();
            this.tIPO_CLIENTETableAdapter = new WindowsFormsApp2.Tipo_clienteTableAdapters.TIPO_CLIENTETableAdapter();
            this.clidclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clapellidopatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clapellidomatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnuminteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnumexteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcoloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidmunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mu_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtwclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUNICIPIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMunicipio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacionn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOCLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(811, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 39);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(651, 181);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(154, 39);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(139, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(67, 30);
            this.txtid.TabIndex = 0;
            this.txtid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Calle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Apellido M:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Apellido P:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(746, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "N. Interior:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "N. Exterior:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Colonia:";
            // 
            // dtwclientes
            // 
            this.dtwclientes.AllowUserToAddRows = false;
            this.dtwclientes.AllowUserToDeleteRows = false;
            this.dtwclientes.AutoGenerateColumns = false;
            this.dtwclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidclienteDataGridViewTextBoxColumn,
            this.clnombreDataGridViewTextBoxColumn,
            this.clapellidopatDataGridViewTextBoxColumn,
            this.clapellidomatDataGridViewTextBoxColumn,
            this.tc_descripcion,
            this.cltelefonoDataGridViewTextBoxColumn,
            this.clcalleDataGridViewTextBoxColumn,
            this.clnuminteriorDataGridViewTextBoxColumn,
            this.clnumexteriorDataGridViewTextBoxColumn,
            this.clcoloniaDataGridViewTextBoxColumn,
            this.clidmunicipioDataGridViewTextBoxColumn,
            this.mu_descripcion,
            this.cl_status});
            this.dtwclientes.DataSource = this.cLIENTEBindingSource2;
            this.dtwclientes.Location = new System.Drawing.Point(-1, 226);
            this.dtwclientes.Name = "dtwclientes";
            this.dtwclientes.ReadOnly = true;
            this.dtwclientes.RowTemplate.Height = 24;
            this.dtwclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtwclientes.Size = new System.Drawing.Size(1104, 235);
            this.dtwclientes.TabIndex = 36;
            this.dtwclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwclientes_CellContentClick);
            this.dtwclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwclientes_CellContentClick);
            // 
            // cLIENTEBindingSource2
            // 
            this.cLIENTEBindingSource2.DataMember = "CLIENTE";
            this.cLIENTEBindingSource2.DataSource = this.panesitoDataSet2;
            // 
            // panesitoDataSet2
            // 
            this.panesitoDataSet2.DataSetName = "panesitoDataSet2";
            this.panesitoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(772, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 40;
            this.label11.Text = "Municipio:";
            // 
            // cmbxMunicipio
            // 
            this.cmbxMunicipio.DataSource = this.mUNICIPIOBindingSource;
            this.cmbxMunicipio.DisplayMember = "mu_descripcion";
            this.cmbxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMunicipio.FormattingEnabled = true;
            this.cmbxMunicipio.Location = new System.Drawing.Point(617, 94);
            this.cmbxMunicipio.Name = "cmbxMunicipio";
            this.cmbxMunicipio.Size = new System.Drawing.Size(137, 33);
            this.cmbxMunicipio.TabIndex = 41;
            this.cmbxMunicipio.ValueMember = "mu_id_municipio";
            // 
            // mUNICIPIOBindingSource
            // 
            this.mUNICIPIOBindingSource.DataMember = "MUNICIPIO";
            this.mUNICIPIOBindingSource.DataSource = this.dsMunicipio;
            // 
            // dsMunicipio
            // 
            this.dsMunicipio.DataSetName = "DsMunicipio";
            this.dsMunicipio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbxstatus
            // 
            this.cmbxstatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cmbxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxstatus.FormattingEnabled = true;
            this.cmbxstatus.Items.AddRange(new object[] {
            "Activo",
            "Cancelado"});
            this.cmbxstatus.Location = new System.Drawing.Point(860, 94);
            this.cmbxstatus.Name = "cmbxstatus";
            this.cmbxstatus.Size = new System.Drawing.Size(121, 33);
            this.cmbxstatus.TabIndex = 42;
            // 
            // cLIENTETableAdapter2
            // 
            this.cLIENTETableAdapter2.ClearBeforeFill = true;
            // 
            // mUNICIPIOTableAdapter
            // 
            this.mUNICIPIOTableAdapter.ClearBeforeFill = true;
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(318, 21);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(174, 30);
            this.txttelefono.SoloLetras = false;
            this.txttelefono.SoloNumeros = true;
            this.txttelefono.TabIndex = 43;
            this.txttelefono.Validar = true;
            this.txttelefono.VRFC = false;
            this.txttelefono.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(139, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(337, 30);
            this.txtnombre.SoloLetras = true;
            this.txtnombre.SoloNumeros = false;
            this.txtnombre.TabIndex = 44;
            this.txtnombre.Validar = true;
            this.txtnombre.VRFC = false;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtapellidop
            // 
            this.txtapellidop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellidop.Location = new System.Drawing.Point(139, 94);
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(337, 30);
            this.txtapellidop.SoloLetras = true;
            this.txtapellidop.SoloNumeros = false;
            this.txtapellidop.TabIndex = 45;
            this.txtapellidop.Validar = true;
            this.txtapellidop.VRFC = false;
            this.txtapellidop.TextChanged += new System.EventHandler(this.txtapellidop_TextChanged);
            this.txtapellidop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidop_KeyPress);
            // 
            // txtapellidom
            // 
            this.txtapellidom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellidom.Location = new System.Drawing.Point(139, 129);
            this.txtapellidom.Name = "txtapellidom";
            this.txtapellidom.Size = new System.Drawing.Size(337, 30);
            this.txtapellidom.SoloLetras = true;
            this.txtapellidom.SoloNumeros = false;
            this.txtapellidom.TabIndex = 46;
            this.txtapellidom.Validar = false;
            this.txtapellidom.VRFC = false;
            this.txtapellidom.TextChanged += new System.EventHandler(this.txtapellidom_TextChanged);
            // 
            // txtcolonia
            // 
            this.txtcolonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcolonia.Location = new System.Drawing.Point(139, 161);
            this.txtcolonia.Name = "txtcolonia";
            this.txtcolonia.Size = new System.Drawing.Size(337, 30);
            this.txtcolonia.SoloLetras = true;
            this.txtcolonia.SoloNumeros = false;
            this.txtcolonia.TabIndex = 47;
            this.txtcolonia.Validar = true;
            this.txtcolonia.VRFC = false;
            this.txtcolonia.TextChanged += new System.EventHandler(this.txtcolonia_TextChanged);
            // 
            // txtnumint
            // 
            this.txtnumint.Location = new System.Drawing.Point(865, 19);
            this.txtnumint.Name = "txtnumint";
            this.txtnumint.Size = new System.Drawing.Size(100, 30);
            this.txtnumint.SoloLetras = false;
            this.txtnumint.SoloNumeros = true;
            this.txtnumint.TabIndex = 48;
            this.txtnumint.Validar = false;
            this.txtnumint.VRFC = false;
            this.txtnumint.TextChanged += new System.EventHandler(this.txtnumint_TextChanged);
            this.txtnumint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumint_KeyPress);
            // 
            // txtnumext
            // 
            this.txtnumext.Location = new System.Drawing.Point(615, 20);
            this.txtnumext.Name = "txtnumext";
            this.txtnumext.Size = new System.Drawing.Size(125, 30);
            this.txtnumext.SoloLetras = false;
            this.txtnumext.SoloNumeros = true;
            this.txtnumext.TabIndex = 49;
            this.txtnumext.Validar = true;
            this.txtnumext.VRFC = false;
            this.txtnumext.TextChanged += new System.EventHandler(this.txtnumext_TextChanged);
            this.txtnumext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumext_KeyPress);
            // 
            // txtcalle
            // 
            this.txtcalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcalle.Location = new System.Drawing.Point(617, 57);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(348, 30);
            this.txtcalle.SoloLetras = true;
            this.txtcalle.SoloNumeros = false;
            this.txtcalle.TabIndex = 50;
            this.txtcalle.Validar = true;
            this.txtcalle.VRFC = false;
            this.txtcalle.TextChanged += new System.EventHandler(this.txtcalle_TextChanged);
            this.txtcalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcalle_KeyPress);
            // 
            // errorValidacionn
            // 
            this.errorValidacionn.ContainerControl = this;
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbxTipo.DataSource = this.tIPOCLIENTEBindingSource;
            this.cbxTipo.DisplayMember = "tc_descripcion";
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(617, 133);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(213, 33);
            this.cbxTipo.TabIndex = 52;
            this.cbxTipo.ValueMember = "tc_id";
            // 
            // tIPOCLIENTEBindingSource
            // 
            this.tIPOCLIENTEBindingSource.DataMember = "TIPO_CLIENTE";
            this.tIPOCLIENTEBindingSource.DataSource = this.tipo_cliente;
            // 
            // tipo_cliente
            // 
            this.tipo_cliente.DataSetName = "Tipo_cliente";
            this.tipo_cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(549, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 25);
            this.label12.TabIndex = 51;
            this.label12.Text = "Tipo:";
            // 
            // tIPO_CLIENTETableAdapter
            // 
            this.tIPO_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // clidclienteDataGridViewTextBoxColumn
            // 
            this.clidclienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clidclienteDataGridViewTextBoxColumn.DataPropertyName = "cl_id_cliente";
            this.clidclienteDataGridViewTextBoxColumn.HeaderText = "Id";
            this.clidclienteDataGridViewTextBoxColumn.Name = "clidclienteDataGridViewTextBoxColumn";
            this.clidclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clidclienteDataGridViewTextBoxColumn.Width = 59;
            // 
            // clnombreDataGridViewTextBoxColumn
            // 
            this.clnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnombreDataGridViewTextBoxColumn.DataPropertyName = "cl_nombre";
            this.clnombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.clnombreDataGridViewTextBoxColumn.Name = "clnombreDataGridViewTextBoxColumn";
            this.clnombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.clnombreDataGridViewTextBoxColumn.Width = 116;
            // 
            // clapellidopatDataGridViewTextBoxColumn
            // 
            this.clapellidopatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clapellidopatDataGridViewTextBoxColumn.DataPropertyName = "cl_apellido_pat";
            this.clapellidopatDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
            this.clapellidopatDataGridViewTextBoxColumn.Name = "clapellidopatDataGridViewTextBoxColumn";
            this.clapellidopatDataGridViewTextBoxColumn.ReadOnly = true;
            this.clapellidopatDataGridViewTextBoxColumn.Width = 182;
            // 
            // clapellidomatDataGridViewTextBoxColumn
            // 
            this.clapellidomatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clapellidomatDataGridViewTextBoxColumn.DataPropertyName = "cl_apellido_mat";
            this.clapellidomatDataGridViewTextBoxColumn.HeaderText = "Apellido Materno";
            this.clapellidomatDataGridViewTextBoxColumn.Name = "clapellidomatDataGridViewTextBoxColumn";
            this.clapellidomatDataGridViewTextBoxColumn.ReadOnly = true;
            this.clapellidomatDataGridViewTextBoxColumn.Width = 186;
            // 
            // tc_descripcion
            // 
            this.tc_descripcion.DataPropertyName = "tc_descripcion";
            this.tc_descripcion.HeaderText = "Tipo Cliente";
            this.tc_descripcion.Name = "tc_descripcion";
            this.tc_descripcion.ReadOnly = true;
            // 
            // cltelefonoDataGridViewTextBoxColumn
            // 
            this.cltelefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cltelefonoDataGridViewTextBoxColumn.DataPropertyName = "cl_telefono";
            this.cltelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.cltelefonoDataGridViewTextBoxColumn.Name = "cltelefonoDataGridViewTextBoxColumn";
            this.cltelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cltelefonoDataGridViewTextBoxColumn.Width = 126;
            // 
            // clcalleDataGridViewTextBoxColumn
            // 
            this.clcalleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clcalleDataGridViewTextBoxColumn.DataPropertyName = "cl_calle";
            this.clcalleDataGridViewTextBoxColumn.HeaderText = "Calle";
            this.clcalleDataGridViewTextBoxColumn.Name = "clcalleDataGridViewTextBoxColumn";
            this.clcalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.clcalleDataGridViewTextBoxColumn.Width = 91;
            // 
            // clnuminteriorDataGridViewTextBoxColumn
            // 
            this.clnuminteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnuminteriorDataGridViewTextBoxColumn.DataPropertyName = "cl_num_interior";
            this.clnuminteriorDataGridViewTextBoxColumn.HeaderText = "Num. Int.";
            this.clnuminteriorDataGridViewTextBoxColumn.Name = "clnuminteriorDataGridViewTextBoxColumn";
            this.clnuminteriorDataGridViewTextBoxColumn.ReadOnly = true;
            this.clnuminteriorDataGridViewTextBoxColumn.Width = 117;
            // 
            // clnumexteriorDataGridViewTextBoxColumn
            // 
            this.clnumexteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnumexteriorDataGridViewTextBoxColumn.DataPropertyName = "cl_num_exterior";
            this.clnumexteriorDataGridViewTextBoxColumn.HeaderText = "Num. Ext.";
            this.clnumexteriorDataGridViewTextBoxColumn.Name = "clnumexteriorDataGridViewTextBoxColumn";
            this.clnumexteriorDataGridViewTextBoxColumn.ReadOnly = true;
            this.clnumexteriorDataGridViewTextBoxColumn.Width = 123;
            // 
            // clcoloniaDataGridViewTextBoxColumn
            // 
            this.clcoloniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clcoloniaDataGridViewTextBoxColumn.DataPropertyName = "cl_colonia";
            this.clcoloniaDataGridViewTextBoxColumn.HeaderText = "Colonia";
            this.clcoloniaDataGridViewTextBoxColumn.Name = "clcoloniaDataGridViewTextBoxColumn";
            this.clcoloniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.clcoloniaDataGridViewTextBoxColumn.Width = 115;
            // 
            // clidmunicipioDataGridViewTextBoxColumn
            // 
            this.clidmunicipioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clidmunicipioDataGridViewTextBoxColumn.DataPropertyName = "cl_id_municipio";
            this.clidmunicipioDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.clidmunicipioDataGridViewTextBoxColumn.Name = "clidmunicipioDataGridViewTextBoxColumn";
            this.clidmunicipioDataGridViewTextBoxColumn.ReadOnly = true;
            this.clidmunicipioDataGridViewTextBoxColumn.Width = 133;
            // 
            // mu_descripcion
            // 
            this.mu_descripcion.DataPropertyName = "mu_descripcion";
            this.mu_descripcion.HeaderText = "Descripcion";
            this.mu_descripcion.Name = "mu_descripcion";
            this.mu_descripcion.ReadOnly = true;
            // 
            // cl_status
            // 
            this.cl_status.DataPropertyName = "cl_status";
            this.cl_status.HeaderText = "Status";
            this.cl_status.Name = "cl_status";
            this.cl_status.ReadOnly = true;
            // 
            // frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 593);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.txtnumext);
            this.Controls.Add(this.txtnumint);
            this.Controls.Add(this.txtcolonia);
            this.Controls.Add(this.txtapellidom);
            this.Controls.Add(this.txtapellidop);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.cmbxstatus);
            this.Controls.Add(this.cmbxMunicipio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtwclientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmclientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtwclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUNICIPIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMunicipio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacionn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOCLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtwclientes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbxMunicipio;
        private System.Windows.Forms.ComboBox cmbxstatus;
        private panesitoDataSet2 panesitoDataSet2;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource2;
        private panesitoDataSet2TableAdapters.CLIENTETableAdapter cLIENTETableAdapter2;
        private DsMunicipio dsMunicipio;
        private System.Windows.Forms.BindingSource mUNICIPIOBindingSource;
        private DsMunicipioTableAdapters.MUNICIPIOTableAdapter mUNICIPIOTableAdapter;
        private System.Windows.Forms.ErrorProvider errorValidacion;
        private Utilerias.Validacion txtcalle;
        private Utilerias.Validacion txtnumext;
        private Utilerias.Validacion txtnumint;
        private Utilerias.Validacion txtcolonia;
        private Utilerias.Validacion txtapellidom;
        private Utilerias.Validacion txtapellidop;
        private Utilerias.Validacion txtnombre;
        private Utilerias.Validacion txttelefono;
        private System.Windows.Forms.ErrorProvider errorValidacionn;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label12;
        private Tipo_cliente tipo_cliente;
        private System.Windows.Forms.BindingSource tIPOCLIENTEBindingSource;
        private Tipo_clienteTableAdapters.TIPO_CLIENTETableAdapter tIPO_CLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clapellidopatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clapellidomatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnuminteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnumexteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcoloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidmunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mu_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_status;
    }
}