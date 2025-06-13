using MongoDB.Driver;
using MongoFasterConnect;

public class MongoDBService : IMongoDBService
{
    private readonly IMongoDatabase _database;

    public MongoDBService(MongoDbSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        _database = client.GetDatabase(settings.DatabaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string name)
    {
        return _database.GetCollection<T>(name);
    }
}
