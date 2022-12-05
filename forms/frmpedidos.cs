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
    public partial class frmpedidos: Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmpedidos()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            frmbusquedaclientes bc = new frmbusquedaclientes();
            bc.ShowDialog();
            if (bc.dgvbusquedacliente.RowCount > 0)
            {
                if (bc.DialogResult == DialogResult.OK)
                {
                    txtbuscarcliente.Text = bc.dsCliente.CLIENTE[bc.cLIENTEBindingSource.Position].Nombre.ToString();
                    txtbuscarclienteid.Text = bc.dsCliente.CLIENTE[bc.cLIENTEBindingSource.Position].cl_id_cliente.ToString();
                }
            }
        }

        private void limpiar()
        {
            txtbuscarcliente.Clear();
            txtbuscarclienteid.Clear();
            txtcancelar.Clear();
            txtcantidad.Clear();
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtid.Clear();
            txtprecio.Clear();
            txttotal.Clear();
        }

        private void GuardarPedido()
        {
            clspedido pedido = new clspedido();
            pedido.iId_pedido = Convert.ToInt32(txtid.Text);
            pedido.iId_cliente = Convert.ToInt32(txtbuscarclienteid);
            pedido.iId_producto = Convert.ToInt32(txtcodigo.Text);
            pedido.f_precio = float.Parse(txtprecio.Text);
            pedido.i_cantidad = Convert.ToInt32(txtcantidad.Text);
            pedido.iId_empleado = 1;
            pedido.bStatus_pedido = Convert.ToBoolean(cmbxstatus.SelectedValue);

            if (pedido.GuardarPedido() == true)
            {
                //MessageBox.Show("Sus Datos se guardaron correctamente");
                txtcodigo.Clear();
                txtdescripcion.Clear();
                txtprecio.Clear();
                txtcantidad.Clear();
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + pedido.error);
            }
        }

        private void EliminarProducto()
        {
            clspedido pedido = new clspedido();
            pedido.iId_pedido = Convert.ToInt32(txtid.Text);
            pedido.iId_cliente = Convert.ToInt32(txtbuscarclienteid);
            pedido.iId_producto = Convert.ToInt32(txtcodigo.Text);
            pedido.f_precio = float.Parse(txtprecio.Text);
            pedido.i_cantidad = Convert.ToInt32(txtcantidad.Text);
            pedido.iId_empleado = 1;
            pedido.bStatus_pedido = Convert.ToBoolean(cmbxstatus.SelectedValue);

            if (pedido.GuardarPedido() == true)
            {
                txtcodigo.Clear();
                txtdescripcion.Clear();
                txtprecio.Clear();
                txtcantidad.Clear();
            }
            else
            {
                MessageBox.Show("Hubo un problema con al eliminar el producto error: " + pedido.error2);

            }
        }

        private void Cancelarpedido()
        {
            clspedido pedido = new clspedido();
            pedido.iId_pedido = Convert.ToInt32(txtid.Text);
            pedido.iId_cliente = Convert.ToInt32(txtbuscarclienteid);
            pedido.iId_producto = Convert.ToInt32(txtcodigo.Text);
            pedido.f_precio = float.Parse(txtprecio.Text);
            pedido.i_cantidad = Convert.ToInt32(txtcantidad.Text);
            pedido.iId_empleado = 1;
            pedido.bStatus_pedido = Convert.ToBoolean(cmbxstatus.SelectedValue);

            if (pedido.CancelarPedido() == true)
            {
                MessageBox.Show("Pedido Cancelado con exito");
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo cancelar el pedido error: " + pedido.error3);
            }
        }

        private void idcorrespondiente()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MAX(pe_id_pedido) AS correspondiente FROM PEDIDO";


            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }


        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            frmbuscarproducto1 bp = new frmbuscarproducto1();
            bp.ShowDialog();
            if (bp.dgvbusquedaproductos.RowCount > 0)
            {
                if (bp.DialogResult == DialogResult.OK)
                {
                    txtcodigo.Text = bp.buscarproducto.PRODUCTO[bp.pRODUCTOBindingSource.Position].pr_id_producto.ToString();
                    txtdescripcion.Text = bp.buscarproducto.PRODUCTO[bp.pRODUCTOBindingSource.Position].pr_descripcion.ToString();
                    txtprecio.Text = bp.buscarproducto.PRODUCTO[bp.pRODUCTOBindingSource.Position].pr_precio.ToString();
                }
            }
        }

        private void btnbuscarpedido_Click(object sender, EventArgs e)
        {

        }

        private void totalmas()
        {
            float precio;
            int cantidad;
            float total;
            precio = float.Parse(txtprecio.Text);
            cantidad = Convert.ToInt32(txtcantidad.Text);
            total = float.Parse(txttotal.Text);
            total = total + (precio * cantidad);
            txttotal.Text = total.ToString();
        }

        private void totalmenos()
        {
            float precio;
            int cantidad;
            float total;
            precio = float.Parse(txtprecio.Text);
            cantidad = Convert.ToInt32(txtcantidad.Text);
            total = float.Parse(txttotal.Text);
            total = total - (precio * cantidad);
            txttotal.Text = total.ToString();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            GuardarPedido();
            totalmas();
            if(txtid.Text == null)
            {
                idcorrespondiente();
            }
        }

        private void btnquitarproducto_Click(object sender, EventArgs e)
        {
            EliminarProducto();
            totalmenos();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Cancelarpedido();
        }

        private void txtcancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                if(txtcancelar.Text=="123456")
                {
                    btncancelar.Enabled = true;
                    btncancelar.Focus();
                }
                else
                {
                    MessageBox.Show("CODIGO INCORRECTO");
                    txtcancelar.Clear();
                    txtcancelar.Focus();
                }
            }
        }
    }
}
