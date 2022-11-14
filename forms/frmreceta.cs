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
    public partial class frmreceta : Form
    {
        public frmreceta()
        {
            InitializeComponent();
        }

        private void frmreceta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gruposDataSet2.GRUPO' Puede moverla o quitarla según sea necesario.
            this.gRUPOTableAdapter.Fill(this.gruposDataSet2.GRUPO);
            // TODO: esta línea de código carga datos en la tabla 'gruposDataSet.ESTADO' Puede moverla o quitarla según sea necesario.
            this.eSTADOTableAdapter.Fill(this.gruposDataSet.ESTADO);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet3.RECETA' Puede moverla o quitarla según sea necesario.
            this.rECETATableAdapter.Fill(this.panesitoDataSet3.RECETA);

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
