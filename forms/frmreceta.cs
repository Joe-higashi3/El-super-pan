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
            // TODO: esta línea de código carga datos en la tabla 'pRECETA1.RECETA' Puede moverla o quitarla según sea necesario.
            this.rECETATableAdapter2.Fill(this.pRECETA1.RECETA);
            // TODO: esta línea de código carga datos en la tabla 'rECETAP.RECETA' Puede moverla o quitarla según sea necesario.
            //this.rECETATableAdapter1.Fill(this.rECETAP.RECETA);
            // TODO: esta línea de código carga datos en la tabla 'recetaDetalle.RECETA_DETALLE' Puede moverla o quitarla según sea necesario.
            // this.rECETA_DETALLETableAdapter.Fill(this.recetaDetalle.RECETA_DETALLE);
            // TODO: esta línea de código carga datos en la tabla 'gruposDataSet2.GRUPO' Puede moverla o quitarla según sea necesario.
            //this.gRUPOTableAdapter.Fill(this.gruposDataSet2.GRUPO);
            // TODO: esta línea de código carga datos en la tabla 'gruposDataSet.ESTADO' Puede moverla o quitarla según sea necesario.
            // this.eSTADOTableAdapter.Fill(this.gruposDataSet.ESTADO);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet3.RECETA' Puede moverla o quitarla según sea necesario.
            //this.rECETATableAdapter.Fill(this.panesitoDataSet3.RECETA);
            txt_nombre.Focus();
            consecutivo();

        }

        private void GuardarReceta()
        {
            clsreceta receta = new clsreceta();
            receta.iIdreceta = Convert.ToInt32(txtid_receta.Text);
            receta.sNombre = txt_nombre.Text;

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

        private void AgregarInsumo()
        {
            clsreceta receta = new clsreceta();
            receta.iIdreceta = Convert.ToInt32(txtid_receta.Text);
            receta.iIdInsumo = Convert.ToInt32(txtIdInsumo.Text);
            receta.fCantidad = float.Parse(txtcantidad.Text);
            receta.fCosto = float.Parse(txtcosto.Text);

            if (receta.AgregarInsumo() == true)
            {
                txtinsumo.Clear();
                txtcantidad.Clear();
                txtcosto.Clear();
            }
            else
            {
                MessageBox.Show("Hubo un problema al agregar el insumo, error: " + receta.error2);

            }
        }

        private void QuitarInsumo()
        {
            clsreceta receta = new clsreceta();
            receta.iIdreceta = Convert.ToInt32(txtid_receta.Text);
            receta.iIdInsumo = Convert.ToInt32(txtIdInsumo.Text);
            receta.fCantidad = float.Parse(txtcantidad.Text);
            receta.fCosto = float.Parse(txtcosto.Text);

            if (receta.QuitarInsumo() == true)
            {
                txtinsumo.Clear();
                txtcantidad.Clear();
                txtcosto.Clear();
            }
            else
            {
                MessageBox.Show("Hubo un problema al tratar de eliminar el insumo, error: " + receta.error3);

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
            consecutivo();
            //this.rECETATableAdapter1.Fill(this.rECETAP.RECETA);
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
            //ValidarLetras(sender, e);
            txt_nombre.Focus();
        }

        private void btnBInsumo_Click(object sender, EventArgs e)
        {
            /*frmbusquedainsumo mostrar = new frmbusquedainsumo();
            mostrar.Show();*/
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_receta.Text = this.pRECETA1.RECETA[rECETABindingSource2.Position].r_id_receta.ToString();
            txt_nombre.Text = this.pRECETA1.RECETA[rECETABindingSource2.Position].r_nombre.ToString();
            txtid_receta.Text = this.pRECETA1.RECETA[rECETABindingSource2.Position].rd_id_receta.ToString();
            txtIdInsumo.Text = this.pRECETA1.RECETA[rECETABindingSource2.Position].rd_id_insumo.ToString();
            txtinsumo.Text = this.pRECETA1.RECETA[rECETABindingSource2.Position].in_nombre.ToString();
            txtcantidad.Text = this.pRECETA1.RECETA[rECETABindingSource2.Position].rd_cantidad.ToString();
            txtcosto.Text = this.pRECETA1.RECETA[rECETABindingSource2.Position].rd_costo.ToString();
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarInsumo();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            QuitarInsumo();
        }
    }
}
