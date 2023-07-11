﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldMarket.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }
        void Save();
    }
}