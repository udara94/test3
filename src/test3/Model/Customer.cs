using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test3.Model
{
    public class Customer
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public int CustomerId { get; set; }
        [BsonElement]
        public string CustomerName { get; set; }
        [BsonElement]
        public string Address { get; set; }
    }
}
