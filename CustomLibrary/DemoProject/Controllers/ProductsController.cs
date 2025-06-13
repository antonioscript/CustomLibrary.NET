using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoFasterConnect;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMongoCollection<Product> _collection;

    public ProductsController(IMongoDBService mongo)
    {
        _collection = mongo.GetCollection<Product>("Products");
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var all = await _collection.Find(_ => true).ToListAsync();
        return Ok(all);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Product product)
    {
        await _collection.InsertOneAsync(product);
        return Ok();
    }
}

public class Product
{
    public string Id { get; set; }
    public string Name { get; set; }
}
