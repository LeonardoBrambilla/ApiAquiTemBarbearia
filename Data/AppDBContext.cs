using ApiAquiTemBarbearia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApiAquiTemBarbearia.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        private readonly ILogger<AppDbContext> logger;

        public AppDbContext(IConfiguration configuration, ILogger<AppDbContext> logger)

        {
            Configuration = configuration;
            this.logger = logger;            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public bool TestarConexao()
        {
            try
            {
                Database.CanConnect();
                logger.LogInformation("Conexão com o banco de dados estabelecida com sucesso.");
                return true;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Erro ao conectar ao banco de dados.");
                return false;
            }
        }
        public DbSet<Users> Users { get; set; }
    }

}