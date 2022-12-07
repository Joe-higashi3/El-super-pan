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
        public string error2;
        public string error3;
        public int iIdreceta { get; set; }
        public string sNombre { get; set; }
        public int iIdInsumo { get; set; }
        public float fCantidad { get; set; }
        public float fCosto { get; set; }


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


        public bool AgregarInsumo()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_RECETA";

            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@IDRECETA", iIdreceta);
            cmd.Parameters.AddWithValue("@IDINSUMO", iIdInsumo);
            cmd.Parameters.AddWithValue("@CANTIDAD", fCantidad);
            cmd.Parameters.AddWithValue("@COSTO", fCosto);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                error2 = ex.ToString();
            }
            conn.Close();


            return respuesta;

        }


        public bool QuitarInsumo()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_RECETA";

            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@IDRECETA", iIdreceta);
            cmd.Parameters.AddWithValue("@IDINSUMO", iIdInsumo);
            cmd.Parameters.AddWithValue("@CANTIDAD", fCantidad);
            cmd.Parameters.AddWithValue("@COSTO", fCosto);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                error3 = ex.ToString();
            }
            conn.Close();
            return respuesta;
        }
    }

}
