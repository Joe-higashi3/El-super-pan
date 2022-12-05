namespace WindowsFormsApp2.forms
{
    partial class frmmovinv
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.panesitoDataSetinvdet = new WindowsFormsApp2.panesitoDataSetinvdet();
            this.mOVINVDETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOV_INV_DETTableAdapter = new WindowsFormsApp2.panesitoDataSetinvdetTableAdapters.MOV_INV_DETTableAdapter();
            this.btnproducir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.midimporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midprecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midcantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mididtipomovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mididproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mididinsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mididmovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetinvdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVINVDETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(106, 9);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(92, 24);
            this.txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.AllowUserToDeleteRows = false;
            this.dgvdetalle.AutoGenerateColumns = false;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mididmovDataGridViewTextBoxColumn,
            this.mididinsumoDataGridViewTextBoxColumn,
            this.mididproductoDataGridViewTextBoxColumn,
            this.mididtipomovDataGridViewTextBoxColumn,
            this.midcantidadDataGridViewTextBoxColumn,
            this.midprecioDataGridViewTextBoxColumn,
            this.midimporteDataGridViewTextBoxColumn});
            this.dgvdetalle.DataSource = this.mOVINVDETBindingSource;
            this.dgvdetalle.Location = new System.Drawing.Point(12, 147);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.ReadOnly = true;
            this.dgvdetalle.Size = new System.Drawing.Size(751, 285);
            this.dgvdetalle.TabIndex = 4;
            this.dgvdetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panesitoDataSetinvdet
            // 
            this.panesitoDataSetinvdet.DataSetName = "panesitoDataSetinvdet";
            this.panesitoDataSetinvdet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVINVDETBindingSource
            // 
            this.mOVINVDETBindingSource.DataMember = "MOV_INV_DET";
            this.mOVINVDETBindingSource.DataSource = this.panesitoDataSetinvdet;
            // 
            // mOV_INV_DETTableAdapter
            // 
            this.mOV_INV_DETTableAdapter.ClearBeforeFill = true;
            // 
            // btnproducir
            // 
            this.btnproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducir.Location = new System.Drawing.Point(665, 12);
            this.btnproducir.Name = "btnproducir";
            this.btnproducir.Size = new System.Drawing.Size(98, 30);
            this.btnproducir.TabIndex = 5;
            this.btnproducir.Text = "Producir";
            this.btnproducir.UseVisualStyleBackColor = true;
            this.btnproducir.Click += new System.EventHandler(this.btnproducir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // midimporteDataGridViewTextBoxColumn
            // 
            this.midimporteDataGridViewTextBoxColumn.DataPropertyName = "mid_importe";
            this.midimporteDataGridViewTextBoxColumn.HeaderText = "IMPORTE";
            this.midimporteDataGridViewTextBoxColumn.Name = "midimporteDataGridViewTextBoxColumn";
            this.midimporteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // midprecioDataGridViewTextBoxColumn
            // 
            this.midprecioDataGridViewTextBoxColumn.DataPropertyName = "mid_precio";
            this.midprecioDataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.midprecioDataGridViewTextBoxColumn.Name = "midprecioDataGridViewTextBoxColumn";
            this.midprecioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // midcantidadDataGridViewTextBoxColumn
            // 
            this.midcantidadDataGridViewTextBoxColumn.DataPropertyName = "mid_cantidad";
            this.midcantidadDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.midcantidadDataGridViewTextBoxColumn.Name = "midcantidadDataGridViewTextBoxColumn";
            this.midcantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mididtipomovDataGridViewTextBoxColumn
            // 
            this.mididtipomovDataGridViewTextBoxColumn.DataPropertyName = "mid_id_tipo_mov";
            this.mididtipomovDataGridViewTextBoxColumn.HeaderText = "ID TIPO DE MOV";
            this.mididtipomovDataGridViewTextBoxColumn.Name = "mididtipomovDataGridViewTextBoxColumn";
            this.mididtipomovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mididproductoDataGridViewTextBoxColumn
            // 
            this.mididproductoDataGridViewTextBoxColumn.DataPropertyName = "mid_id_producto";
            this.mididproductoDataGridViewTextBoxColumn.HeaderText = "ID PRODUCTO";
            this.mididproductoDataGridViewTextBoxColumn.Name = "mididproductoDataGridViewTextBoxColumn";
            this.mididproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mididinsumoDataGridViewTextBoxColumn
            // 
            this.mididinsumoDataGridViewTextBoxColumn.DataPropertyName = "mid_id_insumo";
            this.mididinsumoDataGridViewTextBoxColumn.HeaderText = "ID INSUMO";
            this.mididinsumoDataGridViewTextBoxColumn.Name = "mididinsumoDataGridViewTextBoxColumn";
            this.mididinsumoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mididmovDataGridViewTextBoxColumn
            // 
            this.mididmovDataGridViewTextBoxColumn.DataPropertyName = "mid_id_mov";
            this.mididmovDataGridViewTextBoxColumn.HeaderText = "ID MOV";
            this.mididmovDataGridViewTextBoxColumn.Name = "mididmovDataGridViewTextBoxColumn";
            this.mididmovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(109, 102);
            this.txtmonto.Multiline = true;
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(92, 29);
            this.txtmonto.TabIndex = 8;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(109, 55);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(92, 29);
            this.txtcantidad.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // frmmovinv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 444);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnproducir);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Name = "frmmovinv";
            this.Text = "frmMovInventario";
            this.Load += new System.EventHandler(this.frmmovinv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetinvdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVINVDETBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private panesitoDataSetinvdet panesitoDataSetinvdet;
        private System.Windows.Forms.BindingSource mOVINVDETBindingSource;
        private panesitoDataSetinvdetTableAdapters.MOV_INV_DETTableAdapter mOV_INV_DETTableAdapter;
        private System.Windows.Forms.Button btnproducir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mididmovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mididinsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mididproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mididtipomovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midcantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midprecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midimporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}