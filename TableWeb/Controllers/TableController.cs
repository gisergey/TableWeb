using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using Microsoft.Identity.Client;
using TableWeb.Data;
using TableWeb.Models;

namespace TableWeb.Controllers
{
    public class TableController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TableController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<WordsData> tableDataList = _db.dataWords.ToList();
            return View(tableDataList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(WordsData wordData)
        {
            _db.dataWords.Add(wordData);
            _db.SaveChanges();
            return View("Index",_db.dataWords.ToList());
        }
    }
}
