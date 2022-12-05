
namespace WindowsFormsApp2.busquedas
{
    partial class frmbusquedainsumo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inidinsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSUMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarInsumo = new WindowsFormsApp2.BuscarInsumo();
            this.iNSUMOTableAdapter = new WindowsFormsApp2.BuscarInsumoTableAdapters.INSUMOTableAdapter();
            this.txtinsumo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inidinsumoDataGridViewTextBoxColumn,
            this.innombreDataGridViewTextBoxColumn,
            this.un_descripcion,
            this.instatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iNSUMOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 189);
            this.dataGridView1.TabIndex = 2;
            // 
            // inidinsumoDataGridViewTextBoxColumn
            // 
            this.inidinsumoDataGridViewTextBoxColumn.DataPropertyName = "in_id_insumo";
            this.inidinsumoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.inidinsumoDataGridViewTextBoxColumn.Name = "inidinsumoDataGridViewTextBoxColumn";
            // 
            // innombreDataGridViewTextBoxColumn
            // 
            this.innombreDataGridViewTextBoxColumn.DataPropertyName = "in_nombre";
            this.innombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.innombreDataGridViewTextBoxColumn.Name = "innombreDataGridViewTextBoxColumn";
            // 
            // un_descripcion
            // 
            this.un_descripcion.DataPropertyName = "un_descripcion";
            this.un_descripcion.HeaderText = "UNIDAD";
            this.un_descripcion.Name = "un_descripcion";
            // 
            // instatusDataGridViewTextBoxColumn
            // 
            this.instatusDataGridViewTextBoxColumn.DataPropertyName = "in_status";
            this.instatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.instatusDataGridViewTextBoxColumn.Name = "instatusDataGridViewTextBoxColumn";
            // 
            // iNSUMOBindingSource
            // 
            this.iNSUMOBindingSource.DataMember = "INSUMO";
            this.iNSUMOBindingSource.DataSource = this.buscarInsumo;
            // 
            // buscarInsumo
            // 
            this.buscarInsumo.DataSetName = "BuscarInsumo";
            this.buscarInsumo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNSUMOTableAdapter
            // 
            this.iNSUMOTableAdapter.ClearBeforeFill = true;
            // 
            // txtinsumo
            // 
            this.txtinsumo.Location = new System.Drawing.Point(113, 41);
            this.txtinsumo.Name = "txtinsumo";
            this.txtinsumo.Size = new System.Drawing.Size(108, 20);
            this.txtinsumo.TabIndex = 3;
            this.txtinsumo.TextChanged += new System.EventHandler(this.txtinsumo_TextChanged);
            // 
            // frmbusquedainsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 331);
            this.Controls.Add(this.txtinsumo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmbusquedainsumo";
            this.Text = "Busqueda Insumo";
            this.Load += new System.EventHandler(this.frmbusquedainsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarInsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BuscarInsumo buscarInsumo;
        private System.Windows.Forms.BindingSource iNSUMOBindingSource;
        private BuscarInsumoTableAdapters.INSUMOTableAdapter iNSUMOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inidinsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn un_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn instatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtinsumo;
    }
}