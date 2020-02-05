using GraphQL;
using GraphQL.Domain.Infrastructure;
using GraphQL.Domain.Model;
using GraphQL.Infrastructure.DummyDB;
using System;
using System.Collections.Generic;

namespace GraphQL.Application
{
    public class Query
    {
        private IPeople _people = new PeopleDummyDB();
        [GraphQLMetadata("people")]
        public IEnumerable<Person> GetPeople()
        {
            return _people.Get();
        }

        [GraphQLMetadata("person")]
        public Person GetPerson(int id)
        {
            return _people.Get(id);
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "Hello Query class";
        }
    }
}
