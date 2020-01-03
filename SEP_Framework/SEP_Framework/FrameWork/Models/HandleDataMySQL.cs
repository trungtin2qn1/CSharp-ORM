using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SEP_Framework.FrameWork.Models
{
    class HandleDataMySQL : AbstractHandleData
    {
        public HandleDataMySQL(string url)
        {
            this.connect = new MySqlConnection(url);
        }

        public override int executeData(string sql)
        {
            MySqlCommand sql_query = new MySqlCommand(sql, this.connect);
            this.connect.Open();
            int result = 1;
            try
            {
                result = sql_query.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                this.connect.Close();
                throw ex;
            }

            this.connect.Close();
            return result;
        }

        public override DataTable getData(string sql)
        {
            this.connect.Open();
            try
            {
                MySqlDataAdapter  adapt = new MySqlDataAdapter (sql, this.connect);

                DataTable table_data = new DataTable();
                adapt.Fill(table_data);
                this.connect.Close();
                return table_data;
            }
            catch (Exception ex)
            {
                this.connect.Close();
                throw ex;
            }
        }

        public override bool isExist(string sql)
        {
            MySqlCommand lenh = new MySqlCommand(sql, this.connect);
            this.connect.Open();

            MySqlDataReader dr = lenh.ExecuteReader();

            if (dr.Read() == true)
            {
                this.connect.Close();
                return true;
            }
            else
            {
                this.connect.Close();
                return false;
            }
        }

    }
}
