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
using WindowsFormsApp2.busquedas;

namespace WindowsFormsApp2.forms
{
    public partial class frmcompra : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmcompra()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void GuardarCompra()
        {
            clscompra compra = new clscompra();
            compra.iId_movimiento = Convert.ToInt32(txtidmovimientoCompra.Text);
            compra.iId_tipo_movimiento = Convert.ToInt32(txttipomovimientoCompra.Text);
            compra.iId_proveedor = Convert.ToInt32(txtidproveedorCompra.Text);
            //compra.iId_almacen = Convert.ToInt32();
            compra.iId_insumo = Convert.ToInt32(txtCodigoInsumoCompra.Text);
            compra.iCantidad = Convert.ToInt32(txtCantidadCompra.Text);
            compra.fPrecio = float.Parse(txtPrecioCompra.Text);
            compra.fImporte = float.Parse(txtTotalCompra.Text);

            if (compra.GuardarCompra() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + compra.error);

            }

        }

        private void limpiar()
        {
            txtidmovimientoCompra.Clear();
            txttipomovimientoCompra.Clear();
            txtidproveedorCompra.Clear();
            txtCodigoInsumoCompra.Clear();
            txtCantidadCompra.Clear();
            txtPrecioCompra.Clear();
            //
            this.mOV_INVTableAdapter.Fill(this.panesitoDataSetmovinv.MOV_INV);
            //
            txtCodigoInsumoCompra.Focus();
        }


        private void frmcompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSetmovinv.MOV_INV' Puede moverla o quitarla según sea necesario.
            this.mOV_INVTableAdapter.Fill(this.panesitoDataSetmovinv.MOV_INV);

        }

        private void btnrealizarcompra_Click(object sender, EventArgs e)
        {
            GuardarCompra();
            limpiar();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //x2 la fecha donde chuchas va
            txtidmovimientoCompra.Text = this.panesitoDataSetmovinv.MOV_INV[mOVINVBindingSource.Position].m_id_mov.ToString();
            txtidproveedorCompra.Text = this.panesitoDataSetmovinv.MOV_INV[mOVINVBindingSource.Position].m_id_prov.ToString();
            txttipomovimientoCompra.Text = this.panesitoDataSetmovinv.MOV_INV[mOVINVBindingSource.Position].m_tm_id.ToString();
            txtCodigoInsumoCompra.Text = this.panesitoDataSetmovinv.MOV_INV[mOVINVBindingSource.Position].m_ap_id.ToString();
            //descripcion del insumo va o no va aqui es la incognita
            txtPrecioCompra.Text = this.panesitoDataSetmovinv.MOV_INV[mOVINVBindingSource.Position].mid_precio.ToString();
            txtCantidadCompra.Text = this.panesitoDataSetmovinv.MOV_INV[mOVINVBindingSource.Position].mid_cantidad.ToString();
            txtTotalCompra.Text = this.panesitoDataSetmovinv.MOV_INV[mOVINVBindingSource.Position].mid_importe.ToString();

        }
        /*       
            //compra.iId_almacen = Convert.ToInt32();
        */
    }
}
