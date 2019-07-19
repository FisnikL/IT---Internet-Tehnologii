using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _151027_LAB3_IT.Models
{
    public class Friend
    {
        [Required]
        [Range(0, 200)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        public Friend(int Id, string Name, string Location)
        {
            this.Id = Id;
            this.Name = Name;
            this.Location = Location;
        }

        public Friend()
        {

        }
    }
}