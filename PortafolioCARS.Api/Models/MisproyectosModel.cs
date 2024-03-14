

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortafolioCARS.Api.Models;

public class MisproyectosModel{
    [BsonId] //obtener el ID auto-generado por mongoDB
    [BsonRepresentation(BsonType.ObjectId)]

    public string Id {get;set;} = string.Empty;
    
    [BsonElement ("Nombre")]
    public string Nombre {get;set;} = string.Empty;
    
    [BsonElement ("Descripcion")]
    public string Descripcion {get;set;} = string.Empty;
    
    [BsonElement ("Enlace")]
    public string Enlace {get;set;} = string.Empty;

}