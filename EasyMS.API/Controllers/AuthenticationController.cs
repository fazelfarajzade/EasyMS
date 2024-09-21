using AutoMapper;
using EasyMS.API.ApiModels.Aauthentication;
using EasyMS.API.Models;
using EasyMS.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EasyMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAccountsRepository _accountsRepository;

        public AuthenticationController(IConfiguration configuration, IAccountsRepository accountsRepository)
        {
            _configuration = configuration;
            _accountsRepository = accountsRepository;
        }
        //private static Dictionary<string, string> _refreshTokens = new Dictionary<string, string>();

        // login
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var account = await _accountsRepository.SearchByUsernameAndPassword(model.Username, model.Password);
            if (account != null)
            {
                // generate token for user
                var token = GenerateAccessToken(account);
                var refreshToken = Guid.NewGuid().ToString();

                // Store the refresh token (in-memory for simplicity)
                //_refreshTokens[refreshToken] = model.Username;

                //return access token and refresh token
                return Ok(new
                {
                    AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                    RefreshToken = refreshToken
                });

            }
            // unauthorized user
            return Unauthorized("Invalid credentials");
        }

        [HttpPost("Refresh")]
        public IActionResult Refresh([FromBody] RefreshModel request)
        {
            //if (_refreshTokens.TryGetValue(request.RefreshToken, out var userId))
            //{
            //    // Generate a new access token
            //    var token = GenerateAccessToken(userId);

            //    // Return the new access token to the client
            //    return Ok(new { AccessToken = new JwtSecurityTokenHandler().WriteToken(token) });
            //}

            return BadRequest("Invalid refresh token");
        }

        // Generating token based on user information
        private JwtSecurityToken GenerateAccessToken(Account account)
        {
            // Create user claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, account.Id.ToString()),
                new Claim(ClaimTypes.Name, account.Name + " " + account.LastName),
                // Add additional claims as needed (e.g., roles, etc.)
            };

            // Create a JWT
            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(1), // Token expiration time
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"])),
                    SecurityAlgorithms.HmacSha256)
            );

            return token;
        }
    }
}
