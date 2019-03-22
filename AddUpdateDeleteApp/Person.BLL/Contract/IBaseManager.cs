using System;
using System.Collections.Generic;
using System.Text;

namespace Person.BLL.Contract
{
    public interface IBaseManager<T>where T:class
    {
        bool Add(T entity);
        List<T> GetAll();
        bool Remove(T entity);
        bool Update(T entity);
    }
}
