using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2.clases
{
    class clsventa
    {
        public string error;

        public int iId_venta { get; set; }
        public int iId_empleado { get; set; }
        public bool bTipo { get; set; }
        public DateTime dFecha { get; set; }
        public float fTotal { get; set; }
        public int iId_cliente { get; set; }
        public int iId_producto { get; set; }
        public float fPrecio { get; set; }
        public int iCantidad { get; set; }

        public bool Guardar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACEN_PRODUCTO";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@ID_CLIENTE", iId_cliente);
            cmd.Parameters.AddWithValue("@ID_PRODUCTO", iId_producto);
            cmd.Parameters.AddWithValue("@CANTIDAD", iCantidad);
            cmd.Parameters.AddWithValue("@PRECIO", fPrecio);
            cmd.Parameters.AddWithValue("@TOTAL", fTotal);
            cmd.Parameters.AddWithValue("@FECHA", dFecha);
            cmd.Parameters.AddWithValue("@ID_EMPLEADO", iId_empleado);
            cmd.Parameters.AddWithValue("@VTA_TIPO", bTipo);

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
