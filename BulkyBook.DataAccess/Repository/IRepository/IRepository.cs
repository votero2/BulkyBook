using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //get record by id
        T Get(int id);

        //get a list of records
        IEnumerable<T> GetAll(
            Expression<Func<T,bool>> filter = null,
            Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        //firstOrDefault
         T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        //Add record
        void Add(T entity);

        //Remove
        void Remove(int id);

        //Remove comlete entity
        void Remove(T entity);

        //remove a list of entities
        void RemoveRange(IEnumerable<T> entity);

    }
}
