using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi
{
    public class Owner
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<Address> Addresses { get; set; }
    }

    public class Address 
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
