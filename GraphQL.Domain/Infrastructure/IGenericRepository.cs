using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.Domain.Infrastructure
{
    public interface IGenericRepository<T>
    {
        List<T> Get();
        T Get(int id);
    }
}
