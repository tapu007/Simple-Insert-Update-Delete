using Person.BLL.Contract;
using Person.Models.EntityModels;
using Person.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.BLL.Manager
{
    public class PersonageManager : BaseManager<Personage>, IPersonageManager
    {
        protected IPersonageRepository _personageRepository;
        public PersonageManager(IPersonageRepository baseRepository) : base(baseRepository)
        {
            _personageRepository = baseRepository;
        }

        public override bool Add(Personage personage)
        {
            if (personage.PhoneNo.Length < 11 || personage.PhoneNo.Length > 11)
            {
                throw new Exception("Phone Number must be 11 characters long");
            }
            if (IsPersonageEmailExist(personage.Email))
            {
                throw new Exception("This Email Is Allready Exist");
            }
            return base.Add(personage);
        }
        public bool IsPersonageEmailExist(string email)
        {
            return _personageRepository.IsPersonageExist(email);
        }

        public Personage GetInfoBy(int personageId)
        {
            return _personageRepository.GetInfoBy(personageId);
        }
    }
}
