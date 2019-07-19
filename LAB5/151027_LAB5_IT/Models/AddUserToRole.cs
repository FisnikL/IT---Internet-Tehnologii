using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _151027_LAB5_IT.Models
{
    public class AddUserToRole
    {
        public string Email { get; set; }
        public string SelectedRole { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public AddUserToRole()
        {
            Roles = new List<IdentityRole>();
        }
    }
}