﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CsiOrdNum.Models;

namespace CsiOrdNum.Controllers
{
    public class Table_1Controller : Controller
    {
        private DatabaseEntities db = new DatabaseEntities();// database inatantiation

        // GET: Table_1
        public ActionResult Index()
        {
            return View(db.Table_1.ToList());
        }

        // GET: Table_1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_1 table_1 = db.Table_1.Find(id);
            if (table_1 == null)
            {
                return HttpNotFound();
            }
            return View(table_1);
        }

        // GET: Table_1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EntryValue")] Table_1 table_1)
        {
            if (ModelState.IsValid)
            {
                db.Table_1.Add(table_1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_1);
        }

        // GET: Table_1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_1 table_1 = db.Table_1.Find(id);
            if (table_1 == null)
            {
                return HttpNotFound();
            }
            return View(table_1);
        }

        // POST: Table_1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EntryValue")] Table_1 table_1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_1);
        }
        // GET: Table_1/Asc

        public ActionResult Asc()
        {
            return View(db.GetOrder01());
        }


        // GET: Table_1/Desc
        public ActionResult Desc()
        {
            return View(db.GetOrder02());
        }





        // GET: Table_1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_1 table_1 = db.Table_1.Find(id);
            if (table_1 == null)
            {
                return HttpNotFound();
            }
            return View(table_1);
        }

        // POST: Table_1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_1 table_1 = db.Table_1.Find(id);
            db.Table_1.Remove(table_1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
