﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace VEDW_Handlebars
{
    internal class Utility
    {
        public static DataTable GetDataTable(ref SqlConnection sqlConnection, string sql)
        {
            // Pass the connection to a command object
            var sqlCommand = new SqlCommand(sql, sqlConnection);
            var sqlDataAdapter = new SqlDataAdapter {SelectCommand = sqlCommand};

            var dataTable = new DataTable();

            // Adds or refreshes rows in the DataSet to match those in the data source
            try
            {
                sqlDataAdapter.Fill(dataTable);
            }

            catch (Exception)
            {
                return null;
            }

            return dataTable;
        }
    }

}