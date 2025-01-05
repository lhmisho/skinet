using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Core.Specifications
{
    public class BaseSpecifications<T>(Expression<Func<T, bool>> criteria) : ISpecificaton<T>
    {
        public Expression<Func<T, bool>> Criteria => criteria;
    }
}