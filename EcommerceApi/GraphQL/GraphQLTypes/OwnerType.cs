using GraphQL.Types;
using System.Collections.Generic;

namespace EcommerceApi
{
    public class QuestionType : ObjectGraphType<Question>
    {
        public QuestionType()
        {
            Field(x => x.ProjectId);
            Field(x => x.Parts, type: typeof(ListGraphType<StringGraphType>)).Description("Name property from the owner object.");
        }
    }

    public class OwnerType : ObjectGraphType<Owner>
    {
        public OwnerType()
        {
            Field(x => x.Id).Description("Id property from the owner object.");
            Field(x => x.Name).Description("Name property from the owner object.");
            Field(x => x.Addresses, type: typeof(ListGraphType<AddressType>)).Description("Addresses Type");
        }
    }

    public class AddressType : ObjectGraphType<Address>
    {
        public AddressType()
        {
            Field(x => x.Id).Description("Id property from the Address object.");
            Field(x => x.Name).Description("Name property from the Address object.");
        }
    }

    public class OwnerInputType : InputObjectGraphType
    {
        public OwnerInputType()
        {
            Field<ListGraphType<FooInput>>("foos");
        }
    }

    public class FooInput : InputObjectGraphType
    {
        public FooInput()
        {
            Name = "InputForSingleFoo";
            Field<StringGraphType>("name");
        }
    }
}

