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
    public partial class frminsumos : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frminsumos()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void frminsumos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panesitoUnidad.UNIDAD' Puede moverla o quitarla según sea necesario.
            this.uNIDADTableAdapter2.Fill(this.panesitoUnidad.UNIDAD);
            // TODO: esta línea de código carga datos en la tabla 'panesitoInsumo.INSUMO' Puede moverla o quitarla según sea necesario.
            this.iNSUMOTableAdapter2.Fill(this.panesitoInsumo.INSUMO);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet4.UNIDAD' Puede moverla o quitarla según sea necesario.
            //this.uNIDADTableAdapter1.Fill(this.panesitoDataSet4.UNIDAD);
            // TODO: esta línea de código carga datos en la tabla 'dtsPanesito.INSUMO' Puede moverla o quitarla según sea necesario.
            //this.iNSUMOTableAdapter1.Fill(this.dtsPanesito.INSUMO);
            // TODO: esta línea de código carga datos en la tabla 'dsunidad.UNIDAD' Puede moverla o quitarla según sea necesario.
            //this.uNIDADTableAdapter.Fill(this.dsunidad.UNIDAD);
            // TODO: esta línea de código carga datos en la tabla 'dsInsumosp.INSUMO' Puede moverla o quitarla según sea necesario.
            //this.iNSUMOTableAdapter.Fill(this.dsInsumosp.INSUMO);

            txtnombre.Focus();
            consecutivo();
            cmbxistatus.SelectedIndex = 0;
        }

        private void GuardarInsumo()
        {
            clsinsumo insumo = new clsinsumo();
            insumo.iIdinsumo = Convert.ToInt32(txtid.Text);
            insumo.sNombre = txtnombre.Text;
            //insumo.fCosto = float.Parse(txtcosto.Text);
            insumo.iIdUnidad = Convert.ToInt32(cmbxunidad.SelectedValue);
            insumo.sStatus = cmbxistatus.Text.Substring(0, 1);

            if (insumo.GuardarInsumo() == true)
            {
                MessageBox.Show("Los datos se han guardado correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("ERROR: Los datos no se pudieron guardar: " + insumo.error);

            }
        }
        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(in_id_insumo),0) + 1 AS consecutivo FROM INSUMO";


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
            //txtcosto.Clear();
            consecutivo();
            this.iNSUMOTableAdapter2.Fill(this.panesitoInsumo.INSUMO);
            this.uNIDADTableAdapter2.Fill(this.panesitoUnidad.UNIDAD);
            txtnombre.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (clsvalidar.ValidarCamposVacios(this, errorValidacion) == true)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            else
            {
                GuardarInsumo();
            }



        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvinsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.panesitoInsumo.INSUMO[iNSUMOBindingSource2.Position].in_id_insumo.ToString();
            txtnombre.Text = this.panesitoInsumo.INSUMO[iNSUMOBindingSource2.Position].in_nombre.ToString();
            //txtcosto.Text = this.panesitoInsumo.INSUMO[iNSUMOBindingSource2.Position].in_costo.ToString();
            cmbxunidad.SelectedValue = this.panesitoUnidad.UNIDAD[uNIDADBindingSource2.Position].un_id_unidad;
            cmbxistatus.SelectedValue = this.panesitoInsumo.INSUMO[iNSUMOBindingSource2.Position].in_status;
            string sSTATUS;
            sSTATUS = this.panesitoInsumo.INSUMO[iNSUMOBindingSource2.Position].in_status.ToString();
            switch (sSTATUS)
            {
                case "A":
                    cmbxistatus.Text = "Activo";
                    break;
                case "C":
                    cmbxistatus.Text = "Cancelado";
                    break;
                default:
                    cmbxistatus.Text = "Activo";
                    break;
            }
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

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
            txtnombre.Focus();
        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(sender, e);
            txtnombre.Focus();
        }
    }
}
