﻿using Toygar.DB.Data.nDataService.nDatabase.nEntity;
using Toygar.DB.Data.nDataService.nDatabase.nQuery.nOrderBy.nAsc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Toygar.DB.Data.nDataService.nDatabase.nQuery.nOrderBy
{
    public interface IOrderBy<TEntity> where TEntity : cBaseEntity
    {
        IAscDesc<TEntity> Asc(params Expression<Func<object>>[] _Columns);
        IAscDesc<TEntity> Asc(params Expression<Func<TEntity, object>>[] _Columns);
        IAscDesc<TEntity> Asc(string _ColumnName, bool _UseAlias = true);
        IAscDesc<TEntity> Asc<TRelationEntity>() where TRelationEntity : cBaseEntity;
        IAscDesc<TEntity> Asc<TAlias>(Expression<Func<TAlias>> _Alias, string _ColumnName) where TAlias : cBaseEntity;

        IAscDesc<TEntity> Desc(params Expression<Func<object>>[] _Columns);
        IAscDesc<TEntity> Desc(params Expression<Func<TEntity, object>>[] _Columns);
        IAscDesc<TEntity> Desc(string _ColumnName, bool _UseAlias = true);
        IAscDesc<TEntity> Desc<TRelationEntity>() where TRelationEntity : cBaseEntity;
        IAscDesc<TEntity> Desc<TAlias>(Expression<Func<TAlias>> _Alias, string _ColumnName) where TAlias : cBaseEntity;
    }
}
