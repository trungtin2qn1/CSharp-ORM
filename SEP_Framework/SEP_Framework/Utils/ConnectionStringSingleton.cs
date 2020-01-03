using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_Framework.Utils
{
    class ConnectionStringSingleton
    {
        private String cnnString;
        private String dbName;
        private static ConnectionStringSingleton cnnStringSingleton;
        private ConnectionStringSingleton()
        {
            this.cnnString = @"Data Source=DESKTOP-K26N63K\SQLEXPRESS;Initial Catalog=QuanLiThuVien;Integrated Security=SSPI";
            this.dbName = "QuanLiThuVien";
        }

        public static ConnectionStringSingleton getInstance()
        {

            Debug.WriteLine(cnnStringSingleton);

            if (cnnStringSingleton == null)
                cnnStringSingleton = new ConnectionStringSingleton();
            return cnnStringSingleton;
        }

        public String getCnnString()
        {
            return cnnString;
        }

        public String getDBName()
        {
            return dbName;
        }
    }
}
