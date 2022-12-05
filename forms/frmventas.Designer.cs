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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmventas));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new System.Windows.Forms.Button();
            this.btnquitarproducto = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.btnbuscarpedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpagacon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtcancelar = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtbuscarcliente = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(14, 101);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(515, 573);
            this.dgvVentas.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(637, 101);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(114, 30);
            this.txtCodigo.TabIndex = 61;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Location = new System.Drawing.Point(762, 188);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(190, 39);
            this.btnbuscarproducto.TabIndex = 65;
            this.btnbuscarproducto.Text = "Buscar producto";
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btnquitarproducto
            // 
            this.btnquitarproducto.Location = new System.Drawing.Point(548, 233);
            this.btnquitarproducto.Name = "btnquitarproducto";
            this.btnquitarproducto.Size = new System.Drawing.Size(192, 39);
            this.btnquitarproducto.TabIndex = 64;
            this.btnquitarproducto.Text = "Quitar producto";
            this.btnquitarproducto.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(551, 188);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(190, 39);
            this.btnagregar.TabIndex = 63;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // dtpfecha
            // 
            this.dtpfecha.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(818, 19);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(217, 30);
            this.dtpfecha.TabIndex = 66;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(827, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 39);
            this.button4.TabIndex = 67;
            this.button4.Text = "Añadir a pedido";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnbuscarpedido
            // 
            this.btnbuscarpedido.Location = new System.Drawing.Point(762, 233);
            this.btnbuscarpedido.Name = "btnbuscarpedido";
            this.btnbuscarpedido.Size = new System.Drawing.Size(190, 39);
            this.btnbuscarpedido.TabIndex = 68;
            this.btnbuscarpedido.Text = "Buscar Pedido";
            this.btnbuscarpedido.UseVisualStyleBackColor = true;
            this.btnbuscarpedido.Click += new System.EventHandler(this.btnbuscarpedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(869, 101);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(85, 30);
            this.txtcantidad.TabIndex = 69;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(827, 615);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 39);
            this.button6.TabIndex = 71;
            this.button6.Text = "Realizar Venta";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 629);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Cambio:";
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(653, 626);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(114, 30);
            this.txtcambio.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(681, 137);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(273, 30);
            this.txtDescripcion.TabIndex = 74;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(598, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 233);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(441, 44);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(88, 39);
            this.btnbuscar.TabIndex = 77;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "Paga con:";
            // 
            // txtpagacon
            // 
            this.txtpagacon.Location = new System.Drawing.Point(653, 590);
            this.txtpagacon.Name = "txtpagacon";
            this.txtpagacon.Size = new System.Drawing.Size(114, 30);
            this.txtpagacon.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 81;
            this.label6.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(653, 554);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(114, 30);
            this.txttotal.TabIndex = 80;
            // 
            // txtcancelar
            // 
            this.txtcancelar.Location = new System.Drawing.Point(584, 14);
            this.txtcancelar.Name = "txtcancelar";
            this.txtcancelar.Size = new System.Drawing.Size(114, 30);
            this.txtcancelar.TabIndex = 82;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(704, 10);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(108, 39);
            this.btncancelar.TabIndex = 83;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.Location = new System.Drawing.Point(105, 51);
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(330, 30);
            this.txtbuscarcliente.TabIndex = 84;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 30);
            this.textBox1.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 86;
            this.label7.Text = "Empleado:";
            // 
            // frmventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 688);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbuscarcliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtcancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpagacon);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnbuscarpedido);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnbuscarproducto);
            this.Controls.Add(this.btnquitarproducto);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvVentas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmventas";
            this.Text = "Ventas";
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnbuscarpedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpagacon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtcancelar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtbuscarcliente;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}