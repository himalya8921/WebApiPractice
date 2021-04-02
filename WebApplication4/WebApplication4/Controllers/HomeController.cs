using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplicationBO;
using WebApplicationBO.Interface;
using WebApplicationEntities.Entities;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {

        private readonly IWebApplicationBusinessAccess _ticketComponent;
        private readonly IConfiguration _config;
        public HomeController(IWebApplicationBusinessAccess obj, IConfiguration config)
        {
            _config = config;
            _ticketComponent = obj;
        }

        [HttpGet]
        public IActionResult Login([FromQuery] LoginModel userInfo)
        {
            var user = _ticketComponent.GetUsers().Where(x => x.UserName == userInfo.Username && x.Password == userInfo.Password
                    && x.IsActive == true).FirstOrDefault();
            var token = GenerateJSONWebToken(user);
            return Ok(token);
        }

        private string GenerateJSONWebToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] { new Claim(ClaimTypes.Name, userInfo.DisplayName), new Claim(ClaimTypes.Role, userInfo.RoleName) };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
