using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFR.Models
{
    public class Edificio
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Nome")]
        public string Nome { get; set; }

        //O elemento Descricao é um Embedded Document
        [BsonElement("Descricao")]
        public Descricao Descricao { get; set; }
    }
}