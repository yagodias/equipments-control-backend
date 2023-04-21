using equipmentes_control.Persistence.Configs;
using Microsoft.Extensions.Hosting;

string connectionString = "server=localhost;port=14306;userid=equipment;password=oAJrASdzQE9r;database=equipmentdata;";

using IHost host = Host.CreateDefaultBuilder(args).ConfigureServices(d => d.AddDatabaseModule(connectionString)).Build();

await host.RunAsync();