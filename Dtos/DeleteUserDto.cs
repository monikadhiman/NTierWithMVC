using System;
using System.Collections.Generic;
using System.Text;

namespace NTier.Core.Dtos
{
    public class DeleteUserDto
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
