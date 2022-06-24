using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CRUD_CSharp
{
    class SqlServerConnection

    {
        public SqlConnection GetData()
        {
            string connectionString = "Data source = localhost ; Initial Catalog = DbTest ; User = sa ; password =sa ; ";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
            
        }
    }
}
