﻿using GenericExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSQL
{
    interface IUpdate: ISQL
    {
       bool UpdateSQL(Generic entity);
    }
}
