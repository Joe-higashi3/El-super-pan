using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2.clases
{
    class clsreceta
    {
        public string error;
        public int iIdreceta { get; set; }
        public string sNombre { get; set; }
        public string sGrupo { get; set; }
        public string sStatus { get; set; }

        public bool GuardarReceta()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_RECETA";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@IDRECETA", iIdreceta);
            cmd.Parameters.AddWithValue("@NOMBRE", sNombre);
            cmd.Parameters.AddWithValue("@GRUPO", sGrupo);
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
