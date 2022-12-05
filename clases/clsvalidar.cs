using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Utilerias;

namespace WindowsFormsApp2.clases
{
    class clsvalidar
    {

        public static Boolean ValidarCamposVacios(Control Objeto, ErrorProvider ErroProvider)
        {

            Boolean ExErrores = false;

            foreach (Control Item in Objeto.Controls)
            {


                if (Item is Validacion)
                {

                    Validacion Obj = (Validacion)Item;


                    if (Obj.Validar == true)
                    {

                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErroProvider.SetError(Obj, "No Puede Estar Vacio");
                            ExErrores = true;
                        }

                    }

                    if (Obj.SoloNumeros == true)
                    {

                        int cont = 0;
                        int LetrasEncontradas = 0;

                        foreach (char letra in Obj.Text.Trim())
                        {

                            if (char.IsLetter(Obj.Text.Trim(), cont))
                            {

                                LetrasEncontradas++;

                            }

                            cont++;

                        }

                        if (LetrasEncontradas != 0)
                        {


                            ErroProvider.SetError(Obj, " Solo Numeros");
                            ExErrores = true;

                        }

                    }


                }

            }

            return ExErrores;


        }

        
        public static Boolean ValidarCamposVaciosYNumeros(Control Objeto, ErrorProvider ErroProviderdos)
        {

            Boolean NumErrores = false;

            foreach (Control Item in Objeto.Controls)
            {


                if (Item is Validacion)
                {

                    Validacion Obj = (Validacion)Item;


                    /*if (Obj.Validar == true)
                    {

                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {

                            ErroProviderdos.SetError(Obj, "No Puede Estar Vacio");
                            NumErrores = true;

                        }

                    }*/

                    if (Obj.SoloNumeros == true)
                    {

                        int cont = 0;
                        int NumerosEncontrados = 0;

                        foreach (char letra in Obj.Text.Trim())
                        {

                            if (char.IsNumber(Obj.Text.Trim(), cont))
                            {

                                NumerosEncontrados++;

                            }

                            cont++;

                        }

                        if (NumerosEncontrados != 0)
                        {


                            ErroProviderdos.SetError(Obj, " Solo Letras");
                            NumErrores = true;

                        }

                    }


                }

            }

            return NumErrores;


        }

    }

}

