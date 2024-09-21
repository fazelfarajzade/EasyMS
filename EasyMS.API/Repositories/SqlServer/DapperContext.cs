using System.Data.SqlClient;
using System.Data;
using EasyMS.API.Repositories.Interfaces;

namespace EasyMS.API.Repositories.SqlServer
{
    public class DapperContext : IDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string? _connectionString = null;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
