using SqlSugarMVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugarMVC.Models;

namespace SqlSugarMVC.Interfaces
{
    public interface ISystemsUser: IBaserService<SysUser>
    {
        List<SysUser> GetSysUsers();
    }
}
