using Arch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Description { get; set; }
        public List<Order> Orders { get; set; }

    }
}
