using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NTier.Core.Models
{
    public class Department
    {
        //public Department()
        //{
        //    User = new HashSet<User>();


        //}
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public ICollection<User> User { get; set; }

    }
}
