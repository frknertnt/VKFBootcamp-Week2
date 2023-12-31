﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager//Bir çok repomuz olabilir bunlara manager üzerinden erişim vereceğiz(Unit of work)
    {
        IBookRepository Book { get; }
        IUserRepository User { get; }
        void Save();
    }
}
