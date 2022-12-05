using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.clases;

namespace WindowsFormsApp2.forms
{
    public partial class frmmovinv : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;

        public frmmovinv()
        {
            InitializeComponent();

        }

        private void frmmovinv_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSetinvdet.MOV_INV_DET' Puede moverla o quitarla según sea necesario.
            this.mOV_INV_DETTableAdapter.Fill(this.panesitoDataSetinvdet.MOV_INV_DET);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet9.MOV_INV_DET' Puede moverla o quitarla según sea necesario.
      //      this.mOV_INV_DETTableAdapter.Fill(this.panesitoDataSet9.MOV_INV_DET);

        }

        private void Guardar()
        {
            clsinvdetalle inventario_detalle = new clsinvdetalle();
            inventario_detalle.iIdmov = Convert.ToInt32(txtid.Text);
    //        inventario_detalle.icantidad = Convert.ToInt32(txtcantidad.Text);
            if (inventario_detalle.Guardar() == true)
            {
                MessageBox.Show("Operacion realizada correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("fallo en la operacion: " + inventario_detalle.error);
            }
        }

        private void limpiar()
        {
            txtid.Clear();
            txtcantidad.Clear();
            txtmonto.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.panesitoDataSetinvdet.MOV_INV_DET [mOVINVDETBindingSource.Position].mid_id_mov.ToString();
            txtcantidad.Text = this.panesitoDataSetinvdet.MOV_INV_DET[mOVINVDETBindingSource.Position].mid_cantidad.ToString();

        }

        private void btnproducir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
