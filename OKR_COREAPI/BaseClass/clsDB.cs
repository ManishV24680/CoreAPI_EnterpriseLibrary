using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace OKR_COREAPI.BaseClass
{
    public class clsDB
    {
        private Database database = null;

        public clsDB()
        {
            string projectPath = System.Environment.CurrentDirectory + Path.DirectorySeparatorChar; //AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(projectPath)
                .AddJsonFile("appsettings.json")
                .Build();
            string connectionString = configuration.GetConnectionString("MyConnection");

            this.database = new SqlDatabase(connectionString); //DatabaseFactory.CreateDatabase("MyConnection");
        }

        public DataTable GetDataTable(string query)
        {
            DbCommand command = database.GetSqlStringCommand(query);
            return database.ExecuteDataSet(command).Tables[0];
        }
        public DataTable GetDataTableWithParameters(string query, SqlParameter[] sqlParameter)
        {
            DbCommand command = database.GetSqlStringCommand(query);

            for (int x = 0; x < sqlParameter.Length; x++)
            {
                database.AddInParameter(command, sqlParameter[x].ParameterName, sqlParameter[x].DbType, sqlParameter[x].Value);
            }

            return database.ExecuteDataSet(command).Tables[0];
        }
        public DataSet GetDataSet(string query)
        {
            DbCommand command = database.GetSqlStringCommand(query);
            return database.ExecuteDataSet(command);
        }
        public DataSet GetDataSetWithParameters(string query, SqlParameter[] sqlParameter)
        {
            DbCommand command = database.GetSqlStringCommand(query);

            for (int x = 0; x < sqlParameter.Length; x++)
            {
                database.AddInParameter(command, sqlParameter[x].ParameterName, sqlParameter[x].DbType, sqlParameter[x].Value);
            }

            return database.ExecuteDataSet(command);
        }
    }
}
