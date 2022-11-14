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
    public partial class frmalmacen : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmalmacen()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void frmalmacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panesitoAlmacen.ALMACEN_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.aLMACEN_PRODUCTOTableAdapter.Fill(this.panesitoAlmacen.ALMACEN_PRODUCTO);
            txtnombre.Focus();
            consecutivo();
        }
        private void GuardarAlmacen()
        {
            clsalmacen almacen = new clsalmacen();
            almacen.iIdAlmacen = Convert.ToInt32(txtid.Text);
            almacen.sNombre = txtnombre.Text;
            if (almacen.Guardar() == true)
            {
                MessageBox.Show("Datos Guardados correctamente");
                limpiar();

            }
            else
            {
                MessageBox.Show("Sus datos no se pudieron guardar: " + almacen.error);
            }
        }
        private void consecutivo()
        {
            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(ap_id),0) + 1 AS consecutivo FROM ALMACEN_PRODUCTO";
            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }
        }
        private void limpiar()
        {
            txtnombre.Clear();
            consecutivo();
            this.aLMACEN_PRODUCTOTableAdapter.Fill(this.panesitoAlmacen.ALMACEN_PRODUCTO);
            errorValidacion.Clear();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (clsvalidar.ValidarCamposVacios(this, errorValidacion) == true)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                GuardarAlmacen();
            }
        }

        private void dgalmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.panesitoAlmacen.ALMACEN_PRODUCTO[aLMACENPRODUCTOBindingSource.Position].ap_id.ToString();
            txtnombre.Text = this.panesitoAlmacen.ALMACEN_PRODUCTO[aLMACENPRODUCTOBindingSource.Position].ap_nombre.ToString();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private bool ValidarLetras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //errorNombre.SetError(txtnombre, "Ingrese solo Letras");
                MessageBox.Show("¡Ingrese Solo Letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            return e.Handled;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
            txtnombre.Focus();
        }
    }
}
