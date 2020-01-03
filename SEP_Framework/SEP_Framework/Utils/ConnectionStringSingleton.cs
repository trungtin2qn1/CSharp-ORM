using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_Framework.Utils
{
    class DBInfoSingleton
    {
        private String cnnString;
        private String nameDB;
        private static DBInfoSingleton dbInfoSingleton;
        private DBInfoSingleton() {
            this.cnnString = @"Server=localhost;Database=mydb;Uid=root;Pwd=123123";
            this.nameDB = "mydb";
            //this.cnnString = @"Data Source=MAYTINH-HE52SNT;Initial Catalog=FootballPlayer;Integrated Security=True";
            //this.nameDB = "FootballPlayer";
        }

        public static DBInfoSingleton getInstance()
        {
            if (dbInfoSingleton == null)
                dbInfoSingleton = new DBInfoSingleton();
            return dbInfoSingleton;
        }

        public String getCnnString()
        {
            return cnnString;
        }
        public String getNameDB()
        {
            return nameDB;
        }
    }
}
