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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Edificio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
