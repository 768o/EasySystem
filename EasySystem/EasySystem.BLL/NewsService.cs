//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasySystem.BLL
{
    using System;
    using System.Collections.Generic;
    
    using EasySystem.IBLL;
    using EasySystem.IDAL;
    using EasySystem.Model;
    public partial class NewsService : BaseService<News>, INewsService
    {
    	private INewsDAL NewsDAL = DALContainer.Container.Resolve<INewsDAL>();
    	 	 public override void SetDal()
    	 	 {
    	 	 	 Dal = NewsDAL;
    	 	 }
    	 }
}
