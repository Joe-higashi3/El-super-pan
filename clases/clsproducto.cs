using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.clases
{
    class clsproducto
    {
        public string error;
        public int iId_producto { get; set; }
        public string sNombre { get; set; }
        public string sDescripcion { get; set; }
        public int iId_categoria { get; set; }
        public float fPrecio99 { get; set; }
        public int iId_unidad { get; set; }
        public string sStatus { get; set; }


        public bool GuardarProducto()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTO";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@IDPRODUCTO", iId_producto);
            cmd.Parameters.AddWithValue("@NOMBRE", sNombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", sDescripcion);
            cmd.Parameters.AddWithValue("@CATEGORIA", iId_categoria);
            cmd.Parameters.AddWithValue("@PRECIO", fPrecio99);
            cmd.Parameters.AddWithValue("IDUNIDAD", iId_unidad);
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

