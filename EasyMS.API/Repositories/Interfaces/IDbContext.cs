using System.Data;

namespace EasyMS.API.Repositories.Interfaces
{
    public interface IDbContext
    {
        public IDbConnection CreateConnection();
    }
}
