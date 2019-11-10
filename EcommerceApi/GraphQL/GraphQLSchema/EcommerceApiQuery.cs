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
            Field<QuestionType>(
              "question",
              arguments: new QueryArguments(
                  new QueryArgument<NonNullGraphType<IntGraphType>>
                  { Name = "projectId", Description = "Project Id" },
                  new QueryArgument<NonNullGraphType<ListGraphType<StringGraphType>>>
                  { Name = "partIds", Description = "partid" }
              ),
              resolve: context =>
              {
                  var projectId = context.GetArgument<int>("projectId");
                  var partIds = context.GetArgument<List<string>>("partIds");
                  return new Question()
                  {
                      ProjectId = projectId,
                      Parts = partIds
                  };
              }
          );

            Field<QuestionType>(
              "questionByProjectId",
              arguments: new QueryArguments(
                  new QueryArgument<NonNullGraphType<IntGraphType>>
                  { Name = "projectId", Description = "Project Id" }
              ),
              resolve: context =>
              {
                  var projectId = context.GetArgument<int>("projectId");
                  return new Question()
                  {
                      ProjectId = projectId,
                      Parts = new List<string>()
                      {
                          "Testing" , "Hero"
                      }
                  };
              }
          );
        }
    }
}
