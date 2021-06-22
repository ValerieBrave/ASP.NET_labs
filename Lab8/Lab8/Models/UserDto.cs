using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8.Models
{
    public class UserDto
    {
        /// <summary>id</summary>
        /// <example>1</example>
        /// [Required]
        public int id { get; set; }
        /// <summary>Last Name</summary>
        /// <example>Smelova</example>
        public string lastName { get; set; }
        /// <summary>First Name</summary>
        /// <example>Valeria</example>
        public string firstName { get; set; }
        /// <summary>Email</summary>
        /// <example>ss@ss.com</example>
        public string email { get; set; }
        [Required]
        /// <summary>Password</summary>
        /// <example>pa$$wo0rd</example>
        public string password { get; set; }
        [Required]
        /// <summary>Status</summary>
        /// <example>active|passive</example>
        public string status { get; set; }
        /// <summary>Role</summary>
        /// <example>HR|admin|customer</example>
        [Required]
        public string role { get; set; }
    }
}
