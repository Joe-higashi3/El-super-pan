using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2.clases
{
    class clsinsumo
    {
        public string error;
        public int iIdinsumo { get; set; }
        public string sNombre { get; set; }
        public float fCosto { get; set; }
        public int iIdUnidad { get; set; }
        public string sStatus { get; set; }

        public bool GuardarInsumo()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSUMO";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@IDINSUMO", iIdinsumo);
            cmd.Parameters.AddWithValue("@NOMBRE", sNombre);
            cmd.Parameters.AddWithValue("@COSTO", fCosto);
            cmd.Parameters.AddWithValue("@UNIDAD", iIdUnidad);
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
