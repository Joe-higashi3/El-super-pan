using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2.clases
{
    class clsinvdetalle
    {
        public string error;
        public int iIdmov { get; set; }
        public int iIdinsumo { get; set; }
        public int iIdproducto { get; set; }
        public int iIdtipo { get; set; }
        public int icantidad { get; set; }
        public float fprecio { get; set; }
        public int iImporte { get; set; }

        public bool Guardar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_MOV_INV_DET";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@IDMOVD", iIdmov);
            cmd.Parameters.AddWithValue("@IDINSUMO", iIdinsumo);
            cmd.Parameters.AddWithValue("@IDPRODUCTO", iIdproducto);
            cmd.Parameters.AddWithValue("@IDTIPO", iIdtipo);
            cmd.Parameters.AddWithValue("@CANTIDAD", icantidad);
            cmd.Parameters.AddWithValue("@PRECIO", fprecio);
            cmd.Parameters.AddWithValue("@IMPORTE", iImporte);
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
