using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_Framework.FrameWork.Models
{
    public abstract class AbstractHandleData
    {
        protected SqlConnection connect;

        public abstract DataTable getData(string sql);

        public abstract int executeData(string sql);

        public abstract bool isExist(string sql);
    }
}
