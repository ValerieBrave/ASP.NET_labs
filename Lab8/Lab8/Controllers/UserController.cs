using Lab8.Models;
using Lab8_orm;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        /// <summary>
        /// Get users list
        /// </summary>
        ///<returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<user>) , StatusCodes.Status200OK)]
        public JsonResult Get()
        {
            var result = userRepository.GetAllUsers();
            return Json(new { usersList = result });
        }
        /// <summary>
        /// Get user by idd
        /// </summary>
        /// <response code="200">User found</response>
        /// <response code="404">User not found</response>
        /// <param name="id" example="101">User id</param>
     
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(user), StatusCodes.Status200OK)]
        public IActionResult GetById(int id)
        {
            user result = userRepository.GetUserById(id);
            if (result == null) return NotFound("User not found");
            string r = JsonConvert.SerializeObject(result);
            return Content(r);
        }

        /// <summary>
        /// Add user
        /// </summary>
        /// <response code="200">User added</response>
        /// <response code="400">User not added</response>
      
        [HttpPost]
        [ProducesResponseType(typeof(user), StatusCodes.Status200OK)]
        public IActionResult Add([FromBody] UserDto user)
        {
            var result = userRepository.AddUser(new user
            {
                lastName = user.lastName,
                firstName = user.firstName,
                email = user.email,
                password = user.password,
                status = user.status,
                role = user.role
            });
            if (result == null) return BadRequest("User not added");
            string r = JsonConvert.SerializeObject(result);
            return Content(r);
        }
        /// <summary>
        /// Edit user
        /// </summary>
        /// <response code="200">User edited</response>
        /// <response code="400">User not updated</response>
    
        [HttpPut]
        [ProducesResponseType(typeof(user), StatusCodes.Status200OK)]
        public IActionResult EditUser([FromBody] UserDto user)
        {
            var result = userRepository.EditUser(new user
            {
                id = user.id,
                lastName = user.lastName,
                firstName = user.firstName,
                email = user.email,
                password = user.password,
                status = user.status,
                role = user.role
            });
            if (result == null) return BadRequest("User not updated");
            string r = JsonConvert.SerializeObject(result);
            return Content(r);
            
        }
        /// <summary>
        /// Delete user
        /// </summary>
        /// <response code="200">User deleted</response>
        /// <response code="404">User not found</response>
        /// <param name="id" example="101">User id</param>
   
        [HttpDelete("{id:int}")]
        [ProducesResponseType(typeof(user), StatusCodes.Status200OK)]
        public IActionResult DeleteById(int id)
        {
            var result = userRepository.DeleteUser(id);
            if (result == null) return NotFound("User not found");
            string r = JsonConvert.SerializeObject(result);
            return Content(r);
        }
    }
}
