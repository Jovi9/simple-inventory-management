using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_inventory_management_console
{
    public abstract class Connection
    {
        private string _sqlConnection;
        public Connection()
        {
            _sqlConnection = $"server=(local)\\SQLExpress;user id=;password=;database=simple_ims_console";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_sqlConnection);
        }
    }
}
