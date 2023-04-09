using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Database
    {
        public string strCon = @"Data Source=LAPTOP-0IQ7Q3Q3;Initial Catalog=OOAD1;Integrated Security=True";
        public SqlConnection sqlCon = null;
        public void OpenConnection()
        {
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if(sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
        }
    }
}
