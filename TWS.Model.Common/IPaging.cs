﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.Model.Common
{
    public interface IPaging
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }
}
