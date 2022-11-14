using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApp2.clases
{
    class clsalmacen
    {
        public string error;

        public int iIdAlmacen { get; set; }
        public string sNombre { get; set; }

        public bool Guardar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACEN_PRODUCTO";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@IDALMACEN", iIdAlmacen);
            cmd.Parameters.AddWithValue("@NOMBRE", sNombre);
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
