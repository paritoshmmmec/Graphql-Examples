using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi
{
    public class EcommerceApiMutation : ObjectGraphType
    {
        public EcommerceApiMutation()
        {
            Name = "Mutation";

            Field<OwnerType>(
                "createOwner",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<OwnerInputType>> { Name = "owner" }
                ),
                resolve: context =>
                {
                    var human = context.GetArgument<Owner>("owner");
                    return new Owner
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "testing",
                        Addresses = new List<Address>()
                    {
                        new Address() { Id = Guid.NewGuid().ToString(), Name = "Testing"},
                        new Address() { Id = Guid.NewGuid().ToString(), Name = "1284 Beacon st "}
                    }};
                });
        }
    }
}
