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
            this.ridrecetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txt_nombre = new WindowsFormsApp2.Utilerias.Validacion();
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(315, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Status:";
            // 
            // cmbxstatus
            // 
            this.cmbxstatus.DataSource = this.gRUPOBindingSource;
            this.cmbxstatus.DisplayMember = "g_descripcion";
            this.cmbxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxstatus.FormattingEnabled = true;
            this.cmbxstatus.Location = new System.Drawing.Point(373, 20);
            this.cmbxstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxstatus.Name = "cmbxstatus";
            this.cmbxstatus.Size = new System.Drawing.Size(121, 24);
            this.cmbxstatus.TabIndex = 21;
            this.cmbxstatus.ValueMember = "g_id_grupo";
            // 
            // cbxgrupo
            // 
            this.cbxgrupo.DataSource = this.gRUPOBindingSource;
            this.cbxgrupo.DisplayMember = "g_descripcion";
            this.cbxgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxgrupo.FormattingEnabled = true;
            this.cbxgrupo.Location = new System.Drawing.Point(115, 116);
            this.cbxgrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxgrupo.Name = "cbxgrupo";
            this.cbxgrupo.Size = new System.Drawing.Size(121, 24);
            this.cbxgrupo.TabIndex = 20;
            this.cbxgrupo.ValueMember = "g_id_grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Grupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Receta:";
            // 
            // txtid_receta
            // 
            this.txtid_receta.Location = new System.Drawing.Point(115, 20);
            this.txtid_receta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid_receta.Name = "txtid_receta";
            this.txtid_receta.Size = new System.Drawing.Size(100, 22);
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
            this.rnombreDataGridViewTextBoxColumn,
            this.rgrupoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rECETABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 224);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(992, 247);
            this.dataGridView1.TabIndex = 14;
            // 
            // ridrecetaDataGridViewTextBoxColumn
            // 
            this.ridrecetaDataGridViewTextBoxColumn.DataPropertyName = "r_id_receta";
            this.ridrecetaDataGridViewTextBoxColumn.HeaderText = "ID Receta";
            this.ridrecetaDataGridViewTextBoxColumn.Name = "ridrecetaDataGridViewTextBoxColumn";
            this.ridrecetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rnombreDataGridViewTextBoxColumn
            // 
            this.rnombreDataGridViewTextBoxColumn.DataPropertyName = "r_nombre";
            this.rnombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.rnombreDataGridViewTextBoxColumn.Name = "rnombreDataGridViewTextBoxColumn";
            this.rnombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.rnombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // rgrupoDataGridViewTextBoxColumn
            // 
            this.rgrupoDataGridViewTextBoxColumn.DataPropertyName = "r_grupo";
            this.rgrupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.rgrupoDataGridViewTextBoxColumn.Name = "rgrupoDataGridViewTextBoxColumn";
            this.rgrupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.rgrupoDataGridViewTextBoxColumn.Width = 250;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(703, 150);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(101, 23);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(827, 150);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 23);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(115, 63);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(191, 22);
            this.txt_nombre.SoloLetras = false;
            this.txt_nombre.SoloNumeros = false;
            this.txt_nombre.TabIndex = 23;
            this.txt_nombre.Validar = true;
            this.txt_nombre.VRFC = false;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // frmreceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 490);
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
            this.Controls.Add(this.btncancelar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ridrecetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private Utilerias.Validacion txt_nombre;
    }
}