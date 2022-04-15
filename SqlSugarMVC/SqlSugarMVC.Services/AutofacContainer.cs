using Autofac;
using SqlSugarMVC.Interfaces;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarMVC.Services
{
   public class AutofacContainer
    {
        /// <summary>
        /// IOC容器
        /// </summary>
        public static IContainer container = null;


        public static T Resolve<T>()
        {
            try
            {
                if (container==null)
                {
                    Initialise();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("IOC实例化出错："+ex.Message.ToString());
            }
            return container.Resolve<T>();
        }
        public static void Initialise()
        {
            var builder = new ContainerBuilder();
            builder.Register(c => new SystemsUser(1)).As<ISystemsUser>();//带参数写法
            //builder.RegisterType<SystemsUser>().As<ISystemsUser>().InstancePerLifetimeScope();//不带参数写法
            container = builder.Build();
        }
    }
}
