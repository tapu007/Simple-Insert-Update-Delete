using Person.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.BLL.Contract
{
    public interface IPersonageManager:IBaseManager<Personage>
    {
        bool IsPersonageEmailExist(string email);
        Personage GetInfoBy(int personageId);
    }
}
