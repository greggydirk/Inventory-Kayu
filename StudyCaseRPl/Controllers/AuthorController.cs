using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudyCaseRPl.DAL;
using StudyCaseRPl.Models;
using StudyCaseRPl.Controllers;
namespace StudyCaseRPl.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            AuthorDAL autdal = new AuthorDAL();
            var models = autdal.GetAll();
            return View(models);
            
        }

        // GET: Author/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Author/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Author/Create
        [HttpPost]
        public ActionResult Create(Author author)
        {
            try
            {
                // TODO: Add insert logic here
                AuthorDAL autdal = new AuthorDAL();
                autdal.Create(author);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Author/Edit/5
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

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Author/Delete/5
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
