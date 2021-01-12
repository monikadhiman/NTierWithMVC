using System;
using System.Collections.Generic;
using System.Text;

namespace NTier.Core.Models
{
    public class BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
