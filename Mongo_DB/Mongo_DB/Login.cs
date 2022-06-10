using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo_DB
{
    public class Game
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }    
    }
}
