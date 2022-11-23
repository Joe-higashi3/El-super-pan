namespace WindowsFormsApp2
{
    partial class frmpedidos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.dgvarticulos = new System.Windows.Forms.DataGridView();
            this.txtclienteid = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstatus = new WindowsFormsApp2.Utilerias.Validacion();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(94, 81);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(204, 26);
            this.dtpfecha.TabIndex = 38;
            this.dtpfecha.UseWaitCursor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(458, 70);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(133, 29);
            this.btnsalir.TabIndex = 37;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(458, 17);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(133, 29);
            this.btneliminar.TabIndex = 36;
            this.btneliminar.Text = "Deshabilitar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(314, 70);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(133, 29);
            this.btnactualizar.TabIndex = 35;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btninsertar
            // 
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Location = new System.Drawing.Point(314, 17);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(133, 29);
            this.btninsertar.TabIndex = 33;
            this.btninsertar.Text = "Guardar";
            this.btninsertar.UseVisualStyleBackColor = true;
            // 
            // dgvarticulos
            // 
            this.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarticulos.Location = new System.Drawing.Point(29, 165);
            this.dgvarticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.ReadOnly = true;
            this.dgvarticulos.RowTemplate.Height = 24;
            this.dgvarticulos.Size = new System.Drawing.Size(536, 234);
            this.dgvarticulos.TabIndex = 34;
            // 
            // txtclienteid
            // 
            this.txtclienteid.Location = new System.Drawing.Point(94, 51);
            this.txtclienteid.Margin = new System.Windows.Forms.Padding(2);
            this.txtclienteid.Name = "txtclienteid";
            this.txtclienteid.Size = new System.Drawing.Size(204, 20);
            this.txtclienteid.TabIndex = 30;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(94, 17);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(63, 20);
            this.txtid.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Estatus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(242, 17);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(56, 20);
            this.txtstatus.SoloLetras = false;
            this.txtstatus.SoloNumeros = false;
            this.txtstatus.TabIndex = 39;
            this.txtstatus.Validar = true;
            this.txtstatus.VRFC = false;
            this.txtstatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(123, 123);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(175, 20);
            this.txtEmpleado.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Empleado:";
            // 
            // frmpedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.dgvarticulos);
            this.Controls.Add(this.txtclienteid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmpedidos";
            this.Text = "frmpedidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.DataGridView dgvarticulos;
        private System.Windows.Forms.TextBox txtclienteid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Utilerias.Validacion txtstatus;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label3;
    }
}

