﻿using BancoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp.Data
{
    public interface IRegisterable
    {
        int Register(Account a);
    }
}
