using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AreaManager.Model;

namespace AreaManager.Controllers
{
    public class OrganizesController : Controller
    {
        private AreaManagerdbEntities db = new AreaManagerdbEntities();

        // GET: Organizes
        public async Task<ActionResult> Index()
        {
            return View(await db.Organizes.ToListAsync());
        }

        // GET: Organizes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organize organize = await db.Organizes.FindAsync(id);
            if (organize == null)
            {
                return HttpNotFound();
            }
            return View(organize);
        }

        // GET: Organizes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Organizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Description,ResponsibleUserId")] Organize organize)
        {
            if (ModelState.IsValid)
            {
                db.Organizes.Add(organize);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(organize);
        }

        // GET: Organizes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organize organize = await db.Organizes.FindAsync(id);
            if (organize == null)
            {
                return HttpNotFound();
            }
            return View(organize);
        }

        // POST: Organizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Description,ResponsibleUserId")] Organize organize)
        {
            if (ModelState.IsValid)
            {
                db.Entry(organize).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(organize);
        }

        // GET: Organizes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organize organize = await db.Organizes.FindAsync(id);
            if (organize == null)
            {
                return HttpNotFound();
            }
            return View(organize);
        }

        // POST: Organizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Organize organize = await db.Organizes.FindAsync(id);
            db.Organizes.Remove(organize);
            await db.SaveChangesAsync();
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
