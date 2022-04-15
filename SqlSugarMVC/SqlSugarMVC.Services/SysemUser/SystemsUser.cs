using SqlSugar;
using SqlSugarMVC.Interfaces; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugarMVC.Models;

namespace SqlSugarMVC.Services
{
   public class SystemsUser: BaserService<SysUser>,ISystemsUser
    {
        public int _typf;
        public SystemsUser(int typf) :base(typf)
        {
            _typf = typf;
        }
        public List<SysUser> GetSysUsers()
        {
            return _Client.Queryable<SysUser>().Where(r=>r.Id!=0).ToList();
        }
    }
}
