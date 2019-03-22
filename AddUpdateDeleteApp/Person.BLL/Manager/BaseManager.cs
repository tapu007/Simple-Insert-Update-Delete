using Person.BLL.Contract;
using Person.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.BLL.Manager
{
    public class BaseManager<T>:IBaseManager<T> where T:class
    {
        protected IBaseRepository<T> _repository;
        public BaseManager(IBaseRepository<T> baseRepository)
        {
            _repository = baseRepository;
        }
        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }
        public virtual bool Remove(T entity)
        {

            return _repository.Remove(entity);
        }
        public virtual List<T> GetAll()
        {
            return _repository.GetAll();
        
        }

    }
}
