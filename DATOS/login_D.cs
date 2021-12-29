using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ENTIDAD;
using System.Data;

namespace DATOS
{
    public class login_D
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RRHHEntities"].ConnectionString);

        public DataTable D_login (login_E obj)
        {
            SqlCommand cmd = new SqlCommand("sp_logueo", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obj.usuario);
            cmd.Parameters.AddWithValue("@pass", obj.pass);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            da.Fill(dtable);
            return dtable;
        }

    }
}
