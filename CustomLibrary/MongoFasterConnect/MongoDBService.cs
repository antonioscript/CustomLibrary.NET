using MongoDB.Driver;

namespace MongoFasterConnect;
public class MongoDBService : IMongoDBService
{
    private readonly IMongoDatabase _database;

    public MongoDBService(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string name)
    {
        return _database.GetCollection<T>(name);
    }
}