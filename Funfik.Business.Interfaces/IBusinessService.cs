﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funfik.Business.Interfaces
{
    public interface IBusinessService<TEntity> where TEntity: Entity
    {
    }
}
