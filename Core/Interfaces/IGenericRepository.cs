using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(int id);

        Task<IReadOnlyList<T>> GetListAllAsync();
        Task<T?> GetEntityWithSpec(ISpecificaton<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecificaton<T> spec);
        Task<TResult?> GetEntityWithSpec<TResult>(ISpecificaton<T, TResult> spec);
        Task<IReadOnlyList<TResult>> ListAsync<TResult>(ISpecificaton<T, TResult> spec);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        Task<bool> SaveAllAsync();
        bool Exists(int id);

        Task<int> CountAsync(ISpecificaton<T> spec);
    }
}