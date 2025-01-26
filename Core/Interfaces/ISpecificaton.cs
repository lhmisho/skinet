using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ISpecificaton<T>
    {
        Expression<Func<T, bool>>? Criteria { get; }
        Expression<Func<T, object>>? OrderBy { get; }
        Expression<Func<T, object>>? OrderByDescending { get; }
        bool IsDistinct { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }

        IQueryable<T> ApplyCritera(IQueryable<T> query);
    }

    public interface ISpecificaton<T, TResult> : ISpecificaton<T>
    {
        Expression<Func<T, TResult>>? Select { get; }
    }
}
