﻿using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IRepositorySqlServerDinawin<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
    }
}
