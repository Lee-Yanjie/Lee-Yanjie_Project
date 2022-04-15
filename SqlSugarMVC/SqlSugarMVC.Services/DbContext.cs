using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarMVC.Services
{
    public class DbContext
    {

        #region 数据库连接
        /// <summary>
        /// db Connection
        /// </summary>
        /// <returns></returns>
        public SqlSugarClient GetClient(int typeOf)  //SqlSugarClient和SqlSugarScope都行
        {
            string ConnectionString = null;
            if (typeOf == 1)
            {
                ConnectionString = "Data Source =.; Initial Catalog = SqlSugarCustomerDB; Integrated Security = True";
            }
            else
            {  
                //多个服务器
                ConnectionString = null;
            }
            return new SqlSugarClient(new ConnectionConfig()
            {
                DbType = SqlSugar.DbType.SqlServer, //SqlServer Sqlite Oracle
                //注意配置
                ConnectionString = ConnectionString,
                IsAutoCloseConnection = true,
                AopEvents = new AopEvents
                {
                    OnLogExecuting = (sql, p) =>
                    {
                        Console.WriteLine(sql);
                        Console.WriteLine(string.Join(",", p?.Select(it => it.ParameterName + ":" + it.Value)));
                    }
                }

            });

        }
        #endregion
    }
}
