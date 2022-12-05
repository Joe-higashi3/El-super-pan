using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.clases;
using WindowsFormsApp2.busquedas;
using System.Data.SqlClient;

namespace WindowsFormsApp2.forms
{
    public partial class frmreceta : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmreceta()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void frmreceta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recetaDetalle.RECETA_DETALLE' Puede moverla o quitarla según sea necesario.
            this.rECETA_DETALLETableAdapter.Fill(this.recetaDetalle.RECETA_DETALLE);
            // TODO: esta línea de código carga datos en la tabla 'gruposDataSet2.GRUPO' Puede moverla o quitarla según sea necesario.
            //this.gRUPOTableAdapter.Fill(this.gruposDataSet2.GRUPO);
            // TODO: esta línea de código carga datos en la tabla 'gruposDataSet.ESTADO' Puede moverla o quitarla según sea necesario.
            // this.eSTADOTableAdapter.Fill(this.gruposDataSet.ESTADO);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet3.RECETA' Puede moverla o quitarla según sea necesario.
            //this.rECETATableAdapter.Fill(this.panesitoDataSet3.RECETA);

            txt_nombre.Focus();
            consecutivo();
            cmbxstatus.SelectedIndex = 0;

        }

        private void GuardarReceta()
        {
            clsreceta receta = new clsreceta();
            receta.iIdreceta = Convert.ToInt32(txtid_receta.Text);
            receta.sNombre = txt_nombre.Text;
            //receta.fCosto = float.Parse(txtcosto.Text);
            receta.iIdInsumo = Convert.ToInt32(txtIdInsumo.Text);
            receta.sStatus = cmbxstatus.Text.Substring(0, 1);

            if (receta.GuardarReceta() == true)
            {
                MessageBox.Show("Los datos se han guardado correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("ERROR: Los datos no se pudieron guardar: " + receta.error);

            }
        }

        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(r_id_receta),0) + 1 AS consecutivo FROM RECETA";


            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid_receta.Text = Convert.ToString(l.GetInt32(0));
            }


        }

        private void limpiar()
        {
            txt_nombre.Clear();
            //txtcosto.Clear();
            consecutivo();
            //this.iNSUMOTableAdapter2.Fill(this.panesitoInsumo.INSUMO);
            //this.uNIDADTableAdapter2.Fill(this.panesitoUnidad.UNIDAD);
            txt_nombre.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

                GuardarReceta();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
            txt_nombre.Focus();
        }

        private void btnBInsumo_Click(object sender, EventArgs e)
        {
            frmbusquedainsumo mostrar = new frmbusquedainsumo();
            mostrar.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_receta.Text = this.recetaDetalle.RECETA_DETALLE[rECETADETALLEBindingSource.Position].rd_id_receta.ToString();
            txtIdInsumo.Text = this.recetaDetalle.RECETA_DETALLE[rECETADETALLEBindingSource.Position].rd_id_insumo.ToString();
            //txtinsumo.Text = this.recetaDetalle.RECETA_DETALLE[rECETADETALLEBindingSource.Position].rd_insumo.ToString();
            txtcosto.Text = this.recetaDetalle.RECETA_DETALLE[rECETADETALLEBindingSource.Position].rd_costo.ToString();
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

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }
    }
}
