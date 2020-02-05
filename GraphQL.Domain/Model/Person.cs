using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.Domain.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public decimal Balance { get; set; }
    }
}
