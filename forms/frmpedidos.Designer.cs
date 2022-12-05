namespace WindowsFormsApp2.forms
{
    partial class frmpedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpedidos));
            this.txtbuscarcliente = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtcancelar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnbuscarpedido = new System.Windows.Forms.Button();
            this.btnpedido = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btnbuscarproducto = new System.Windows.Forms.Button();
            this.btnquitarproducto = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvpedidos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtbuscarclienteid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxstatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.Location = new System.Drawing.Point(182, 64);
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(264, 30);
            this.txtbuscarcliente.TabIndex = 110;
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(715, 23);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(108, 39);
            this.btncancelar.TabIndex = 109;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtcancelar
            // 
            this.txtcancelar.Location = new System.Drawing.Point(595, 27);
            this.txtcancelar.Name = "txtcancelar";
            this.txtcancelar.Size = new System.Drawing.Size(114, 30);
            this.txtcancelar.TabIndex = 108;
            this.txtcancelar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcancelar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 107;
            this.label6.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(648, 628);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(114, 30);
            this.txttotal.TabIndex = 106;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Location = new System.Drawing.Point(452, 60);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(88, 39);
            this.btnbuscarcliente.TabIndex = 103;
            this.btnbuscarcliente.Text = "Buscar";
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(666, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 233);
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 101;
            this.label4.Text = "Descripcion:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(692, 150);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(354, 30);
            this.txtdescripcion.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(828, 112);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(46, 30);
            this.txtcantidad.TabIndex = 95;
            // 
            // btnbuscarpedido
            // 
            this.btnbuscarpedido.Location = new System.Drawing.Point(773, 246);
            this.btnbuscarpedido.Name = "btnbuscarpedido";
            this.btnbuscarpedido.Size = new System.Drawing.Size(190, 39);
            this.btnbuscarpedido.TabIndex = 94;
            this.btnbuscarpedido.Text = "Buscar Pedido";
            this.btnbuscarpedido.UseVisualStyleBackColor = true;
            this.btnbuscarpedido.Click += new System.EventHandler(this.btnbuscarpedido_Click);
            // 
            // btnpedido
            // 
            this.btnpedido.Location = new System.Drawing.Point(856, 628);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(190, 39);
            this.btnpedido.TabIndex = 93;
            this.btnpedido.Text = "Añadir a pedido";
            this.btnpedido.UseVisualStyleBackColor = true;
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(841, 25);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(217, 30);
            this.dtpfecha.TabIndex = 92;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Location = new System.Drawing.Point(773, 201);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(190, 39);
            this.btnbuscarproducto.TabIndex = 91;
            this.btnbuscarproducto.Text = "Buscar producto";
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btnquitarproducto
            // 
            this.btnquitarproducto.Location = new System.Drawing.Point(559, 246);
            this.btnquitarproducto.Name = "btnquitarproducto";
            this.btnquitarproducto.Size = new System.Drawing.Size(192, 39);
            this.btnquitarproducto.TabIndex = 90;
            this.btnquitarproducto.Text = "Quitar producto";
            this.btnquitarproducto.UseVisualStyleBackColor = true;
            this.btnquitarproducto.Click += new System.EventHandler(this.btnquitarproducto_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(562, 201);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(190, 39);
            this.btnagregar.TabIndex = 89;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(648, 114);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(61, 30);
            this.txtcodigo.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 86;
            this.label9.Text = "Cliente:";
            // 
            // dgvpedidos
            // 
            this.dgvpedidos.AllowUserToAddRows = false;
            this.dgvpedidos.AllowUserToDeleteRows = false;
            this.dgvpedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedidos.Location = new System.Drawing.Point(25, 114);
            this.dgvpedidos.Margin = new System.Windows.Forms.Padding(5);
            this.dgvpedidos.Name = "dgvpedidos";
            this.dgvpedidos.ReadOnly = true;
            this.dgvpedidos.RowTemplate.Height = 24;
            this.dgvpedidos.Size = new System.Drawing.Size(515, 573);
            this.dgvpedidos.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(880, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 111;
            this.label7.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(966, 114);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(80, 30);
            this.txtprecio.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 113;
            this.label8.Text = "Id Pedido:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(136, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(69, 30);
            this.txtid.TabIndex = 114;
            // 
            // txtbuscarclienteid
            // 
            this.txtbuscarclienteid.Location = new System.Drawing.Point(113, 64);
            this.txtbuscarclienteid.Name = "txtbuscarclienteid";
            this.txtbuscarclienteid.Size = new System.Drawing.Size(63, 30);
            this.txtbuscarclienteid.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 116;
            this.label3.Text = "Status:";
            // 
            // cmbxstatus
            // 
            this.cmbxstatus.FormattingEnabled = true;
            this.cmbxstatus.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.cmbxstatus.Location = new System.Drawing.Point(298, 17);
            this.cmbxstatus.Name = "cmbxstatus";
            this.cmbxstatus.Size = new System.Drawing.Size(148, 33);
            this.cmbxstatus.TabIndex = 117;
            // 
            // frmpedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 710);
            this.Controls.Add(this.cmbxstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbuscarclienteid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbuscarcliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtcancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnbuscarpedido);
            this.Controls.Add(this.btnpedido);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnbuscarproducto);
            this.Controls.Add(this.btnquitarproducto);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvpedidos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmpedidos";
            this.Text = "frmpedidos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbuscarcliente;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtcancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnbuscarpedido;
        private System.Windows.Forms.Button btnpedido;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Button btnbuscarproducto;
        private System.Windows.Forms.Button btnquitarproducto;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvpedidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtbuscarclienteid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxstatus;
    }
}