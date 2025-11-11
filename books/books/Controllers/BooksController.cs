using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using books.Models;

namespace books.Controllers
{
    public class BooksController : Controller
    {
        Book myBook = new Book( "El general y su laberinto", "Gabriel Garcia Marquez", 1998);
        private List<Book> booksList = new List<Book>();

        // GET: BooksController
        public ActionResult Index()
        {
            booksList.Add(myBook);
            booksList.Add( new Book ( "Tebas las 100 puertas", "Desconocido", 2000));
            booksList.Add(new Book( "Nunca Pares", "Phil Knight", 2010));

            return View(booksList);

        }

        public ActionResult Detalle()
        {
           
            return View();

        }

        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
