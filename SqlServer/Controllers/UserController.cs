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


        [HttpPost("PostUsers")]
        public IActionResult Post([FromForm]UserModel model)
        {
            userDB.Users.Add(model);
            userDB.SaveChanges();
            return Ok(model);
        }

        [HttpGet("GetUsers")]
        public IEnumerable<UserModel> GetUsers()
        {
            return userDB.Users;
        }

        [HttpPut("UpdateUser/{id}")]
        public IActionResult Put(int id, [FromForm] UserModel model)
        {
            var user = userDB.Users.First(p => p.Id == id);
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Phone = model.Phone;
            userDB.SaveChanges();
            return Ok(model);
        }

        [HttpDelete("DeleteUser/{id}")]
        public IActionResult Delete(int id)
        {
            userDB.Remove(userDB.Users.First(p=>p.Id == id));
            userDB.SaveChanges();
            return Ok("Success");
        }
    }
}
