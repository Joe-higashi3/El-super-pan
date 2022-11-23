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
using System.Globalization;


namespace WindowsFormsApp2
{
    public partial class frmpedidos : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmpedidos()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pEDIDOTableAdapter2.Fill(this.panesitoDataSet5.PEDIDO);
            this.pEDIDO_DETALLETableAdapter1.Fill(this.panesitoDataSetPed.PEDIDO_DETALLE);
            this.pEDIDOTableAdapter1.Fill(this.panesitoDataSetPed.PEDIDO);

            //suppan
            dtpfecha.Format = DateTimePickerFormat.Custom;
            dtpfecha.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            consecutivo();
        }

        private void GuardarPedidos()
        {

            clspedido pedido = new clspedido();
            pedido.iId_cliente = Convert.ToInt32(txtid.Text);
            pedido.iId_empleado = Convert.ToInt32(txtid.Text);
            pedido.d_fecha = dtpfecha.Value;




            pedido.bStatus_pedido = txtstatus.Text;
            if (pedido.Guardar() == true)
            {
                MessageBox.Show("Datos Guardados Correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al guardar los datos" + pedido.error);
            }
        }

        private void consecutivo()
        {
            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(pe_id_pedido),0) + 1 AS consecutivo FROM PEDIDO";

            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }

        }
        private void limpiar()
        {
            txtid.Clear();
            txtid.Clear();
            txtEmpleado.Clear();
            consecutivo();
            this.pEDIDOTableAdapter2.Fill(this.panesitoDataSet5.PEDIDO);
        }
        private void btninsertar_Click(object sender, EventArgs e)
        {
            GuardarPedidos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void dgvarticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.panesitoDataSet5.PEDIDO[pEDIDOBindingSource2.Position].pe_id_pedido.ToString();
            txtid.Text = this.panesitoDataSet5.PEDIDO[pEDIDOBindingSource2.Position].pe_id_cliente.ToString();
            txtEmpleado.Text = this.panesitoDataSet5.PEDIDO[pEDIDOBindingSource2.Position].pe_id_empleado.ToString();
            dtpfecha.Text = this.panesitoDataSet5.PEDIDO[pEDIDOBindingSource2.Position].pe_fecha.ToString();
            txtstatus.Text = this.panesitoDataSet5.PEDIDO[pEDIDOBindingSource2.Position].pe_estatus_pedido.ToString();
        }
        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                //errorNombre.SetError(txtnombre, "Ingrese solo Letras");
                MessageBox.Show("Ingrese Solo Letras");
                txtstatus.Clear();
                txtstatus.Focus();
            }
        }


    }
}
