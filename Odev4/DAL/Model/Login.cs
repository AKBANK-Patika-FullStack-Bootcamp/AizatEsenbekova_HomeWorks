using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Login
    {
        public string UserName { get; set; }=string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
    public class  LoginDto
    {
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; }= string.Empty;
    }

    public class APIAuthority
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Admin  { get; set; }
    }
}
