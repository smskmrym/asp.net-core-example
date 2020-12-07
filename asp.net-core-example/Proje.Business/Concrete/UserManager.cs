using Proje.Business.Interfaces;
using Proje.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly EfUserRepository efUserRepository;
        public UserManager()
        {
            efUserRepository = new EfUserRepository();
        }
        public void Delete(User tablo)
        {
            efUserRepository.Delete(tablo);
        }

        public List<User> GetAll()
        {
            return efUserRepository.GetAll();
        }

        public User GetWithId(int id)
        {
           return efUserRepository.GetWithId(id);
        }

        public void Save(User tablo)
        {
            efUserRepository.Save(tablo);
        }

        public void Update(User tablo)
        {
            efUserRepository.Update(tablo);
        }
    }
}
