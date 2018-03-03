using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//
namespace Util
{
    public class AutoClass
    {
        public void CreateClass(string ClassName)
        {
            CreateBLL(ClassName);
            CreateIBLL(ClassName);
            CreateDAL(ClassName);
            CreateIDAL(ClassName);
        }
        private void CreateIBLL(string ClassName) {
            string FilePath = "../../../EasySystem.IBLL/" + "I" + ClassName + "Service" + ".cs";
                Stream s = File.Open(FilePath, FileMode.Create);
                StreamWriter wrtr = new StreamWriter(s);
                wrtr.WriteLine("//自动生成" + "I" + ClassName + "Service");
                wrtr.WriteLine("using EasySystem.Model;");
                wrtr.WriteLine("namespace EasySystem.IBLL{");
                wrtr.WriteLine("\t public partial interface I{0}Service : IBaseService<{0}>", ClassName);
                wrtr.WriteLine("\t {");
                wrtr.WriteLine("\t }");
                wrtr.WriteLine("}");
                wrtr.Close();
                s.Close();
        }
        private void CreateIDAL(string ClassName) {
            string FilePath = "../../../EasySystem.IDAL/" + "I" + ClassName + "DAL" + ".cs";
                Stream s = File.Open(FilePath, FileMode.Create);
                StreamWriter wrtr = new StreamWriter(s);
                wrtr = new StreamWriter(s);
                wrtr.WriteLine("//自动生成" + "I" + ClassName + "DAL");
                wrtr.WriteLine("using EasySystem.Model;");
                wrtr.WriteLine("namespace EasySystem.IDAL{");
                wrtr.WriteLine("\t public partial interface I{0}DAL : IBaseDAL<{0}>", ClassName);
                wrtr.WriteLine("\t {");
                wrtr.WriteLine("\t }");
                wrtr.WriteLine("}");
                wrtr.Close();
                s.Close();
        }
        private void CreateBLL(string ClassName) {
            string FilePath = "../../../EasySystem.BLL/" + ClassName + "Service" + ".cs";
                Stream s = File.Open(FilePath, FileMode.Create);
                StreamWriter wrtr = new StreamWriter(s);

                wrtr = new StreamWriter(s);
                wrtr.WriteLine("//自动生成" + ClassName + "Service");
                wrtr.WriteLine("using EasySystem.IBLL;");
                wrtr.WriteLine("using EasySystem.IDAL;");
                wrtr.WriteLine("using EasySystem.Model;");
                wrtr.WriteLine("namespace EasySystem.BLL{");
                wrtr.WriteLine("\t public partial class {0}Service : BaseService<{0}>, I{0}Service", ClassName);
                wrtr.WriteLine("\t {");
                wrtr.WriteLine("\t \t private I{0}DAL {0}DAL = DALContainer.Container.Resolve<I{0}DAL>();", ClassName);
                wrtr.WriteLine("\t \t public override void SetDal()");
                wrtr.WriteLine("\t \t {");
                wrtr.WriteLine("\t \t \t Dal = " + ClassName + "DAL;");
                wrtr.WriteLine("\t \t }");
                wrtr.WriteLine("\t }");
                wrtr.WriteLine("}");
                wrtr.Close();
                s.Close();
        }
        private void CreateDAL(string ClassName) {
            string FilePath = "../../../EasySystem.DAL/" + ClassName + "DAL" + ".cs";
                Stream s = File.Open(FilePath, FileMode.Create);
                StreamWriter wrtr = new StreamWriter(s);

                wrtr = new StreamWriter(s);
                wrtr.WriteLine("//自动生成" + ClassName + "DAL");
                wrtr.WriteLine("using EasySystem.IDAL;");
                wrtr.WriteLine("using EasySystem.Model;");
                wrtr.WriteLine("namespace EasySystem.DAL{");
                wrtr.WriteLine("\t public partial class {0}DAL : BaseDAL<{0}>, I{0}DAL", ClassName);
                wrtr.WriteLine("\t {");
                wrtr.WriteLine("\t }");
                wrtr.WriteLine("}");

                wrtr.Close();
                s.Close();
        }
    }
}

