using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasySystem.IBLL;
using EasySystem.IDAL;
using EasySystem.Model;

namespace EasySystem.BLL
{
    public partial class StaffService : BaseService<Staff>, IStaffService
    {
        private IStaffDAL StaffDAL = DALContainer.Container.Resolve<IStaffDAL>();
        public override void SetDal()
        {
            Dal = StaffDAL;
        }
    }
}
