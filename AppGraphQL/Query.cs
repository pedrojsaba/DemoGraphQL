using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGraphQL
{
    public class Query
    {
        [GraphQLMetadata("jedis")]
        public IEnumerable<Jedi> GetJedis()
        {
            return StarWarsDB.GetJedis();
        }

        [GraphQLMetadata("jedi")]
        public Jedi GetJedi(int id)
        {
            return StarWarsDB.GetJedis().SingleOrDefault(j => j.Id == id);
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "Hello Query class";
        }
    }
}
