using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataContextLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelClass;
using MongoDB.Bson;
using MongoDB.Driver;



namespace CosmosDb_Demo_Crud.Controllers
{
    public class ProductsController : Controller
    {
        clsMongoDbDataContext _dbContext = new clsMongoDbDataContext("Products");

        // GET: Products
        public async Task<ActionResult> Index()
        {
            IEnumerable<Product> products = null;
            using (IAsyncCursor<Product> cursor = await this._dbContext.GetProducts.FindAsync(new BsonDocument()))
            {
                while (await cursor.MoveNextAsync())
                {
                    products = cursor.Current;
                }
            }
            return View(products);
        }

        // GET: Products/Details/5
        [HttpGet]
        public async Task<ActionResult> Details(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                FilterDefinition<Product> filter = Builders<Product>.Filter.Eq("_id", ObjectId.Parse(id));
                IEnumerable<Product> entity = null;
                using (IAsyncCursor<Product> cursor = await this._dbContext.GetProducts.FindAsync(filter))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        entity = cursor.Current;
                    }
                }
                return View(entity.FirstOrDefault());
            }
            return RedirectToAction("Index");
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                model.CreatedDate = DateTime.UtcNow;
                model.id = model.ProductId.ToString();

                await this._dbContext.GetProducts.InsertOneAsync(model);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                FilterDefinition<Product> filter = Builders<Product>.Filter.Eq("_id", ObjectId.Parse(id));
                IEnumerable<Product> entity = null;
                using (IAsyncCursor<Product> cursor = await this._dbContext.GetProducts.FindAsync(filter))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        entity = cursor.Current;
                    }
                }
                return View(entity.FirstOrDefault());
            }
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, Product model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                model.UpdatedDate = DateTime.UtcNow;
                model.ObjectId = ObjectId.Parse(id);
                FilterDefinition<Product> filter = Builders<Product>.Filter.Eq("_id", ObjectId.Parse(id));
                await this._dbContext.GetProducts.ReplaceOneAsync(filter, model, new UpdateOptions() { IsUpsert = true });               
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public async Task<ActionResult> Delete(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                FilterDefinition<Product> filter = Builders<Product>.Filter.Eq("id", id);
                IEnumerable<Product> entity = null;
                using (IAsyncCursor<Product> cursor = await this._dbContext.GetProducts.FindAsync(filter))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        entity = cursor.Current;
                    }
                }
                return View(entity.FirstOrDefault());
            }
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, Product model)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    return View(model);
                }
                //model.ObjectId = ObjectId.Parse(id);
                //FilterDefinition<Product> filter = Builders<Product>.Filter.Eq("_id", ObjectId.Parse(id));
                FilterDefinition<Product> filter = Builders<Product>.Filter.Eq("id", id);
                await this._dbContext.GetProducts.DeleteOneAsync(filter);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}