using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp2.clases
{
    class clsproveedor
    {
        public string error;
        public int iId_proveedor { get; set; }
        public string sNombre { get; set; }
        public string sApellido_pat { get; set; }
        public string sApellido_mat { get; set; }
        public int iRegimen { get; set; }
        public string sRFC { get; set; }
        public string sRazon_social { get; set; }
        public string sTelefono { get; set; }
        public string sCalle { get; set; }
        public string sNum_int { get; set; }
        public string sNum_ext { get; set; }
        public string sColonia { get; set; }
        public int iId_municipio { get; set; }
        public string sStatus { get; set; }

        public bool Guardar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROVEEDOR";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@IDPROVEEDOR", iId_proveedor);
            cmd.Parameters.AddWithValue("@NOMBRE", sNombre);
            cmd.Parameters.AddWithValue("@APELLIDO_P", sApellido_pat);
            cmd.Parameters.AddWithValue("@APELLIDO_M", sApellido_mat);
            cmd.Parameters.AddWithValue("@REGIMEN", iRegimen);
            cmd.Parameters.AddWithValue("@RFC", sRFC);
            cmd.Parameters.AddWithValue("@RAZON_SOCIAL", sRazon_social);
            cmd.Parameters.AddWithValue("@TELEFONO", sTelefono);
            cmd.Parameters.AddWithValue("@CALLE", sCalle);
            cmd.Parameters.AddWithValue("@NUM_INT", sNum_int);
            cmd.Parameters.AddWithValue("@NUM_EXT", sNum_ext);
            cmd.Parameters.AddWithValue("@COLONIA", sColonia);
            cmd.Parameters.AddWithValue("@MUNICIPIO", iId_municipio);
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
