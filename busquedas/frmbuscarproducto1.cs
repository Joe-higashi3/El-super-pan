using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.forms
{
    public partial class frmbuscarproducto1 : Form
    {
        public frmbuscarproducto1()
        {
            InitializeComponent();
        }

        private void frmbuscarproducto1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'buscarproducto.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.buscarproducto.PRODUCTO,TXTNOMBRE.Text);

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            this.pRODUCTOTableAdapter.FillBy(this.buscarproducto.PRODUCTO, Convert.ToInt32(txtId.Text));
        }

        private void TXTNOMBRE_TextChanged(object sender, EventArgs e)
        {
            this.pRODUCTOTableAdapter.Fill(this.buscarproducto.PRODUCTO,TXTNOMBRE.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
