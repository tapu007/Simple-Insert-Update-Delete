using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Repository.Contracts
{
    public interface IBaseRepository<T>where T:class
    {
        bool Add(T entity);
        List<T> GetAll();
        bool Remove(T entity);
        bool Update(T entity);       
    }
}
