using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi
{
    public class EcommerceApiQuery : ObjectGraphType<object>
    {
        public EcommerceApiQuery()
        {
            Name = "Query";

            Field<OwnerType>(
                "owners",
                resolve: context =>
                {
                    return new Owner
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "testing",
                        Addresses = new List<Address>()
                    {
                        new Address() { Id = Guid.NewGuid().ToString(), Name = "Testing"},
                        new Address() { Id = Guid.NewGuid().ToString(), Name = "1284 Beacon st "}
                    }
                    };
                });
        }
    }
}
