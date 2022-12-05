using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2.clases
{
    class clscompra
    {
        public string error;

        public int iId_movimiento { get; set; }
        public int iId_insumo { get; set; }
        //public int iId_producto { get; set; }
        public int iId_proveedor { get; set; }
        public int iId_tipo_movimiento { get; set; }
        public int iId_almacen { get; set; }
        public int iCantidad { get; set; }
        public float fPrecio { get; set; }
        //public DateTime dFecha { get; set; }
        public float fImporte { get; set; }

        public bool GuardarCompra()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_MOV_INV_DET";

               cmd.Parameters.AddWithValue("@OP", 2);
               cmd.Parameters.AddWithValue("@IDMOV", iId_movimiento);
            //   cmd.Parameters.AddWithValue("@", );
               cmd.Parameters.AddWithValue("@IDTIPO", iId_tipo_movimiento);
               cmd.Parameters.AddWithValue("@IDPROVEEDOR", iId_proveedor);
               cmd.Parameters.AddWithValue("@IDALMACEN", iId_almacen);
               cmd.Parameters.AddWithValue("@IDINSUMO", iId_insumo);
               cmd.Parameters.AddWithValue("@CANTIDAD", iCantidad);
               cmd.Parameters.AddWithValue("@PRECIO", fPrecio);
               cmd.Parameters.AddWithValue("@IMPORTE", fImporte);
               

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
