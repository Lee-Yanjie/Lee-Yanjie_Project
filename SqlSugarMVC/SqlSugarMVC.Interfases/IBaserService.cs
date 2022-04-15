using System;
using System.Collections.Generic;

namespace SqlSugarMVC.Interfaces
{
    public interface IBaserService<T> where T : class, new()
    {
        bool Add(T t);
        List<T> Query();
        bool Update(T t);
        bool Delete(T t);
    }
}
