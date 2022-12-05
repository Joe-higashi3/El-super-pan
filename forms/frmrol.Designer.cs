namespace WindowsFormsApp2.forms
{
    partial class frmrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrol));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panesitorol = new WindowsFormsApp2.panesitorol();
            this.rOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOLTableAdapter = new WindowsFormsApp2.panesitorolTableAdapters.ROLTableAdapter();
            this.dgvrol = new System.Windows.Forms.DataGridView();
            this.ridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panesitorol1 = new WindowsFormsApp2.panesitorol1();
            this.rOLTableAdapter1 = new WindowsFormsApp2.panesitorol1TableAdapters.ROLTableAdapter();
            this.errorValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.txttipo = new WindowsFormsApp2.Utilerias.Validacion();
            ((System.ComponentModel.ISupportInitialize)(this.panesitorol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitorol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(664, 160);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(155, 39);
            this.btncancelar.TabIndex = 50;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(487, 160);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(155, 39);
            this.btnguardar.TabIndex = 49;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(316, 55);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(63, 30);
            this.txtid.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tipo De Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID:";
            // 
            // panesitorol
            // 
            this.panesitorol.DataSetName = "panesitorol";
            this.panesitorol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOLBindingSource
            // 
            this.rOLBindingSource.DataMember = "ROL";
            this.rOLBindingSource.DataSource = this.panesitorol;
            // 
            // rOLTableAdapter
            // 
            this.rOLTableAdapter.ClearBeforeFill = true;
            // 
            // dgvrol
            // 
            this.dgvrol.AllowUserToAddRows = false;
            this.dgvrol.AllowUserToDeleteRows = false;
            this.dgvrol.AutoGenerateColumns = false;
            this.dgvrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ridDataGridViewTextBoxColumn,
            this.rtipoDataGridViewTextBoxColumn});
            this.dgvrol.DataSource = this.rOLBindingSource1;
            this.dgvrol.Location = new System.Drawing.Point(176, 222);
            this.dgvrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvrol.Name = "dgvrol";
            this.dgvrol.ReadOnly = true;
            this.dgvrol.RowTemplate.Height = 24;
            this.dgvrol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrol.Size = new System.Drawing.Size(643, 198);
            this.dgvrol.TabIndex = 54;
            this.dgvrol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrol_CellContentClick);
            // 
            // ridDataGridViewTextBoxColumn
            // 
            this.ridDataGridViewTextBoxColumn.DataPropertyName = "r_id";
            this.ridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ridDataGridViewTextBoxColumn.Name = "ridDataGridViewTextBoxColumn";
            this.ridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rtipoDataGridViewTextBoxColumn
            // 
            this.rtipoDataGridViewTextBoxColumn.DataPropertyName = "r_tipo";
            this.rtipoDataGridViewTextBoxColumn.HeaderText = "TIPO DE ROL";
            this.rtipoDataGridViewTextBoxColumn.Name = "rtipoDataGridViewTextBoxColumn";
            this.rtipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.rtipoDataGridViewTextBoxColumn.Width = 500;
            // 
            // rOLBindingSource1
            // 
            this.rOLBindingSource1.DataMember = "ROL";
            this.rOLBindingSource1.DataSource = this.panesitorol1;
            // 
            // panesitorol1
            // 
            this.panesitorol1.DataSetName = "panesitorol1";
            this.panesitorol1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOLTableAdapter1
            // 
            this.rOLTableAdapter1.ClearBeforeFill = true;
            // 
            // errorValidar
            // 
            this.errorValidar.ContainerControl = this;
            this.errorValidar.Icon = ((System.Drawing.Icon)(resources.GetObject("errorValidar.Icon")));
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.Location = new System.Drawing.Point(316, 104);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(208, 30);
            this.txttipo.SoloLetras = true;
            this.txttipo.SoloNumeros = false;
            this.txttipo.TabIndex = 55;
            this.txttipo.Validar = true;
            this.txttipo.VRFC = false;
            // 
            // frmrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.dgvrol);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmrol";
            this.Text = "frmrol";
            this.Load += new System.EventHandler(this.frmrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panesitorol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitorol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private panesitorol panesitorol;
        private System.Windows.Forms.BindingSource rOLBindingSource;
        private panesitorolTableAdapters.ROLTableAdapter rOLTableAdapter;
        private System.Windows.Forms.DataGridView dgvrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtipoDataGridViewTextBoxColumn;
        private panesitorol1 panesitorol1;
        private System.Windows.Forms.BindingSource rOLBindingSource1;
        private panesitorol1TableAdapters.ROLTableAdapter rOLTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorValidar;
        private System.Windows.Forms.ErrorProvider errorValidacion;
        private Utilerias.Validacion txttipo;
    }
}