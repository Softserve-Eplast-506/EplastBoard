﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPlastBoard.DAL.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IColumnRepository Column { get; }
        IBoardReapository Boards { get; }
    }
}
