using DAL.Model;
using Entities;

namespace db_connection.Controllers
{
    public class LoginDbOperations
    {
        StudentContext _context = new StudentContext();
         public void CreateLogin(APIAuthority loginUser)
        {
            _context.APIAuthority.Add(loginUser);
            _context.SaveChanges();
        }

        public APIAuthority GetLogin(APIAuthority loginUser)
        {
            APIAuthority? user = new APIAuthority();
            if (!string.IsNullOrEmpty(loginUser.UserName) && !string.IsNullOrEmpty(loginUser.Password))
            {
                user = _context.APIAuthority.FirstOrDefault(m => m.UserName == loginUser.UserName && m.Password == loginUser.Password);
            }

            return user;

        }
    }
}
