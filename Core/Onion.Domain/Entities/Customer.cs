﻿using Onion.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.Entities
{
    public class Customer: BaseEntities
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
       
    }
}
