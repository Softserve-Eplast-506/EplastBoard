﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPlastBoard.DAL.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IColumnRepository Columns { get; }

        Task SaveAsync();
    }
}
