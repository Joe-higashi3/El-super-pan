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
        string sConexion, articulo;
        public frmventas()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void GuardarVenta()
        {
            clsventa venta = new clsventa();
            venta.iId_cliente = Convert.ToInt32(txtbuscarcliente.Text);
            venta.iId_empleado = Convert.ToInt32(txt.Text);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                // Conexxion , comando y leer son variables "X",les asigno los XXXconection
                //XXXcomand y XXXdatareader
               // objconection = new clases.Conexion();
                conexion = new SqlConnection(clases.Conexion.conn());
                // Se abre la conexion
                conexion.Open();
                // Defino una variable query tipo string
                string lsql = "select * from grupos where Gr_clave=@Gr_clave";
                //asigno a comando el sqlcommand 
                SqlCommand comando = new SqlCommand(lsql, conexion);
                // inicializo cualquier parametro definidoanteriormente
                comando.Parameters.Clear();
                //trensfiero el valor de txtusuario al parametro @us_login que puede ser
                //cualquier variable, pero se recomienda usar el mismo nombre del campo
                comando.Parameters.AddWithValue("@Gr_clave", txtCodigo.Text);
                // Asigno a leer el sqldatareader para leer el registro
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    // lo encontro
                    // paso del campo de la tabla a Variables
                    articulo = leer["Gr_nombre"].ToString();
                    txtCodigo.Text = articulo;
                    // habilita txtclave y manda focus ahí                  
                }
                else
                {
                    //no lo encontro
                    MessageBox.Show("Error: articulo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }
    }
}
