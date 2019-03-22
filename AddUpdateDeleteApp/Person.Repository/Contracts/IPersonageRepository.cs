using Person.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Repository.Contracts
{
    public interface IPersonageRepository:IBaseRepository<Personage>
    {
        bool IsPersonageExist(string email);
        Personage GetInfoBy(int personageId);
    }
}
