using GraphQL.Domain.Infrastructure;
using GraphQL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL.Infrastructure.DummyDB
{
    public class PeopleDummyDB : IPeople
    {
        public List<Person> Get()
        {
            return new List<Person>() {
        new Person(){ Name ="Luke", Lastname="Skywalker", Id = 1, Balance = 1293},
        new Person(){ Name ="Yoda", Lastname="Light", Id = 2, Balance = 343},
        new Person(){ Name ="Darth", Lastname="Vader", Id = 3, Balance = 53432}
    };
        }

        public Person Get(int id)
        {
            return Get().SingleOrDefault(j => j.Id == id);
        }
    }
}
