using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UFR.Models
{
    //Para ignorar elementos não encontrados no Document
    //[BsonIgnoreExtraElements]
    public class Descricao
    {
        [BsonElement("Texto")]
        public string Texto { get; set; }

        //Nota o BsonElement só é preciso se o nome do atributo na class não corresponder ao que está no mongoDb
        public int Valor { get; set; }

        [BsonElement("Opcoes")]
        public IEnumerable<string> Opcoes { get; set; }

    }
}