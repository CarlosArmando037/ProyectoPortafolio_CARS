using PortafolioCARS.Api.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using PortafolioCARS.Api.Configurations;

namespace PortafolioCARS.Api.Services;
public class ProyectoServices{
    private readonly IMongoCollection<MisproyectosModel> _proyectosCollection;

    public ProyectoServices(
        IOptions<DatabaseSettings> databaseSettings)
    {
        //inicializar cliente de MongoDB
        var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);
        //conectar a la base de datos de Mongo
        var mongoDB =
        mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
        _proyectosCollection = 
        mongoDB.GetCollection<MisproyectosModel>
            (databaseSettings.Value.CollectionName);
    }

    public async Task<List<MisproyectosModel>> GetAsync() =>
        await _proyectosCollection.Find(_ => true).ToListAsync();
    
}