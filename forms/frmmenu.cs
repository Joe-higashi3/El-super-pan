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

namespace WindowsFormsApp2.forms
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmclientes mostrar = new frmclientes();
            mostrar.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmpedidos mostrar = new frmpedidos();
            mostrar.Show();*/
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmempleados mostrar = new frmempleados();
            mostrar.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproductos mostrar = new frmproductos();
            mostrar.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmalmacen mostrar = new frmalmacen();
            mostrar.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategoria mostrar = new frmcategoria();
            mostrar.Show();
        }
        private void provedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproveedor mostrar = new frmproveedor();
            mostrar.Show();
        }

        private void recetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreceta mostrar = new frmreceta();
            mostrar.Show();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrol mostrar = new frmrol();
            mostrar.Show();
        }

        private void tipoDeMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtipomov mostrar = new frmtipomov();
            mostrar.Show();
        }

        private void unidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmunidad mostrar = new frmunidad();
            mostrar.Show();
        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frminsumos mostrar = new frminsumos();
            mostrar.Show();
        }

        private void rolToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmrol mostrar = new frmrol();
            mostrar.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmventas ven = new frmventas();
            ven.Show();
        }
    }
}
