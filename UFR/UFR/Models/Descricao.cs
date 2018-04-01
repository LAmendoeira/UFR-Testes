using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFR.Models
{
    public class Descricao
    {
        [BsonElement("Texto")]
        public string Texto { get; set; }

        [BsonElement("Valor")]
        public int Valor { get; set; }
    }
}