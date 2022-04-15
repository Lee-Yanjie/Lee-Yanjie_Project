using SqlSugarMVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using System.Threading.Tasks;

namespace SqlSugarMVC.Services
{
    public class BaserService<T> where T : class, new()
    {
        protected ISqlSugarClient _Client;
        public string sqlString;
        public BaserService(int typf)
        {
            this._Client = new DbContext().GetClient(typf);
            this._Client.Aop.OnLogExecuting = (sql, pars) =>
             {
                 sqlString = sql + "\r\n" +
                  _Client.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value));
                //Console.WriteLine(sql + "\r\n" + 
                //    _Client.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value))); 
                //Console.WriteLine();

            };
        }
        public bool Add(T t)
        {
            throw new NotImplementedException();
        }
        public bool Delete(T t)
        {
            throw new NotImplementedException();
        }
        public List<T> Query()
        {
            return _Client.Queryable<T>().ToList();

        }
        public bool Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
