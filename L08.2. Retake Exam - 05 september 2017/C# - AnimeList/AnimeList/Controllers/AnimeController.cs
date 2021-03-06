﻿namespace AnimeList.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class AnimeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new AnimeListDbContext())
            {
                var animes = db.Animes.ToList();

                return View(animes);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Anime anime)
        {
            using (var db = new AnimeListDbContext())
            {
                db.Animes.Add(anime);
                db.SaveChanges();
                return Redirect("/");
            }
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            using (var db = new AnimeListDbContext())
            {
                var anime = db.Animes.Find(id);

                return View(anime);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Anime animeModel)
        {
            using (var db = new AnimeListDbContext())
            {
                var anime = db.Animes.Find(id);

                db.Animes.Remove(anime);
                db.SaveChanges();

                return Redirect("/");
            }
        }
    }
}