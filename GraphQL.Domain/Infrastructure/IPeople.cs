using GraphQL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.Domain.Infrastructure
{
    public  interface IPeople: IGenericRepository<Person>
    {
    }
}
