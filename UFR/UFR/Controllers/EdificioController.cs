using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UFR.App_Start;
using UFR.Models;

namespace UFR.Controllers
{
    public class EdificioController : Controller
    {
        //Ligação à bd
        MongoContext dbContext;

        public EdificioController()
        {
            //Instanciar a ligação
            dbContext = new MongoContext();
        }

        // GET: Edificio
        public ActionResult Index()
        {
            //Query de select all na collection Edificios
            var edificios = dbContext.database.GetCollection<Edificio>("Edificios").Find(new BsonDocument()).ToList();
            return View(edificios);
        }

        // GET: Edificio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Edificio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Edificio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var nome = Convert.ToString(collection["Nome"]);
                var descTexto = Convert.ToString(collection["Descricao.Texto"]);
                var descValor = Convert.ToInt32(collection["Descricao.Valor"]);

                var doc = new BsonDocument
                {
                    { "Nome", nome } ,
                    { "Descricao", new BsonDocument { { "Texto", descTexto }, { "Valor", descValor }, { "Opcoes", new BsonArray { "Opp", "Opp2" } } } }
                };

                //System.Diagnostics.Debug.WriteLine(doc.ToString());
                dbContext.database.GetCollection<BsonDocument>("Edificios").InsertOne(doc);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Edificio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Edificio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Edificio/Delete/5
        public ActionResult Delete(string id)
        {
            var collection = dbContext.database.GetCollection<Edificio>("Edificios");
            //var filter = Builders<Edificio>.Filter.Eq("_id", id);
            var filter = Builders<Edificio>.Filter.Eq("_id", BsonObjectId.Create(id));

            var edificio = dbContext.database.GetCollection<Edificio>("Edificios").Find(filter).ToList();
            return View(edificio);
        }

        // POST: Edificio/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                var filter = Builders<BsonDocument>.Filter.Eq("_id", BsonObjectId.Create(id));
                dbContext.database.GetCollection<BsonDocument>("Edificios").DeleteOne(filter);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
