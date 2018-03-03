using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasySystem.DAL;
using EasySystem.IDAL;

namespace EasySystem.DALContainer
{
    public class Container
    {
        /// <summary>
        /// IOC 容器
        /// </summary>
        public static IContainer container = null;

        /// <summary>
        /// 获取 IDal 的实例化对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            try
            {
                if (container == null)
                {
                    Initialise();
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("IOC实例化出错!" + ex.Message);
            }

            return container.Resolve<T>();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Initialise()
        {
            var builder = new ContainerBuilder();
            //格式：builder.RegisterType<xxxx>().As<Ixxxx>().InstancePerLifetimeScope();
<<<<<<< HEAD
            builder.RegisterType<StaffDAL>().As<IStaffDAL>().InstancePerLifetimeScope();
=======
            builder.RegisterType<UserDAL>().As<IUserDAL>().InstancePerLifetimeScope();
>>>>>>> 使用文本模板根据数据库表自动生产对应类
            container = builder.Build();
        }
    }
}
