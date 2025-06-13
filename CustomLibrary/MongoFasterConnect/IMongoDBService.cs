using MongoDB.Driver;

namespace MongoFasterConnect;

public interface IMongoDBService
{
    IMongoCollection<T> GetCollection<T>(string name);
}