using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginPage.Model;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Cors;
namespace LoginPage.Controllers
{
    [Route("api/auth")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class LoginController : ControllerBase
    {
        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] Users user)
        {
            if (user == null)
                return BadRequest("Invalid client request");
             
            if(user.userName == "ty123" && user.passWord == "123456")
            {
                //var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecrectKey@345"));
                //var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                //var tokenOptions = new JwtSecurityToken(
                //        issuer: "http://localhost:44333",
                //        audience: "http://localhost:44333",
                //        claims: new List<Claim>(),
                //        expires: DateTime.Now.AddMinutes(5),
                //        signingCredentials: signingCredentials
                //    );

                //var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                return Ok(new { Token = "Login success" });
            }

            return Unauthorized();
        }
    }
}
