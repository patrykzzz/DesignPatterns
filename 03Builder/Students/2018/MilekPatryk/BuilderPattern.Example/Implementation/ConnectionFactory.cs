namespace BuilderPattern.Example.Implementation
{
    public static class ConnectionFactory
    {
        public static Connection CreatePostgreSqlConnection()
        {
            return new Connection("PostgreSQL connection string");
        }

        public static Connection CreateMSSQLConnection()
        {
            return new Connection("MSSQL connection string");
        }

        public static Connection CreateAzureSQLConnection()
        {
            return new Connection("AzureSQL connection string");
        }
    }
}