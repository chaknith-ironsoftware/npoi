﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPOI.SS.UserModel
{
    public partial interface ISheet : IEnumerable<IRow>
    {
        int LastPhysicalRowNumber { get; }
    }
}