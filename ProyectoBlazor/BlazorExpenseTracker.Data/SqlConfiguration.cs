using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorExpenseTracker.Data
{

    public class SqlConfiguration
    {
        public string connectionString { get; }
        public SqlConfiguration(string connectionString) => ConnectionStrong = connectionString;
        public string ConnectionStrong { get; }
    }


}
