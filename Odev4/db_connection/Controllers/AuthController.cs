using DAL.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using db_connection.Controllers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace JwtWebApiTutorial.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static Login login = new Login();
        private readonly IConfiguration _configuration;
        private MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        LoginDbOperations dbOperation = new LoginDbOperations();


        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("create")]
        //add new users to our database
        public string loginCreate(APIAuthority _user)
        {
            //encrypt password
            _user.Password = MD5Hash(_user.Password);
            //send to LoginDbOperations.cs
            dbOperation.CreateLogin(_user);
            return "User succesfully added";
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromHeader] LoginDto request)
        {
            APIAuthority tokenUser = new APIAuthority();
            tokenUser.UserName = request.UserName;
            tokenUser.Password = MD5Hash(request.PasswordHash);

            APIAuthority result = dbOperation.GetLogin(tokenUser);

            if (result != null)
            {
                string token = CreateToken(login);
                //return "Giris basarili";
                return Ok(token);

            }
            else
            {
                return BadRequest("Kullanıcı yok ya da şifre hatalı.");
            }

        }

        private string CreateToken(Login login)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, login.UserName),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
        public string MD5Hash(string _input)
        {

            byte[] dizi = Encoding.UTF8.GetBytes(_input);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}