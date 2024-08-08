using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Context
{
    internal class ContextFactory : IDesignTimeDbContextFactory<EcommContext>
    {
        public EcommContext CreateDbContext(string[] args)
        {
            // Criação da instância do DbContext com base nas configurações
            var optionsBuilder = new DbContextOptionsBuilder<EcommContext>();
            optionsBuilder.UseSqlServer("Persist Security Info=True; Data Source=localhost;Initial Catalog=dbAPI;Integrated Security=True; TrustServerCertificate = true;");

            return new EcommContext(optionsBuilder.Options);
        }
    }
}
