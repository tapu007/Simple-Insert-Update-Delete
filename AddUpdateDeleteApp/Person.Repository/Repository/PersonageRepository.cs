using Person.Models.EntityModels;
using Person.Repository.Contracts;
using Person.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person.Repository.BaseRepository
{
    public class PersonageRepository:BaseRepository<Personage>,IPersonageRepository
    {
       public bool IsPersonageExist(string email)
        {
            if (db.Persons.Any(e=>e.Email == email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Personage GetInfoBy(int personageId)
        {
            return db.Persons.Where(e=>e.ID == personageId).FirstOrDefault();
        }
  

    }
}
