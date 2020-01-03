using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_Framework.Utils
{
    class ConnectionStringSingleton
    {
        private String cnnString;
        private static ConnectionStringSingleton cnnStringSingleton;
        private ConnectionStringSingleton() {
            this.cnnString = @"Data Source=Tu-PC,1433,Initial Catalog=design_pattern_db;Integrated Security=True"; 
        }

        public static ConnectionStringSingleton getInstance()
        {
            if (cnnStringSingleton == null)
                cnnStringSingleton = new ConnectionStringSingleton();
            return cnnStringSingleton;
        }

        public String getCnnString()
        {
            return cnnString;
        }
    }
}
