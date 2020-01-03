//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using SEP_Framework.FrameWork.Models;
//using SEP_Framework.Utils;

//namespace SEP_Framework.FrameWork.Controllers
//{
//    class MySQLController : AbstractController
//    {
//        public MySQLController(string cnnStr)
//        {
//            this.dataHandle = new HandleDataMySQL(cnnStr);
//        }

//        public override bool AddData(Dictionary<string, string> data, string nameTable)
//        {
//            string sql = "insert into " + nameTable + " values(";
//            for (int i = 0; i < data.Count ; i++)
//            {
//                if (i < data.Count - 1)
//                {
//                    sql += ("N'" + data.ElementAt(i).Value + "', ");
//                }
//                else
//                {
//                    sql += ("N'" + data.ElementAt(i).Value + "')");
//                }
//            }

//            try
//            {
//                dataHandle.executeData(sql);
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//            return true;
//        }

//        public override void createUserTable()
//        {
//            if (!isExistUserTable())
//            {
//                var createTable = "create table Users(username varchar(30), password varchar(30),isLogin bit,ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY)";
//                dataHandle.executeData(createTable);
//            }
//        }

//        public override bool DeleteData(string data, string nameTable, string primaryKey)
//        {
//            string sql = "delete from " + nameTable;
//            sql += " where " + primaryKey + " = " + data;

//            try
//            {
//                dataHandle.executeData(sql);
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//            return true;
//        }

//        public override string GetPrimaryKey(string nameTable)
//        {
//            string sql = "SELECT u.COLUMN_NAME, c.CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS c INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS u ON c.CONSTRAINT_NAME = u.CONSTRAINT_NAME where u.TABLE_NAME = '" + nameTable + "' AND c.TABLE_NAME = '" + nameTable + "' and c.CONSTRAINT_TYPE = 'PRIMARY KEY'";
//            DataTable result = this.dataHandle.getData(sql);
//            return result.Rows[0].Field<string>(0);
//        }

//        public override bool isExistUserTable()
//        {
//            var checkTable = "SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name = 'Users'";
//            DataTable dataTable = dataHandle.getData(checkTable);
//            return dataTable.Rows.Count != 0;
//        }

//        public override bool Login(string username, string password)
//        {
//            if (Authen(username, password))
//            {
//                var login = string.Format("Update Users Set isLogin = 'true' where username ='{0}'", username);
//                if (dataHandle.executeData(login) != 0)
//                    return true;
//            }
//            return false;
//        }

//        public override bool Logout(string username)
//        {
//            var logout = string.Format("Update Users Set isLogin = 'false' where username ='{0}'", username);
//            if (dataHandle.executeData(logout) != 0)
//                return true;
//            return false;
//        }

//        public override DataTable ReadData(string nameTable)
//        {
//            string sql = "select * from " + nameTable ;
//            DataTable result = this.dataHandle.getData(sql);
//            return result;
//        }

//        private bool isExist(string username)
//        {
//            var check = string.Format("select * from Users where username = '{0}'", username);
//            var dt = dataHandle.getData(check);
//            return dt.Rows.Count != 0;
//        }

//        public override bool Register(string username, string password)
//        {
//            if (isExist(username)) return false;
//            var insert = string.Format("insert into Users values('{0}','{1}','false')", username, Crypto.Encrypt(password));
//            if (dataHandle.executeData(insert) != 0)
//                return true;
//            return false;
//        }

//        public override bool UpdateData(Dictionary<string, string> data, string nameTable, string primaryKey)
//        {
//            string sql = "update " + nameTable + " set ";
//            for (int i = 0; i < data.Count; i++)
//            {
//                if (data.ElementAt(i).Key != primaryKey)
//                {
//                    if (i < data.Count - 1)
//                    {
//                        sql += (data.ElementAt(i).Key + " = N'" + data.ElementAt(i).Value + "', ");
//                    }
//                    else
//                    {
//                        sql += (data.ElementAt(i).Key + " = N'" + data.ElementAt(i).Value + "'");
//                    }
//                }
//            }
//            sql += " where " + primaryKey + " = " + data[primaryKey];

//            try
//            {
//                dataHandle.executeData(sql);
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//            return true;
//        }

//        protected override bool Authen(string username, string password)
//        {
//            var authen = string.Format("select * from Users where username = '{0}'", username);
//            DataTable data = dataHandle.getData(authen);
//            if (data.Rows.Count != 0)
//            {
//                string u = data.Rows[0][0].ToString();
//                string p = Crypto.Decrypt(data.Rows[0][1].ToString());
//                return username == u && password == p;
//            }
//            return false;
//        }

//        public override List<string> getAllTableName(string nameDB)
//        {
//            List<string> res = new List<string>();
//            string sql = string.Format("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG ='{0}'", nameDB);
//            DataTable result = this.dataHandle.getData(sql);
//            foreach (DataRow row in result.Rows)
//            {
//                string name = row["TABLE_NAME"].ToString();
//                if(name != "Users")
//                {
//                    res.Add(name);
//                }
//            }
//            return res;
//        }
//    }
//}
