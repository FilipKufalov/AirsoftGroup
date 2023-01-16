using AirsoftGroup.Data;
using AirsoftGroup.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirsoftGroup.Controllers
{
    public class ChatController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ChatController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: ChatController
        public ActionResult Index()
        {
            IEnumerable<Chat> chatControllers = _db.ChatBox;
            return View(chatControllers);
        }

        public IActionResult Submit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(Chat obj)
        {
            if (ModelState.IsValid)
            {
                obj.messageCreated = DateTime.Now;
                _db.ChatBox.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
