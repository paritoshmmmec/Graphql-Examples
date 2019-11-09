using EcommerceApi.GraphQL;
using GraphQL;
using GraphQL.Types;

namespace EcommerceApi
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<EcommerceApiQuery>();
            Mutation = resolver.Resolve<EcommerceApiMutation>();

        }
    }
}
