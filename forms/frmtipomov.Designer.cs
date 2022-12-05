namespace WindowsFormsApp2.forms
{
    partial class frmtipomov
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvtm = new System.Windows.Forms.DataGridView();
            this.tmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOMOVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoTipomov = new WindowsFormsApp2.panesitoTipomov();
            this.txtidtm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.tIPO_MOVTableAdapter = new WindowsFormsApp2.panesitoTipomovTableAdapters.TIPO_MOVTableAdapter();
            this.txttm = new WindowsFormsApp2.Utilerias.Validacion();
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOMOVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoTipomov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(912, 165);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 28);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo:";
            // 
            // dgvtm
            // 
            this.dgvtm.AllowUserToAddRows = false;
            this.dgvtm.AllowUserToDeleteRows = false;
            this.dgvtm.AutoGenerateColumns = false;
            this.dgvtm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tmidDataGridViewTextBoxColumn,
            this.tmtipoDataGridViewTextBoxColumn});
            this.dgvtm.DataSource = this.tIPOMOVBindingSource;
            this.dgvtm.Location = new System.Drawing.Point(55, 235);
            this.dgvtm.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtm.Name = "dgvtm";
            this.dgvtm.ReadOnly = true;
            this.dgvtm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtm.Size = new System.Drawing.Size(957, 257);
            this.dgvtm.TabIndex = 10;
            this.dgvtm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtm_CellContentClick);
            // 
            // tmidDataGridViewTextBoxColumn
            // 
            this.tmidDataGridViewTextBoxColumn.DataPropertyName = "tm_id";
            this.tmidDataGridViewTextBoxColumn.HeaderText = "tm_id";
            this.tmidDataGridViewTextBoxColumn.Name = "tmidDataGridViewTextBoxColumn";
            this.tmidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tmtipoDataGridViewTextBoxColumn
            // 
            this.tmtipoDataGridViewTextBoxColumn.DataPropertyName = "tm_tipo";
            this.tmtipoDataGridViewTextBoxColumn.HeaderText = "tm_tipo";
            this.tmtipoDataGridViewTextBoxColumn.Name = "tmtipoDataGridViewTextBoxColumn";
            this.tmtipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOMOVBindingSource
            // 
            this.tIPOMOVBindingSource.DataMember = "TIPO_MOV";
            this.tIPOMOVBindingSource.DataSource = this.panesitoTipomov;
            // 
            // panesitoTipomov
            // 
            this.panesitoTipomov.DataSetName = "panesitoTipomov";
            this.panesitoTipomov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtidtm
            // 
            this.txtidtm.Enabled = false;
            this.txtidtm.Location = new System.Drawing.Point(120, 62);
            this.txtidtm.Margin = new System.Windows.Forms.Padding(4);
            this.txtidtm.Name = "txtidtm";
            this.txtidtm.Size = new System.Drawing.Size(132, 22);
            this.txtidtm.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(756, 165);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 28);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // tIPO_MOVTableAdapter
            // 
            this.tIPO_MOVTableAdapter.ClearBeforeFill = true;
            // 
            // txttm
            // 
            this.txttm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttm.Location = new System.Drawing.Point(120, 126);
            this.txttm.Margin = new System.Windows.Forms.Padding(4);
            this.txttm.Name = "txttm";
            this.txttm.Size = new System.Drawing.Size(224, 22);
            this.txttm.SoloLetras = false;
            this.txttm.SoloNumeros = false;
            this.txttm.TabIndex = 14;
            this.txttm.Validar = true;
            this.txttm.VRFC = false;
            this.txttm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttm_KeyPress);
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // frmtipomov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txttm);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvtm);
            this.Controls.Add(this.txtidtm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmtipomov";
            this.Text = "frmtipomov";
            this.Load += new System.EventHandler(this.frmtipomov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOMOVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoTipomov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvtm;
        private System.Windows.Forms.TextBox txtidtm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private panesitoTipomov panesitoTipomov;
        private System.Windows.Forms.BindingSource tIPOMOVBindingSource;
        private panesitoTipomovTableAdapters.TIPO_MOVTableAdapter tIPO_MOVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmtipoDataGridViewTextBoxColumn;
        private Utilerias.Validacion txttm;
        private System.Windows.Forms.ErrorProvider errorValidacion;
    }
}