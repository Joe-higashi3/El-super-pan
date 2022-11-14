namespace WindowsFormsApp2.forms
{
    partial class frmbuscarproducto1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pridproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarproducto = new WindowsFormsApp2.Buscarproducto();
            this.pRODUCTOTableAdapter = new WindowsFormsApp2.BuscarproductoTableAdapters.PRODUCTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pridproductoDataGridViewTextBoxColumn,
            this.prnombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 302);
            this.dataGridView1.TabIndex = 85;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMBRE.Location = new System.Drawing.Point(133, 59);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(337, 30);
            this.TXTNOMBRE.TabIndex = 83;
            this.TXTNOMBRE.TextChanged += new System.EventHandler(this.TXTNOMBRE_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nombre:";
            // 
            // pridproductoDataGridViewTextBoxColumn
            // 
            this.pridproductoDataGridViewTextBoxColumn.DataPropertyName = "pr_id_producto";
            this.pridproductoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pridproductoDataGridViewTextBoxColumn.Name = "pridproductoDataGridViewTextBoxColumn";
            this.pridproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prnombreDataGridViewTextBoxColumn
            // 
            this.prnombreDataGridViewTextBoxColumn.DataPropertyName = "pr_nombre";
            this.prnombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.prnombreDataGridViewTextBoxColumn.Name = "prnombreDataGridViewTextBoxColumn";
            this.prnombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.buscarproducto;
            // 
            // buscarproducto
            // 
            this.buscarproducto.DataSetName = "Buscarproducto";
            this.buscarproducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // frmbuscarproducto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label2);
            this.Name = "frmbuscarproducto1";
            this.Text = "Buscar Productos";
            this.Load += new System.EventHandler(this.frmbuscarproducto1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Label label2;
        private Buscarproducto buscarproducto;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private BuscarproductoTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnombreDataGridViewTextBoxColumn;
    }
}