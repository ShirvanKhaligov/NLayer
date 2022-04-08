﻿using System.Linq.Expressions;
namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);//ToList den sonra DB ya gedir
        Task<IEnumerable<T>> GetAllAsync();//ToList den sonra DB ya gedir
        Task AddAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task Update(T entity);
        Task Remove(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
