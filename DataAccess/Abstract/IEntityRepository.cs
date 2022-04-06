using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //IEntityRepository newlendiğinde T tiğinde bir değer almalı , bu T değeri bir class olmalı,IEntity tpinde olmalı,
    //newlenebilmeli. Yani IEntitynin referansını tuttuğu Car , Brand ve Color vb. classları olmalı.
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        List<T> Get(Expression<Func<T,bool>>filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
