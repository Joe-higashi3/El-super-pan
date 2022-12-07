namespace WindowsFormsApp2.forms
{
    partial class frmcompra
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
            this.btnbuscarinsumo = new System.Windows.Forms.Button();
            this.btnquitarinsumo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.btnagregarinsumo = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.mOVINVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSetmovinv = new WindowsFormsApp2.panesitoDataSetmovinv();
            this.dtpfechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoInsumoCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidproveedorCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttipomovimientoCompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtidmovimientoCompra = new System.Windows.Forms.TextBox();
            this.mOV_INVTableAdapter = new WindowsFormsApp2.panesitoDataSetmovinvTableAdapters.MOV_INVTableAdapter();
            this.mid_id_insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mid_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mid_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mid_importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVINVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetmovinv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscarinsumo
            // 
            this.btnbuscarinsumo.Location = new System.Drawing.Point(208, 136);
            this.btnbuscarinsumo.Name = "btnbuscarinsumo";
            this.btnbuscarinsumo.Size = new System.Drawing.Size(190, 39);
            this.btnbuscarinsumo.TabIndex = 71;
            this.btnbuscarinsumo.Text = "Buscar insumo";
            this.btnbuscarinsumo.UseVisualStyleBackColor = true;
            // 
            // btnquitarinsumo
            // 
            this.btnquitarinsumo.Location = new System.Drawing.Point(454, 136);
            this.btnquitarinsumo.Name = "btnquitarinsumo";
            this.btnquitarinsumo.Size = new System.Drawing.Size(192, 39);
            this.btnquitarinsumo.TabIndex = 70;
            this.btnquitarinsumo.Text = "Quitar insumo";
            this.btnquitarinsumo.UseVisualStyleBackColor = true;
            this.btnquitarinsumo.Click += new System.EventHandler(this.btnquitarinsumo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Total:";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Location = new System.Drawing.Point(486, 103);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(114, 20);
            this.txtTotalCompra.TabIndex = 86;
            // 
            // btnagregarinsumo
            // 
            this.btnagregarinsumo.Enabled = false;
            this.btnagregarinsumo.Location = new System.Drawing.Point(708, 136);
            this.btnagregarinsumo.Name = "btnagregarinsumo";
            this.btnagregarinsumo.Size = new System.Drawing.Size(190, 39);
            this.btnagregarinsumo.TabIndex = 88;
            this.btnagregarinsumo.Text = "Agregar Insumo";
            this.btnagregarinsumo.UseVisualStyleBackColor = true;
            this.btnagregarinsumo.Click += new System.EventHandler(this.btnagregarinsumo_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mid_id_insumo,
            this.mid_cantidad,
            this.mid_precio,
            this.mid_importe});
            this.dgvVentas.Location = new System.Drawing.Point(25, 183);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(888, 266);
            this.dgvVentas.TabIndex = 89;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // mOVINVBindingSource
            // 
            this.mOVINVBindingSource.DataMember = "MOV_INV";
            this.mOVINVBindingSource.DataSource = this.panesitoDataSetmovinv;
            // 
            // panesitoDataSetmovinv
            // 
            this.panesitoDataSetmovinv.DataSetName = "panesitoDataSetmovinv";
            this.panesitoDataSetmovinv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpfechaCompra
            // 
            this.dtpfechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaCompra.Location = new System.Drawing.Point(757, 12);
            this.dtpfechaCompra.Name = "dtpfechaCompra";
            this.dtpfechaCompra.Size = new System.Drawing.Size(156, 20);
            this.dtpfechaCompra.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Descripcion:";
            // 
            // txtDescripcionCompra
            // 
            this.txtDescripcionCompra.Location = new System.Drawing.Point(424, 69);
            this.txtDescripcionCompra.Name = "txtDescripcionCompra";
            this.txtDescripcionCompra.Size = new System.Drawing.Size(286, 20);
            this.txtDescripcionCompra.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Cantidad:";
            // 
            // txtCantidadCompra
            // 
            this.txtCantidadCompra.Location = new System.Drawing.Point(794, 69);
            this.txtCantidadCompra.Name = "txtCantidadCompra";
            this.txtCantidadCompra.Size = new System.Drawing.Size(85, 20);
            this.txtCantidadCompra.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Id Insumo:";
            // 
            // txtCodigoInsumoCompra
            // 
            this.txtCodigoInsumoCompra.Location = new System.Drawing.Point(84, 69);
            this.txtCodigoInsumoCompra.Name = "txtCodigoInsumoCompra";
            this.txtCodigoInsumoCompra.Size = new System.Drawing.Size(114, 20);
            this.txtCodigoInsumoCompra.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Precio:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(251, 69);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(85, 20);
            this.txtPrecioCompra.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Id_Proveedor:";
            // 
            // txtidproveedorCompra
            // 
            this.txtidproveedorCompra.Location = new System.Drawing.Point(285, 25);
            this.txtidproveedorCompra.Name = "txtidproveedorCompra";
            this.txtidproveedorCompra.Size = new System.Drawing.Size(85, 20);
            this.txtidproveedorCompra.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "Tipo_Movimiento:";
            // 
            // txttipomovimientoCompra
            // 
            this.txttipomovimientoCompra.Enabled = false;
            this.txttipomovimientoCompra.Location = new System.Drawing.Point(486, 28);
            this.txttipomovimientoCompra.Name = "txttipomovimientoCompra";
            this.txttipomovimientoCompra.Size = new System.Drawing.Size(114, 20);
            this.txttipomovimientoCompra.TabIndex = 103;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "Id Compra:";
            // 
            // txtidmovimientoCompra
            // 
            this.txtidmovimientoCompra.Location = new System.Drawing.Point(84, 25);
            this.txtidmovimientoCompra.Name = "txtidmovimientoCompra";
            this.txtidmovimientoCompra.Size = new System.Drawing.Size(114, 20);
            this.txtidmovimientoCompra.TabIndex = 105;
            // 
            // mOV_INVTableAdapter
            // 
            this.mOV_INVTableAdapter.ClearBeforeFill = true;
            // 
            // mid_id_insumo
            // 
            this.mid_id_insumo.DataPropertyName = "mid_id_insumo";
            this.mid_id_insumo.HeaderText = "mid_id_insumo";
            this.mid_id_insumo.Name = "mid_id_insumo";
            // 
            // mid_cantidad
            // 
            this.mid_cantidad.DataPropertyName = "mid_cantidad";
            this.mid_cantidad.HeaderText = "mid_cantidad";
            this.mid_cantidad.Name = "mid_cantidad";
            // 
            // mid_precio
            // 
            this.mid_precio.DataPropertyName = "mid_precio";
            this.mid_precio.HeaderText = "mid_precio";
            this.mid_precio.Name = "mid_precio";
            // 
            // mid_importe
            // 
            this.mid_importe.DataPropertyName = "mid_importe";
            this.mid_importe.HeaderText = "mid_importe";
            this.mid_importe.Name = "mid_importe";
            this.mid_importe.ReadOnly = true;
            // 
            // frmcompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtidmovimientoCompra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttipomovimientoCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidproveedorCompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcionCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoInsumoCompra);
            this.Controls.Add(this.dtpfechaCompra);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnagregarinsumo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.btnbuscarinsumo);
            this.Controls.Add(this.btnquitarinsumo);
            this.Name = "frmcompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcompra";
            this.Load += new System.EventHandler(this.frmcompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVINVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetmovinv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnbuscarinsumo;
        private System.Windows.Forms.Button btnquitarinsumo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Button btnagregarinsumo;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DateTimePicker dtpfechaCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoInsumoCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtidproveedorCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttipomovimientoCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtidmovimientoCompra;
        private panesitoDataSetmovinv panesitoDataSetmovinv;
        private System.Windows.Forms.BindingSource mOVINVBindingSource;
        private panesitoDataSetmovinvTableAdapters.MOV_INVTableAdapter mOV_INVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mid_id_insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mid_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn mid_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mid_importe;
    }
}