﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDomain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int OwnerId { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return
                @$"ID:{Id} , Name:{Name} , Price:{Price} , OwnerID:{OwnerId} , Quantity:{Quantity} , IsActive:{IsActive}";
        }
    }
}
