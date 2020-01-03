using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_Framework.FrameWork.Models
{
    public class HandleDataSQLServer : AbstractHandleData
    {

        public HandleDataSQLServer(string url)
        {
            this.connect = new SqlConnection(url);
        }

        public override int executeData(string sql)
        {
            SqlCommand sql_query = new SqlCommand(sql, (SqlConnection)this.connect);
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
                SqlDataAdapter adapt = new SqlDataAdapter(sql, (SqlConnection)this.connect);

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
            SqlCommand lenh = new SqlCommand(sql, (SqlConnection)this.connect);
            this.connect.Open();

            SqlDataReader dr = lenh.ExecuteReader();

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
