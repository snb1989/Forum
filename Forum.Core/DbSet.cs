﻿using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
namespace Forum.Core
{
    public class DbSet<T> : SimpleClient<T> where T : class, new()
    {
        public DbSet(SqlSugarClient context) : base(context)
        {

        }
    }
}
