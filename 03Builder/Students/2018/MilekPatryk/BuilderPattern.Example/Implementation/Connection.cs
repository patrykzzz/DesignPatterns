namespace BuilderPattern.Example.Implementation
{
    public class Connection
    {
        private readonly string _connectionString;

        public Connection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public override string ToString()
        {
            return _connectionString;
        }
    }
}