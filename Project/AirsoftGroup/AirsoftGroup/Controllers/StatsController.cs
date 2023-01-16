using AirsoftGroup.Data;
using AirsoftGroup.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirsoftGroup.Controllers
{
    public class StatsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StatsController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: StatsController
        public ActionResult Index()
        {
            IEnumerable<Stats> StatsController = _db.Stats;
            return View(StatsController);
        }

        // GET: StatsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StatsController/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: StatsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Stats obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET: StatsController/Edit/5
        public ActionResult Edit(int id)
        {
            Stats stats = _db.Stats.Find(id);
            if (stats != null)
            {
                return View(stats);
            }
            return View();
        }

        // POST: StatsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Stats obj)
        {
            Stats stats = _db.Stats.Find(id);
            try // Problem za ist id
            {
                _db.Update(obj);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }
            return RedirectToAction("Index");
        }

        // GET: StatsController/Delete/5
        public ActionResult Delete(int id)
        {
            // Get Details from Db and present in Delete form
            Stats stats = _db.Stats.Find(id);
            if (stats != null)
            {
                return View(stats);
            }
            return RedirectToAction("Index");
        }

        // POST: StatsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Stats stats = _db.Stats.Find(id);
            _db.Stats.Remove(stats);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
