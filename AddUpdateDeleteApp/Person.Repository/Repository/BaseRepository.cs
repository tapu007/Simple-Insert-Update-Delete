using Microsoft.EntityFrameworkCore;
using Person.DatabaseContext.DatabaseContext;
using Person.Models.EntityModels;
using Person.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person.Repository.Repository
{
    public class BaseRepository<T>:IBaseRepository<T> where T :class
    {
        protected PersonDatabaseContext db = new PersonDatabaseContext();
        public DbSet<T> Table
        {
            get { return db.Set<T>(); }
        }
        public virtual bool Add(T entity)
        {
            Table.Add(entity);
            return db.SaveChanges() > 0;

        }

        public virtual bool Update(T entity)
        {
            
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;

        }
        public virtual bool Remove(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
        public virtual List<T> GetAll()
        {
            return Table.ToList();
        }     
       
    }
}
