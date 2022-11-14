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
    public partial class frmproductos : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmproductos()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void frmproductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panesitoUnidad2.UNIDAD' Puede moverla o quitarla según sea necesario.
            this.uNIDADTableAdapter.Fill(this.panesitoUnidad2.UNIDAD);
            // TODO: esta línea de código carga datos en la tabla 'panesitoCategoria1.CATEGORIA' Puede moverla o quitarla según sea necesario.
            this.cATEGORIATableAdapter.Fill(this.panesitoCategoria1.CATEGORIA);
            // TODO: esta línea de código carga datos en la tabla 'panesitoProducto.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.panesitoProducto.PRODUCTO);

            consecutivo();
            cmbxstatus.SelectedIndex = 0;
        }

        private void GuardarProducto()
        {
            clsproducto producto = new clsproducto();
            producto.iId_producto = Convert.ToInt32(txtid.Text);
            producto.fPrecio99 = float.Parse(txtprecio.Text);
            producto.sNombre = txtnombre.Text;
            producto.sDescripcion = txtdescripcion.Text;
            producto.iId_categoria = Convert.ToInt32(cbxcategoria.SelectedValue);
            producto.sStatus = cmbxstatus.Text.Substring(0, 1);
            producto.iId_unidad = Convert.ToInt32(cbxunidad.SelectedValue);

            if (producto.GuardarProducto() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + producto.error);

            }
        }

        private void limpiar()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            txtdescripcion.Clear();
            consecutivo();
            this.pRODUCTOTableAdapter.Fill(this.panesitoProducto.PRODUCTO);
            txtprecio.Focus();
        }

        private void consecutivo()
        {
            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(pr_id_producto),0) + 1 AS consecutivo FROM PRODUCTO";


            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }

        }

        private void dvgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.panesitoProducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_id_producto.ToString();
            txtprecio.Text = this.panesitoProducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_precio.ToString();
            txtnombre.Text = this.panesitoProducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_nombre.ToString();
            txtdescripcion.Text = this.panesitoProducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_descripcion.ToString();
            cbxcategoria.SelectedValue = this.panesitoProducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_id_categoria;

            cbxunidad.SelectedValue = this.panesitoProducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_id_unidad;

            string sSTATUS;
            sSTATUS = this.panesitoProducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_status.ToString();
            switch (sSTATUS)
            {
                case "A":
                    cmbxstatus.Text = "Activo";
                    break;
                case "C":
                    cmbxstatus.Text = "Cancelado";
                    break;
                default:
                    cmbxstatus.Text = "Activo";
                    break;
            }

        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            if (clsvalidar.ValidarCamposVacios(this, errorValidacion) == true)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            else
            {
                GuardarProducto();
                limpiar();
            }

            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }



        private bool ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("¡Ingrese Solo Numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            return e.Handled;
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

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(sender, e);
            txtprecio.Focus();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
            txtnombre.Focus();
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
            txtdescripcion.Focus();
        }
    }
}
