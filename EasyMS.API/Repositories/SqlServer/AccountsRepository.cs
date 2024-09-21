using Dapper;
using Dapper.Contrib.Extensions;
using EasyMS.API.Models;
using EasyMS.API.Repositories.Interfaces;
using System.Reflection;

namespace EasyMS.API.Repositories.SqlServer
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly IDbContext dbContext;
        public AccountsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Account> GetByIdAsync(int id)
        {
            using (var connection = dbContext.CreateConnection())
            {
                return await connection.GetAsync<Account>(id);
            }
        }

        public async Task<Account?> SearchByUsernameAndPassword(string username, string password)
        {
            var condition = " WHERE Username = @P_Username AND Password = @P_Password ";
            var query = "SELECT * FROM Accounts " + condition;
            using (var connection = dbContext.CreateConnection())
            {
                return await connection.QuerySingleOrDefaultAsync<Account>(query, new { P_Username = username, P_Password = password });
            }
        }
        public async Task<IEnumerable<Account>> GetAllAsync()
        {
            using (var connection = dbContext.CreateConnection())
            {
                return await connection.GetAllAsync<Account>();
            }
        }
        public async Task<int> AddAsync(Account entity)
        {
            entity.CreatedAt = DateTime.Now;
            using (var connection = dbContext.CreateConnection())
            {
                return await connection.InsertAsync(entity);
            }
        }
        public async Task<bool> UpdateAsync(Account entity)
        {
            entity.UpdatedAt = DateTime.Now;
            using (var connection = dbContext.CreateConnection())
            {
                return await connection.UpdateAsync(entity);
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using (var connection = dbContext.CreateConnection())
            {
                return await connection.DeleteAsync(new Account() { Id = id });
            }
        }
    }
}
