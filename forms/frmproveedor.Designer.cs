namespace WindowsFormsApp2.forms
{
    partial class frmproveedor
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
            this.cbxstatus = new System.Windows.Forms.ComboBox();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.mUNICIPIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet7 = new WindowsFormsApp2.panesitoDataSet7();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxregimen = new System.Windows.Forms.ComboBox();
            this.rEGIMENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet8 = new WindowsFormsApp2.panesitoDataSet8();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pdridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrapellidopatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrapellidomatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrregimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrRFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrrasonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrtelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrcalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrnuminteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrnumexteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrcoloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdridmunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdrstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVEEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoProveedores = new WindowsFormsApp2.PanesitoProveedores();
            this.pROVEEDORTableAdapter = new WindowsFormsApp2.PanesitoProveedoresTableAdapters.PROVEEDORTableAdapter();
            this.mUNICIPIOTableAdapter = new WindowsFormsApp2.panesitoDataSet7TableAdapters.MUNICIPIOTableAdapter();
            this.rEGIMENTableAdapter = new WindowsFormsApp2.panesitoDataSet8TableAdapters.REGIMENTableAdapter();
            this.txttelefono = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnombre = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtapellidop = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtapellidom = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtrazon_social = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtcolonia = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnumint = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtnumext = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtcalle = new WindowsFormsApp2.Utilerias.Validacion();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtRFC = new WindowsFormsApp2.Utilerias.Validacion();
            ((System.ComponentModel.ISupportInitialize)(this.mUNICIPIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIMENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxstatus
            // 
            this.cbxstatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxstatus.FormattingEnabled = true;
            this.cbxstatus.Items.AddRange(new object[] {
            "Activo",
            "Cancelado"});
            this.cbxstatus.Location = new System.Drawing.Point(1440, 197);
            this.cbxstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxstatus.Name = "cbxstatus";
            this.cbxstatus.Size = new System.Drawing.Size(220, 50);
            this.cbxstatus.TabIndex = 26;
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.DataSource = this.mUNICIPIOBindingSource;
            this.cbxMunicipio.DisplayMember = "mu_descripcion";
            this.cbxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(1037, 201);
            this.cbxMunicipio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(241, 50);
            this.cbxMunicipio.TabIndex = 24;
            this.cbxMunicipio.ValueMember = "mu_id_municipio";
            // 
            // mUNICIPIOBindingSource
            // 
            this.mUNICIPIOBindingSource.DataMember = "MUNICIPIO";
            this.mUNICIPIOBindingSource.DataSource = this.panesitoDataSet7;
            // 
            // panesitoDataSet7
            // 
            this.panesitoDataSet7.DataSetName = "panesitoDataSet7";
            this.panesitoDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(815, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 44);
            this.label11.TabIndex = 64;
            this.label11.Text = "Municipio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1284, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 46);
            this.label10.TabIndex = 63;
            this.label10.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(829, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 51);
            this.label9.TabIndex = 62;
            this.label9.Text = "Colonia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(784, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 51);
            this.label8.TabIndex = 61;
            this.label8.Text = "N. Exterior:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1214, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 51);
            this.label7.TabIndex = 60;
            this.label7.Text = "N. Interior:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 51);
            this.label6.TabIndex = 59;
            this.label6.Text = "Apellido P:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 51);
            this.label5.TabIndex = 58;
            this.label5.Text = "Apellido M:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1356, 293);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(239, 62);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(1119, 293);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(231, 62);
            this.btnguardar.TabIndex = 28;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(109, 6);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(67, 56);
            this.txtid.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(879, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 51);
            this.label4.TabIndex = 54;
            this.label4.Text = "Calle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 51);
            this.label3.TabIndex = 53;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 51);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 51);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(163, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 51);
            this.label12.TabIndex = 68;
            this.label12.Text = "RFC:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 44);
            this.label13.TabIndex = 70;
            this.label13.Text = "Regimen:";
            // 
            // cbxregimen
            // 
            this.cbxregimen.DataSource = this.rEGIMENBindingSource;
            this.cbxregimen.DisplayMember = "rg_descripcion";
            this.cbxregimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxregimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxregimen.FormattingEnabled = true;
            this.cbxregimen.Location = new System.Drawing.Point(219, 398);
            this.cbxregimen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxregimen.Name = "cbxregimen";
            this.cbxregimen.Size = new System.Drawing.Size(1620, 44);
            this.cbxregimen.TabIndex = 14;
            this.cbxregimen.ValueMember = "rg_id";
            // 
            // rEGIMENBindingSource
            // 
            this.rEGIMENBindingSource.DataMember = "REGIMEN";
            this.rEGIMENBindingSource.DataSource = this.panesitoDataSet8;
            // 
            // panesitoDataSet8
            // 
            this.panesitoDataSet8.DataSetName = "panesitoDataSet8";
            this.panesitoDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(295, 51);
            this.label14.TabIndex = 73;
            this.label14.Text = "Razon social:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pdridDataGridViewTextBoxColumn,
            this.pdrnombreDataGridViewTextBoxColumn,
            this.pdrapellidopatDataGridViewTextBoxColumn,
            this.pdrapellidomatDataGridViewTextBoxColumn,
            this.pdrregimenDataGridViewTextBoxColumn,
            this.pdrRFCDataGridViewTextBoxColumn,
            this.pdrrasonsocialDataGridViewTextBoxColumn,
            this.pdrtelefonoDataGridViewTextBoxColumn,
            this.pdrcalleDataGridViewTextBoxColumn,
            this.pdrnuminteriorDataGridViewTextBoxColumn,
            this.pdrnumexteriorDataGridViewTextBoxColumn,
            this.pdrcoloniaDataGridViewTextBoxColumn,
            this.pdridmunicipioDataGridViewTextBoxColumn,
            this.pdrstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROVEEDORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 658);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1619, 330);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pdridDataGridViewTextBoxColumn
            // 
            this.pdridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdridDataGridViewTextBoxColumn.DataPropertyName = "pdr_id";
            this.pdridDataGridViewTextBoxColumn.HeaderText = "pdr_id";
            this.pdridDataGridViewTextBoxColumn.Name = "pdridDataGridViewTextBoxColumn";
            this.pdridDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdridDataGridViewTextBoxColumn.Width = 77;
            // 
            // pdrnombreDataGridViewTextBoxColumn
            // 
            this.pdrnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrnombreDataGridViewTextBoxColumn.DataPropertyName = "pdr_nombre";
            this.pdrnombreDataGridViewTextBoxColumn.HeaderText = "pdr_nombre";
            this.pdrnombreDataGridViewTextBoxColumn.Name = "pdrnombreDataGridViewTextBoxColumn";
            this.pdrnombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrnombreDataGridViewTextBoxColumn.Width = 114;
            // 
            // pdrapellidopatDataGridViewTextBoxColumn
            // 
            this.pdrapellidopatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrapellidopatDataGridViewTextBoxColumn.DataPropertyName = "pdr_apellido_pat";
            this.pdrapellidopatDataGridViewTextBoxColumn.HeaderText = "pdr_apellido_pat";
            this.pdrapellidopatDataGridViewTextBoxColumn.Name = "pdrapellidopatDataGridViewTextBoxColumn";
            this.pdrapellidopatDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrapellidopatDataGridViewTextBoxColumn.Width = 143;
            // 
            // pdrapellidomatDataGridViewTextBoxColumn
            // 
            this.pdrapellidomatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrapellidomatDataGridViewTextBoxColumn.DataPropertyName = "pdr_apellido_mat";
            this.pdrapellidomatDataGridViewTextBoxColumn.HeaderText = "pdr_apellido_mat";
            this.pdrapellidomatDataGridViewTextBoxColumn.Name = "pdrapellidomatDataGridViewTextBoxColumn";
            this.pdrapellidomatDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrapellidomatDataGridViewTextBoxColumn.Width = 146;
            // 
            // pdrregimenDataGridViewTextBoxColumn
            // 
            this.pdrregimenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrregimenDataGridViewTextBoxColumn.DataPropertyName = "pdr_regimen";
            this.pdrregimenDataGridViewTextBoxColumn.HeaderText = "pdr_regimen";
            this.pdrregimenDataGridViewTextBoxColumn.Name = "pdrregimenDataGridViewTextBoxColumn";
            this.pdrregimenDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrregimenDataGridViewTextBoxColumn.Width = 117;
            // 
            // pdrRFCDataGridViewTextBoxColumn
            // 
            this.pdrRFCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrRFCDataGridViewTextBoxColumn.DataPropertyName = "pdr_RFC";
            this.pdrRFCDataGridViewTextBoxColumn.HeaderText = "pdr_RFC";
            this.pdrRFCDataGridViewTextBoxColumn.Name = "pdrRFCDataGridViewTextBoxColumn";
            this.pdrRFCDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrRFCDataGridViewTextBoxColumn.Width = 93;
            // 
            // pdrrasonsocialDataGridViewTextBoxColumn
            // 
            this.pdrrasonsocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrrasonsocialDataGridViewTextBoxColumn.DataPropertyName = "pdr_rason_social";
            this.pdrrasonsocialDataGridViewTextBoxColumn.HeaderText = "pdr_rason_social";
            this.pdrrasonsocialDataGridViewTextBoxColumn.Name = "pdrrasonsocialDataGridViewTextBoxColumn";
            this.pdrrasonsocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrrasonsocialDataGridViewTextBoxColumn.Width = 146;
            // 
            // pdrtelefonoDataGridViewTextBoxColumn
            // 
            this.pdrtelefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrtelefonoDataGridViewTextBoxColumn.DataPropertyName = "pdr_telefono";
            this.pdrtelefonoDataGridViewTextBoxColumn.HeaderText = "pdr_telefono";
            this.pdrtelefonoDataGridViewTextBoxColumn.Name = "pdrtelefonoDataGridViewTextBoxColumn";
            this.pdrtelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrtelefonoDataGridViewTextBoxColumn.Width = 117;
            // 
            // pdrcalleDataGridViewTextBoxColumn
            // 
            this.pdrcalleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrcalleDataGridViewTextBoxColumn.DataPropertyName = "pdr_calle";
            this.pdrcalleDataGridViewTextBoxColumn.HeaderText = "pdr_calle";
            this.pdrcalleDataGridViewTextBoxColumn.Name = "pdrcalleDataGridViewTextBoxColumn";
            this.pdrcalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrcalleDataGridViewTextBoxColumn.Width = 95;
            // 
            // pdrnuminteriorDataGridViewTextBoxColumn
            // 
            this.pdrnuminteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrnuminteriorDataGridViewTextBoxColumn.DataPropertyName = "pdr_num_interior";
            this.pdrnuminteriorDataGridViewTextBoxColumn.HeaderText = "pdr_num_interior";
            this.pdrnuminteriorDataGridViewTextBoxColumn.Name = "pdrnuminteriorDataGridViewTextBoxColumn";
            this.pdrnuminteriorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrnuminteriorDataGridViewTextBoxColumn.Width = 145;
            // 
            // pdrnumexteriorDataGridViewTextBoxColumn
            // 
            this.pdrnumexteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrnumexteriorDataGridViewTextBoxColumn.DataPropertyName = "pdr_num_exterior";
            this.pdrnumexteriorDataGridViewTextBoxColumn.HeaderText = "pdr_num_exterior";
            this.pdrnumexteriorDataGridViewTextBoxColumn.Name = "pdrnumexteriorDataGridViewTextBoxColumn";
            this.pdrnumexteriorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrnumexteriorDataGridViewTextBoxColumn.Width = 148;
            // 
            // pdrcoloniaDataGridViewTextBoxColumn
            // 
            this.pdrcoloniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrcoloniaDataGridViewTextBoxColumn.DataPropertyName = "pdr_colonia";
            this.pdrcoloniaDataGridViewTextBoxColumn.HeaderText = "pdr_colonia";
            this.pdrcoloniaDataGridViewTextBoxColumn.Name = "pdrcoloniaDataGridViewTextBoxColumn";
            this.pdrcoloniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrcoloniaDataGridViewTextBoxColumn.Width = 111;
            // 
            // pdridmunicipioDataGridViewTextBoxColumn
            // 
            this.pdridmunicipioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdridmunicipioDataGridViewTextBoxColumn.DataPropertyName = "pdr_id_municipio";
            this.pdridmunicipioDataGridViewTextBoxColumn.HeaderText = "pdr_id_municipio";
            this.pdridmunicipioDataGridViewTextBoxColumn.Name = "pdridmunicipioDataGridViewTextBoxColumn";
            this.pdridmunicipioDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdridmunicipioDataGridViewTextBoxColumn.Width = 144;
            // 
            // pdrstatusDataGridViewTextBoxColumn
            // 
            this.pdrstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pdrstatusDataGridViewTextBoxColumn.DataPropertyName = "pdr_status";
            this.pdrstatusDataGridViewTextBoxColumn.HeaderText = "pdr_status";
            this.pdrstatusDataGridViewTextBoxColumn.Name = "pdrstatusDataGridViewTextBoxColumn";
            this.pdrstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdrstatusDataGridViewTextBoxColumn.Width = 104;
            // 
            // pROVEEDORBindingSource
            // 
            this.pROVEEDORBindingSource.DataMember = "PROVEEDOR";
            this.pROVEEDORBindingSource.DataSource = this.panesitoProveedores;
            // 
            // panesitoProveedores
            // 
            this.panesitoProveedores.DataSetName = "PanesitoProveedores";
            this.panesitoProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVEEDORTableAdapter
            // 
            this.pROVEEDORTableAdapter.ClearBeforeFill = true;
            // 
            // mUNICIPIOTableAdapter
            // 
            this.mUNICIPIOTableAdapter.ClearBeforeFill = true;
            // 
            // rEGIMENTableAdapter
            // 
            this.rEGIMENTableAdapter.ClearBeforeFill = true;
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txttelefono.Location = new System.Drawing.Point(419, 5);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(308, 56);
            this.txttelefono.SoloLetras = false;
            this.txttelefono.SoloNumeros = false;
            this.txttelefono.TabIndex = 2;
            this.txttelefono.Validar = true;
            this.txttelefono.VRFC = false;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtnombre.Location = new System.Drawing.Point(300, 68);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(427, 56);
            this.txtnombre.SoloLetras = true;
            this.txtnombre.SoloNumeros = false;
            this.txtnombre.TabIndex = 4;
            this.txtnombre.Validar = false;
            this.txtnombre.VRFC = false;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtapellidop
            // 
            this.txtapellidop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellidop.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtapellidop.Location = new System.Drawing.Point(301, 132);
            this.txtapellidop.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(425, 56);
            this.txtapellidop.SoloLetras = true;
            this.txtapellidop.SoloNumeros = false;
            this.txtapellidop.TabIndex = 6;
            this.txtapellidop.Validar = false;
            this.txtapellidop.VRFC = false;
            this.txtapellidop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidop_KeyPress);
            // 
            // txtapellidom
            // 
            this.txtapellidom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellidom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtapellidom.Location = new System.Drawing.Point(301, 192);
            this.txtapellidom.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellidom.Name = "txtapellidom";
            this.txtapellidom.Size = new System.Drawing.Size(427, 56);
            this.txtapellidom.SoloLetras = false;
            this.txtapellidom.SoloNumeros = false;
            this.txtapellidom.TabIndex = 8;
            this.txtapellidom.Validar = false;
            this.txtapellidom.VRFC = false;
            this.txtapellidom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidom_KeyPress);
            // 
            // txtrazon_social
            // 
            this.txtrazon_social.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrazon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtrazon_social.Location = new System.Drawing.Point(327, 322);
            this.txtrazon_social.Margin = new System.Windows.Forms.Padding(4);
            this.txtrazon_social.Name = "txtrazon_social";
            this.txtrazon_social.Size = new System.Drawing.Size(400, 56);
            this.txtrazon_social.SoloLetras = false;
            this.txtrazon_social.SoloNumeros = false;
            this.txtrazon_social.TabIndex = 12;
            this.txtrazon_social.Validar = true;
            this.txtrazon_social.VRFC = false;
            this.txtrazon_social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrazon_social_KeyPress);
            // 
            // txtcolonia
            // 
            this.txtcolonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcolonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtcolonia.Location = new System.Drawing.Point(1048, 5);
            this.txtcolonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolonia.Name = "txtcolonia";
            this.txtcolonia.Size = new System.Drawing.Size(608, 56);
            this.txtcolonia.SoloLetras = false;
            this.txtcolonia.SoloNumeros = false;
            this.txtcolonia.TabIndex = 16;
            this.txtcolonia.Validar = true;
            this.txtcolonia.VRFC = false;
            this.txtcolonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcolonia_KeyPress);
            // 
            // txtnumint
            // 
            this.txtnumint.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtnumint.Location = new System.Drawing.Point(1468, 69);
            this.txtnumint.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumint.Name = "txtnumint";
            this.txtnumint.Size = new System.Drawing.Size(192, 56);
            this.txtnumint.SoloLetras = false;
            this.txtnumint.SoloNumeros = true;
            this.txtnumint.TabIndex = 20;
            this.txtnumint.Validar = false;
            this.txtnumint.VRFC = false;
            this.txtnumint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumint_KeyPress);
            // 
            // txtnumext
            // 
            this.txtnumext.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtnumext.Location = new System.Drawing.Point(1055, 65);
            this.txtnumext.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumext.Name = "txtnumext";
            this.txtnumext.Size = new System.Drawing.Size(132, 56);
            this.txtnumext.SoloLetras = false;
            this.txtnumext.SoloNumeros = false;
            this.txtnumext.TabIndex = 18;
            this.txtnumext.Validar = true;
            this.txtnumext.VRFC = false;
            this.txtnumext.TextChanged += new System.EventHandler(this.txtnumext_TextChanged);
            this.txtnumext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumext_KeyPress);
            // 
            // txtcalle
            // 
            this.txtcalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtcalle.Location = new System.Drawing.Point(1045, 129);
            this.txtcalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(623, 56);
            this.txtcalle.SoloLetras = true;
            this.txtcalle.SoloNumeros = false;
            this.txtcalle.TabIndex = 22;
            this.txtcalle.Validar = true;
            this.txtcalle.VRFC = false;
            this.txtcalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcalle_KeyPress);
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // txtRFC
            // 
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtRFC.Location = new System.Drawing.Point(300, 258);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(426, 56);
            this.txtRFC.SoloLetras = false;
            this.txtRFC.SoloNumeros = false;
            this.txtRFC.TabIndex = 10;
            this.txtRFC.Validar = false;
            this.txtRFC.VRFC = false;
            // 
            // frmproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 750);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.txtnumext);
            this.Controls.Add(this.txtnumint);
            this.Controls.Add(this.txtcolonia);
            this.Controls.Add(this.txtrazon_social);
            this.Controls.Add(this.txtapellidom);
            this.Controls.Add(this.txtapellidop);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbxregimen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxstatus);
            this.Controls.Add(this.cbxMunicipio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmproveedor";
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmproveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mUNICIPIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIMENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxstatus;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxregimen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PanesitoProveedores panesitoProveedores;
        private System.Windows.Forms.BindingSource pROVEEDORBindingSource;
        private PanesitoProveedoresTableAdapters.PROVEEDORTableAdapter pROVEEDORTableAdapter;
        private panesitoDataSet7 panesitoDataSet7;
        private System.Windows.Forms.BindingSource mUNICIPIOBindingSource;
        private panesitoDataSet7TableAdapters.MUNICIPIOTableAdapter mUNICIPIOTableAdapter;
        private panesitoDataSet8 panesitoDataSet8;
        private System.Windows.Forms.BindingSource rEGIMENBindingSource;
        private panesitoDataSet8TableAdapters.REGIMENTableAdapter rEGIMENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrapellidopatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrapellidomatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrregimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrRFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrrasonsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrtelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrcalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrnuminteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrnumexteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrcoloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdridmunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdrstatusDataGridViewTextBoxColumn;
        private Utilerias.Validacion txttelefono;
        private Utilerias.Validacion txtnombre;
        private Utilerias.Validacion txtapellidop;
        private Utilerias.Validacion txtapellidom;
        private Utilerias.Validacion txtrazon_social;
        private Utilerias.Validacion txtcolonia;
        private Utilerias.Validacion txtnumint;
        private Utilerias.Validacion txtnumext;
        private Utilerias.Validacion txtcalle;
        private System.Windows.Forms.ErrorProvider errorValidacion;
        private Utilerias.Validacion txtRFC;
    }
}