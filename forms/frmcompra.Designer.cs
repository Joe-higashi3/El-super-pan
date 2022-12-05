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
            this.btnbuscarinsumo = new System.Windows.Forms.Button();
            this.btnquitarinsumo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPagaconCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCambioCompra = new System.Windows.Forms.TextBox();
            this.btnrealizarcompra = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscarinsumo
            // 
            this.btnbuscarinsumo.Location = new System.Drawing.Point(505, 243);
            this.btnbuscarinsumo.Name = "btnbuscarinsumo";
            this.btnbuscarinsumo.Size = new System.Drawing.Size(190, 39);
            this.btnbuscarinsumo.TabIndex = 71;
            this.btnbuscarinsumo.Text = "Buscar insumo";
            this.btnbuscarinsumo.UseVisualStyleBackColor = true;
            // 
            // btnquitarinsumo
            // 
            this.btnquitarinsumo.Location = new System.Drawing.Point(721, 243);
            this.btnquitarinsumo.Name = "btnquitarinsumo";
            this.btnquitarinsumo.Size = new System.Drawing.Size(192, 39);
            this.btnquitarinsumo.TabIndex = 70;
            this.btnquitarinsumo.Text = "Quitar insumo";
            this.btnquitarinsumo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Total:";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Location = new System.Drawing.Point(562, 303);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(114, 20);
            this.txtTotalCompra.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Paga con:";
            // 
            // txtPagaconCompra
            // 
            this.txtPagaconCompra.Location = new System.Drawing.Point(562, 336);
            this.txtPagaconCompra.Name = "txtPagaconCompra";
            this.txtPagaconCompra.Size = new System.Drawing.Size(114, 20);
            this.txtPagaconCompra.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Cambio:";
            // 
            // txtCambioCompra
            // 
            this.txtCambioCompra.Location = new System.Drawing.Point(562, 372);
            this.txtCambioCompra.Name = "txtCambioCompra";
            this.txtCambioCompra.Size = new System.Drawing.Size(114, 20);
            this.txtCambioCompra.TabIndex = 82;
            // 
            // btnrealizarcompra
            // 
            this.btnrealizarcompra.Enabled = false;
            this.btnrealizarcompra.Location = new System.Drawing.Point(721, 326);
            this.btnrealizarcompra.Name = "btnrealizarcompra";
            this.btnrealizarcompra.Size = new System.Drawing.Size(190, 39);
            this.btnrealizarcompra.TabIndex = 88;
            this.btnrealizarcompra.Text = "Realizar Compra";
            this.btnrealizarcompra.UseVisualStyleBackColor = true;
            this.btnrealizarcompra.Click += new System.EventHandler(this.btnrealizarcompra_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(-3, 52);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(495, 384);
            this.dgvVentas.TabIndex = 89;
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
            this.label4.Location = new System.Drawing.Point(503, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Descripcion:";
            // 
            // txtDescripcionCompra
            // 
            this.txtDescripcionCompra.Location = new System.Drawing.Point(575, 176);
            this.txtDescripcionCompra.Name = "txtDescripcionCompra";
            this.txtDescripcionCompra.Size = new System.Drawing.Size(286, 20);
            this.txtDescripcionCompra.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Cantidad:";
            // 
            // txtCantidadCompra
            // 
            this.txtCantidadCompra.Location = new System.Drawing.Point(776, 208);
            this.txtCantidadCompra.Name = "txtCantidadCompra";
            this.txtCantidadCompra.Size = new System.Drawing.Size(85, 20);
            this.txtCantidadCompra.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Id Insumo:";
            // 
            // txtCodigoInsumoCompra
            // 
            this.txtCodigoInsumoCompra.Location = new System.Drawing.Point(575, 144);
            this.txtCodigoInsumoCompra.Name = "txtCodigoInsumoCompra";
            this.txtCodigoInsumoCompra.Size = new System.Drawing.Size(114, 20);
            this.txtCodigoInsumoCompra.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Precio:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(776, 144);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(85, 20);
            this.txtPrecioCompra.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(696, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Id_Proveedor:";
            // 
            // txtidproveedorCompra
            // 
            this.txtidproveedorCompra.Location = new System.Drawing.Point(776, 65);
            this.txtidproveedorCompra.Name = "txtidproveedorCompra";
            this.txtidproveedorCompra.Size = new System.Drawing.Size(85, 20);
            this.txtidproveedorCompra.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "Tipo_Movimiento:";
            // 
            // txttipomovimientoCompra
            // 
            this.txttipomovimientoCompra.Enabled = false;
            this.txttipomovimientoCompra.Location = new System.Drawing.Point(656, 99);
            this.txttipomovimientoCompra.Name = "txttipomovimientoCompra";
            this.txttipomovimientoCompra.Size = new System.Drawing.Size(114, 20);
            this.txttipomovimientoCompra.TabIndex = 103;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "Id Compra:";
            // 
            // txtidmovimientoCompra
            // 
            this.txtidmovimientoCompra.Location = new System.Drawing.Point(575, 65);
            this.txtidmovimientoCompra.Name = "txtidmovimientoCompra";
            this.txtidmovimientoCompra.Size = new System.Drawing.Size(114, 20);
            this.txtidmovimientoCompra.TabIndex = 105;
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
            this.Controls.Add(this.btnrealizarcompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPagaconCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCambioCompra);
            this.Controls.Add(this.btnbuscarinsumo);
            this.Controls.Add(this.btnquitarinsumo);
            this.Name = "frmcompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcompra";
            this.Load += new System.EventHandler(this.frmcompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnbuscarinsumo;
        private System.Windows.Forms.Button btnquitarinsumo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPagaconCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCambioCompra;
        private System.Windows.Forms.Button btnrealizarcompra;
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
    }
}