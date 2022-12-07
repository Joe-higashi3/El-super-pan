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

namespace WindowsFormsApp2.busquedas
{
    public partial class frmbusquedainsumo : Form
    {

        public frmbusquedainsumo()
        {
            InitializeComponent();
        }

        private void frmbusquedainsumo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'buscarInsumo.INSUMO' Puede moverla o quitarla según sea necesario.
            this.iNSUMOTableAdapter.Fill(this.buscarInsumo.INSUMO, txtinsumo.Text);

        }

        private void txtinsumo_TextChanged(object sender, EventArgs e)
        {
            this.iNSUMOTableAdapter.Fill(this.buscarInsumo.INSUMO, txtinsumo.Text);
        }
    }
}
