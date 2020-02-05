using GraphQL;
using GraphQL.Types;
using System;

namespace AppGraphQL
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var schema = Schema.For(@"
  type Jedi {
      name: String,
      side: String,
      id: ID
  }

  type Query {
      hello: String,
      jedis: [Jedi],
      jedi(id: ID): Jedi
  }
  ", _ =>
            {
                _.Types.Include<Query>();
            });

            var json = schema.Execute(_ =>
            {
                _.Query = "{ jedis { id, name, side } }";
            });          

            Console.WriteLine(json);

            json = schema.Execute(_ =>
            {
                _.Query = "{ jedi(id: 1) { name } }";
            });

            Console.WriteLine(json);
        }
    }
}
