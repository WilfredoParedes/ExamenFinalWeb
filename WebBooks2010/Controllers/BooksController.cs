using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBooks2010.DataAccess;
using WebBooks2010.Model;

namespace WebBooks2010.Controllers
{
    public class BooksController : Controller
    {
        

    private BooksData _book = new BooksData();
    // GET: Client
    public ActionResult Index()
    {


        return View(_book.GetList());
    }

    public ActionResult Create()
    {
        return View(new Books());

    }
    [HttpPost]
    public ActionResult Create(Books book)
    {
        if (ModelState.IsValid)
        {
            _book.Add(book);
            return RedirectToAction("Index");
        }
        return View();
    }

}
}