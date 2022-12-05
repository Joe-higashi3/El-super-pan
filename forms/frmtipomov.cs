using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.clases;

namespace WindowsFormsApp2.forms
{
    public partial class frmtipomov : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmtipomov()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void frmtipomov_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panesitoTipomov.TIPO_MOV' Puede moverla o quitarla según sea necesario.
            this.tIPO_MOVTableAdapter.Fill(this.panesitoTipomov.TIPO_MOV);
            consecutivo();
        }

        private void GuardarTipoMov()
        {
            clstipomov tipomov = new clstipomov();
            tipomov.iIdTipoMov = Convert.ToInt32(txtidtm.Text);
            tipomov.sTipoMov = txttm.Text;


            if (tipomov.GuardarTipoMov() == true)
            {
                MessageBox.Show("Los datos se han guardado correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("ERROR: Los datos no se pudieron guardar: " + tipomov.error);

            }
        }

        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(tm_id),0) + 1 AS consecutivo FROM TIPO_MOV";


            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtidtm.Text = Convert.ToString(l.GetInt32(0));
            }
        }

        private void limpiar()
        {
            txttm.Clear();
            consecutivo();
            this.tIPO_MOVTableAdapter.Fill(this.panesitoTipomov.TIPO_MOV);
            txttm.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (clsvalidar.ValidarCamposVacios(this, errorValidacion) == true)
            {
                MessageBox.Show("Ha ocurrido un error");
                limpiar();
            }

            else
            {
                GuardarTipoMov();
            }



        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvtm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidtm.Text = this.panesitoTipomov.TIPO_MOV[tIPOMOVBindingSource.Position].tm_id.ToString();
            txttm.Text = this.panesitoTipomov.TIPO_MOV[tIPOMOVBindingSource.Position].tm_tipo.ToString(); ;
            
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

        private void txttm_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
            txttm.Focus();
        }
    }
}
