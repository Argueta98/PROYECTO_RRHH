using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;

namespace NEGOCIO
{
    public class login_N
    {
        DATOS.login_D obj = new DATOS.login_D();

        public DataTable login_N1(ENTIDAD.login_E obje)
        {
            return obj.D_login(obje);
        }
    }
}
