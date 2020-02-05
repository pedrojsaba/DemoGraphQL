using GraphQL.Application;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL.API.Controllers
{

    [ApiController]
    public class PeopleController : ControllerBase
    {

        [HttpGet]
        [Route("api/[controller]/{query}")]
        public string Get(string query)
        {
            var schema = Schema.For(@"
  type Person {
      name: String,
      lastname: String,
      balance: Decimal,
      id: ID
  }

  type Query {
      hello: String,
      people: [Person],
      person(id: ID): Person
  }
  ", _ =>
            {
                _.Types.Include<Query>();
            });
            var json = schema.Execute(_ =>
            {
                _.Query = query;
            });

            return json;
        }
    }
}