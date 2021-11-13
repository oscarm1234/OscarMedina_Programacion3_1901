using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace ExamenII_OscarMedina.Modelos.DAO
{
    public class Conexion
    {

        protected SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["SoporteConexion"].ConnectionString);
    }
}
