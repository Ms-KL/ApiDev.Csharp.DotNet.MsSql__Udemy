using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace HelloWorld.Data
{
    public class DataContextDapper
    {
        // --- declare fields and methods
        
        // --- create connection to database 
            // make private field with _ so only accessible in class
        private string _connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

        // --- create custom methods()
            // make public so can call method
            // use generics <T> to make dynamic, rather than specifically calling <Computer> model
            // without <T> after LoadData there will be error as return not defined        
            // return IEnumerable
        
        public IEnumerable<T> LoadData<T>(string sql)

        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Query<T>(sql); // Query = multiple returns
        }

        public T LoadDataSingle<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.QuerySingle<T>(sql); // Query = single returns
        }        

        public bool ExecuteSql(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return (dbConnection.Execute(sql) > 0); 
            // executed return = number of rows affected
            // is executed result more than 0? true/false
        }     

        public int ExecuteSqlWithRowCount(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Execute(sql); 
            // executed return = number of rows affected
        }     
    }
}