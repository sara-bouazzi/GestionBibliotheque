using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using T.Core.Services;
using T.Core.Domaine;

namespace T.UI.WEB.Controllers
{
    public class PretLivreController : Controller
    {
        readonly IService<PretLivre> pretlivreservice;
        public PretLivreController(IService<PretLivre> pretlivreservice)
        {
            this.pretlivreservice = pretlivreservice;
        }
        // GET: PretLivreController
        public ActionResult Index()
        {
            return View(pretlivreservice.GetAll());
        }

        // GET: PretLivreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PretLivreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PretLivreController/Create
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

        // GET: PretLivreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PretLivreController/Edit/5
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

        // GET: PretLivreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PretLivreController/Delete/5
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
