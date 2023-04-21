using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;

namespace equipmentes_control.Persistence.Configs
{
    public static class ModuleDependency
    {
        public static void AddDatabaseModule(this IServiceCollection services, string connectionString)
        {
            var mySqlConnection = new MySqlConnection(connectionString);

            services.AddDbContext<EquipmentContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(mySqlConnection)));
        }
    }
}
