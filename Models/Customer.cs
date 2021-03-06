﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;

namespace customer_consumption_api.Models
{
    public class Customer : Identifiable<string>
    {
        [Attr] 
        public string Name { get; set; }

        // 'Customers table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'CustomersLocations'.
        [HasMany]
        public ICollection<CustomerLocation> CustomerLocations { get; set; }
    }
}
