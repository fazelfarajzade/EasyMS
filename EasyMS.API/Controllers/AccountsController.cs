using EasyMS.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsRepository accountsRepository;
        public AccountsController(IAccountsRepository accountsRepository) {
            this.accountsRepository = accountsRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await accountsRepository.GetAllAsync());
        }
    }
}
