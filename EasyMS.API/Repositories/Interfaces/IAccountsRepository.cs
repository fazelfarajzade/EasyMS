using EasyMS.API.Models;

namespace EasyMS.API.Repositories.Interfaces
{
    public interface IAccountsRepository
    {
        Task<Account> GetByIdAsync(int id);
        Task<Account?> SearchByUsernameAndPassword(string username, string password);
        Task<IEnumerable<Account>> GetAllAsync();
        Task<int> AddAsync(Account entity);
        Task<bool> UpdateAsync(Account entity);
        Task<bool> DeleteAsync(int id);
    }
}
