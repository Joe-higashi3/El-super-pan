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

            txtCodigoInsumoCompra.Focus();
        }


        private void frmcompra_Load(object sender, EventArgs e)
        {

        }

        private void btnrealizarcompra_Click(object sender, EventArgs e)
        {
            GuardarCompra();
            limpiar();
        }
    }
}
