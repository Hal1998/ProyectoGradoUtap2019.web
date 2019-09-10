using System.Configuration;

namespace ProyectoGradoUtap2019.Logica.BL
{
    public class clsConexion
    {
        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
