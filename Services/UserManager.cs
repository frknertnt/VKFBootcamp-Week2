﻿using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserManager : IUserService
    {
        private readonly IRepositoryManager _manager;

        public UserManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public bool Login(string username, string password)
        {
            bool exist = _manager.User.Login(username, password);
            return exist;
        }
    }
}
