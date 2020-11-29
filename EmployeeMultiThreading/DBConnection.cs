using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeeMultiThreading
{
    /// <summary>
    /// database connection class
    /// </summary>
    class DBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {

            ///Specifying the connection string from the sql server connection
            string connectionString = @"Data Source=RAMYA\SQLEXPRESS;Initial Catalog=payroll_services;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
