using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ISpecificaton<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
    }
}