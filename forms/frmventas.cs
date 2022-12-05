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
    public partial class frmventas : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmventas()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void GuardarVenta()
        {
            clsventa venta = new clsventa();
            venta.iId_cliente = Convert.ToInt32(.Text);
            venta.iId_empleado = Convert.ToInt32(.Text);
            if (venta.GuardarVenta() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + categoria.error);

            }
        }

        void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            frmbusquedaclientes bc = new frmbusquedaclientes();
            bc.ShowDialog();
            if (bc.dgvbusquedacliente.RowCount > 0)
            {
                if (bc.DialogResult == DialogResult.OK)
                {
                    txtbuscarcliente.Text = bc.dsCliente.CLIENTE[bc.cLIENTEBindingSource.Position].Nombre.ToString();
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            frmbuscarproducto1 bp = new frmbuscarproducto1();
            bp.ShowDialog();
            if(bp.dgvbusquedaproductos.RowCount > 0)
            {
                if(bp.DialogResult == DialogResult.OK)
                {
                    txtCodigo.Text = bp.buscarproducto.PRODUCTO[bp.pRODUCTOBindingSource.Position].pr_id_producto.ToString();
                    txtDescripcion.Text = bp.buscarproducto.PRODUCTO[bp.pRODUCTOBindingSource.Position].pr_descripcion.ToString();
                }
            }
        }

        private void btnbuscarpedido_Click(object sender, EventArgs e)
        {
            frmbusquedapedidos bpd = new frmbusquedapedidos();
            bpd.ShowDialog();
        }

        private void frmventas_Load(object sender, EventArgs e)
        {

        }
    }
}
