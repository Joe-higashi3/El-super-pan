using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2.busquedas
{
    public partial class frmbusquedaclientes : Form
    {
        public frmbusquedaclientes()
        {
            InitializeComponent();
        }

        private void frmbusquedaclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCliente.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.dsCliente.CLIENTE,TXTNOMBRE.Text);

        }

        private void TXTNOMBRE_TextChanged(object sender, EventArgs e)
        {
            this.cLIENTETableAdapter.Fill(this.dsCliente.CLIENTE, TXTNOMBRE.Text);

        }

        private void TXTTELEFONO_TextChanged(object sender, EventArgs e)
        {
            this.cLIENTETableAdapter.FillBy(this.dsCliente.CLIENTE, TXTTELEFONO.Text);

        }

        private void dgvbusquedacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
