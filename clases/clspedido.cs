using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp2.clases
{
    class clspedido
    {
        public string error;
        public int iId_pedido { get; set; }
        public int iId_cliente { get; set; }
        public int iId_empleado { get; set; }
        public DateTime d_fecha { get; set; }
        public string bStatus_pedido { get; set; }

        public bool Guardar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PEDIDO";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@IDPEDIDO", iId_pedido);
            cmd.Parameters.AddWithValue("@IDCLIENTE", iId_cliente);
            cmd.Parameters.AddWithValue("@IDEMPLEADO", iId_empleado);
            cmd.Parameters.Add(new SqlParameter("@FECHA", SqlDbType.DateTime)).Value = d_fecha;
            cmd.Parameters.AddWithValue("@STATUS", bStatus_pedido);
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
