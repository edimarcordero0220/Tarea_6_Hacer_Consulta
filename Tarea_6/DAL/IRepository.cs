﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{


   interface IRepository<TEntity> : IDisposable where TEntity : class
  {
    TEntity Guardar(TEntity nuevo);
    TEntity Buscar(Expression<Func<TEntity, bool>> criterio);
    bool Modificar(TEntity criterio);
    bool Eliminar(TEntity criterio);
    List<TEntity> GetList(Expression<Func<TEntity, bool>> criterio);
    List<TEntity> GetListTodo();
  }
}
