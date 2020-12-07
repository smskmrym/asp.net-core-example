using Proje.Business.Interfaces;
using Proje.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Concrete
{
    class WorkManager : IWorkService
    {
        private readonly EfWorkRepository efWorkRepository;
        public WorkManager()
        {
            efWorkRepository = new EfWorkRepository();
        }
        public void Delete(Work tablo)
        {
            efWorkRepository.Delete(tablo);
        }

        public List<Work> GetAll()
        {
            return efWorkRepository.GetAll();
        }

        public Work GetWithId(int id)
        {
            return efWorkRepository.GetWithId(id);
        }

        public void Save(Work tablo)
        {
            efWorkRepository.Save(tablo);
        }

        public void Update(Work tablo)
        {
            efWorkRepository.Update(tablo);
        }
    }
}
