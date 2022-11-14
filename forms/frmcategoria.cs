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
    public partial class frmcategoria : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmcategoria()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void frmcategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panesitoCategoria.CATEGORIA' Puede moverla o quitarla según sea necesario.
            this.cATEGORIATableAdapter.Fill(this.panesitoCategoria.CATEGORIA);
            txtdescripcion.Focus();
            consecutivo();
        }

        private void GuardarCategoria()
        {
            clscategoria categoria = new clscategoria();
            categoria.iId_categoria = Convert.ToInt32(txtid.Text);
            categoria.sDescripcion = txtdescripcion.Text;

            if (categoria.GuardarCategoria() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + categoria.error);

            }
        }
        private void limpiar()
        {
            txtid.Clear();
            txtdescripcion.Clear();
            this.cATEGORIATableAdapter.Fill(this.panesitoCategoria.CATEGORIA);
            consecutivo();
        }

        private void consecutivo()
        {
            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(ca_id),0) + 1 AS consecutivo FROM CATEGORIA";

            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.panesitoCategoria.CATEGORIA[cATEGORIABindingSource.Position].ca_id.ToString();
            txtdescripcion.Text = this.panesitoCategoria.CATEGORIA[cATEGORIABindingSource.Position].ca_descripcion.ToString();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (clsvalidar.ValidarCamposVacios(this, errorValidacion) == true)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            else
            {
                GuardarCategoria();
            }



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

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
            txtdescripcion.Focus();
        }
    }
}
