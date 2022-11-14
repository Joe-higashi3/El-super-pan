using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Utilerias
{
    public partial class Validacion : TextBox
    {
        public Validacion()
        {
            InitializeComponent();
        }

        public Boolean Validar
        {
            set; get;

        }

        public Boolean SoloNumeros
        {
            set; get;

        }

        public Boolean SoloLetras
        {

            set; get;

        }

        public Boolean VRFC
        {

            set; get;

        }

    }
}
