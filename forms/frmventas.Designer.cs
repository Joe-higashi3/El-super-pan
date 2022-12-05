namespace WindowsFormsApp2.forms
{
    partial class frmventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmventas));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new System.Windows.Forms.Button();
            this.btnquitarproducto = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btnbuscarpedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpagacon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtcancelar = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtbuscarcliente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(20, 116);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(721, 659);
            this.dgvVentas.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 59;
            this.label9.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(915, 116);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(158, 32);
            this.txtCodigo.TabIndex = 61;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Location = new System.Drawing.Point(1066, 217);
            this.btnbuscarproducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(266, 45);
            this.btnbuscarproducto.TabIndex = 65;
            this.btnbuscarproducto.Text = "Buscar producto";
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btnquitarproducto
            // 
            this.btnquitarproducto.Location = new System.Drawing.Point(768, 268);
            this.btnquitarproducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnquitarproducto.Name = "btnquitarproducto";
            this.btnquitarproducto.Size = new System.Drawing.Size(268, 45);
            this.btnquitarproducto.TabIndex = 64;
            this.btnquitarproducto.Text = "Quitar producto";
            this.btnquitarproducto.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(771, 217);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(266, 45);
            this.btnagregar.TabIndex = 63;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(1148, 13);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(216, 32);
            this.dtpfecha.TabIndex = 66;
            // 
            // btnbuscarpedido
            // 
            this.btnbuscarpedido.Location = new System.Drawing.Point(1066, 268);
            this.btnbuscarpedido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnbuscarpedido.Name = "btnbuscarpedido";
            this.btnbuscarpedido.Size = new System.Drawing.Size(266, 45);
            this.btnbuscarpedido.TabIndex = 68;
            this.btnbuscarpedido.Text = "Buscar Pedido";
            this.btnbuscarpedido.UseVisualStyleBackColor = true;
            this.btnbuscarpedido.Click += new System.EventHandler(this.btnbuscarpedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1087, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 70;
            this.label2.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(1217, 116);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(117, 32);
            this.txtcantidad.TabIndex = 69;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1140, 672);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(266, 45);
            this.button6.TabIndex = 71;
            this.button6.Text = "Realizar Venta";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 724);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 73;
            this.label3.Text = "Cambio:";
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(915, 720);
            this.txtcambio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(158, 32);
            this.txtcambio.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(761, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 75;
            this.label4.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(919, 157);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(415, 32);
            this.txtDescripcion.TabIndex = 74;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(617, 51);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(124, 45);
            this.btnbuscar.TabIndex = 77;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(755, 678);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 79;
            this.label5.Text = "Paga con:";
            // 
            // txtpagacon
            // 
            this.txtpagacon.Location = new System.Drawing.Point(915, 678);
            this.txtpagacon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpagacon.Name = "txtpagacon";
            this.txtpagacon.Size = new System.Drawing.Size(158, 32);
            this.txtpagacon.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(811, 640);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 81;
            this.label6.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(915, 637);
            this.txttotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(158, 32);
            this.txttotal.TabIndex = 80;
            // 
            // txtcancelar
            // 
            this.txtcancelar.Location = new System.Drawing.Point(818, 16);
            this.txtcancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtcancelar.Name = "txtcancelar";
            this.txtcancelar.Size = new System.Drawing.Size(158, 32);
            this.txtcancelar.TabIndex = 82;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(986, 11);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(152, 45);
            this.btncancelar.TabIndex = 83;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.Location = new System.Drawing.Point(147, 58);
            this.txtbuscarcliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(460, 32);
            this.txtbuscarcliente.TabIndex = 84;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(800, 346);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(18)))));
            this.label7.Location = new System.Drawing.Point(37, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 86;
            this.label7.Text = "Folio:";
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(147, 18);
            this.txtfolio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(235, 32);
            this.txtfolio.TabIndex = 87;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(414, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 31);
            this.comboBox1.TabIndex = 88;
            // 
            // frmventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1370, 718);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtfolio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbuscarcliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtcancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpagacon);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnbuscarpedido);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnbuscarproducto);
            this.Controls.Add(this.btnquitarproducto);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvVentas);
            this.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(18)))));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmventas";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnbuscarproducto;
        private System.Windows.Forms.Button btnquitarproducto;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Button btnbuscarpedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpagacon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtcancelar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtbuscarcliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}