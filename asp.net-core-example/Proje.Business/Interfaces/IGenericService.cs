﻿using Proje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Interfaces
{
    public interface IGenericService<Tablo> where Tablo : class, ITablo, new()
    {
        void Save(Tablo tablo);
        void Delete(Tablo tablo);
        void Update(Tablo tablo);
        Tablo GetWithId(int id);
        List<Tablo> GetAll();
    }
}
