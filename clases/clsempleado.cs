using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.clases
{
    class clsempleado
    {
        public string error;
        //public int iIdempleado { get; set; }
        public string sUsuario { get; set; }
        public byte[] sContraseña { get; set; }
        public string sApellido_p { get; set; }
        public string sApellido_m { get; set; }
        public string sTelefono { get; set; }
        public string sCalle { get; set; }
        public int iNum_int { get; set; }
        public int iNum_ext { get; set; }
        public string sColonia { get; set; }
        public int iId_municipio { get; set; }
        public int iId_rol { get; set; }
        public string sStatus { get; set; }


        public bool GuardarEmpleado()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_EMPLEADO";

            cmd.Parameters.AddWithValue("@OP", 1);
            //cmd.Parameters.AddWithValue("@IDEMPLEADO", iIdempleado);
            cmd.Parameters.AddWithValue("@USUARIO", sUsuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", sContraseña);
            cmd.Parameters.AddWithValue("@APELLIDO_P", sApellido_p);
            cmd.Parameters.AddWithValue("@APELLIDO_M", sApellido_m);
            cmd.Parameters.AddWithValue("@TELEFONO", sTelefono);
            cmd.Parameters.AddWithValue("@CALLE", sCalle);
            cmd.Parameters.AddWithValue("@INTERIOR", iNum_int);
            cmd.Parameters.AddWithValue("@EXTERIOR", iNum_ext);
            cmd.Parameters.AddWithValue("@COLONIA", sColonia);
            cmd.Parameters.AddWithValue("@MUNICIPIO", iId_municipio);
            cmd.Parameters.AddWithValue("@ROL", iId_rol);
            cmd.Parameters.AddWithValue("@STATUS", sStatus);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                error = ex.ToString();
            }
            conn.Close();


            return respuesta;
        }

    }
}