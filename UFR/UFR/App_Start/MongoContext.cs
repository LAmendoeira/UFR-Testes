using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace UFR.App_Start
{
    public class MongoContext
    {
        MongoClient client;
        public IMongoDatabase database;

        public MongoContext()
        {
            
            // Ler as settings
            var MongoDatabaseName = ConfigurationManager.AppSettings["MongoDatabaseName"]; //UfrDatabase  
            //string MongoUsername = ConfigurationManager.AppSettings["MongoUsername"]; //ufradmin  
            //string MongoPassword = ConfigurationManager.AppSettings["MongoPassword"]; //Password  
            //string MongoPort = ConfigurationManager.AppSettings["MongoPort"];  //27017  
            //string MongoHost = ConfigurationManager.AppSettings["MongoHost"];  //localhost  

            //Connection String
            //var client = new MongoClient("mongodb://ufradmin:MJU7nhy6@localhost:27017/UfrDatabase");
            var connString = ConfigurationManager.ConnectionStrings["UfrDatabaseConnString"].ToString();

            client = new MongoClient(connString);
            database = client.GetDatabase(MongoDatabaseName);
        }
    }
}