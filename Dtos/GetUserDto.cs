using NTier.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NTier.Core.Dtos
{
    public class GetUserDto
    {
       
        public Guid Id { get; set; }
       
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int Age { get; set; }
      
        public string Address { get; set; }
        
        public string Phone { get; set; }
       
        public string Email { get; set; }
        
        public string Password { get; set; }
       
        public string Gender { get; set; }

        public List<Department> Department { get; set; }
        public int DepartmentId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
