using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Student_Repository.Common
{
    public class Helper
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;

        public Helper(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = this.configuration.GetConnectionString("CompanyConnStr");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(connectionString);
    }
}

