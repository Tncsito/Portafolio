using System.Data.SqlClient;
namespace Portafolio_EESA.Datos
{
    public class Conexion
    {
        private string cadenaSql = string.Empty;
        public Conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").Build();
        }
    }
}
