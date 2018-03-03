using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using EasySystem.Model;

namespace EasySystem.DAL
{
    public partial class DbContextFactory
    {
        /// <summary>
        /// 创建EF上下文对象,已存在就直接取,不存在就创建,保证线程内是唯一。
        /// </summary>
        public static DbContext Create()
        {
            DbContext dbContext = CallContext.GetData("DbContext") as DbContext;
            if (dbContext==null)
            {
<<<<<<< HEAD
                dbContext=new CompanyEntities();
=======
                dbContext=new EasynewsEntities();
>>>>>>> 使用文本模板根据数据库表自动生产对应类
                CallContext.SetData("DbContext",dbContext);
            }
            return dbContext;
        }
    }
}
