using Microsoft.AspNetCore.Mvc;
using SqlServer.DBContext;
using SqlServer.Models;

namespace SqlServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        public UserController(UserDBContext _userDB)
        {
            this.userDB = _userDB;
        }
        private readonly UserDBContext userDB;
        [HttpGet]
        public IEnumerable<UserModel> GetUsers()
        {
            return userDB.Users;
        }
    }
}
