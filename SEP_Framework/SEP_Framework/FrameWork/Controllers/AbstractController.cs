using SEP_Framework.FrameWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_Framework.FrameWork.Controllers
{
    public abstract class AbstractController
    {
        protected AbstractHandleData dataHandle;

        //public abstract DataTable ReadDataFirstTime(string nameTable);

        public abstract List<string> getAllTableName(string nameDB);

        public abstract string GetPrimaryKey(string nameTable);

        public abstract DataTable ReadData(string nameTable);

        public abstract bool AddData(Dictionary<string, string> data, string nameTable);

        public abstract bool UpdateData(Dictionary<string, string> data, string nameTable, string primaryKey);

        public abstract bool DeleteData(string data, string nameTable, string primaryKey);

        //public abstract bool InitData(string nameTable);

        public abstract bool isExistUserTable();

        public abstract void createUserTable();

        protected abstract bool Authen(string username, string password);

        public abstract bool Login(string username, string password);

        public abstract bool Register(string username, string password);

        public abstract bool Logout(string username);
    }
}
