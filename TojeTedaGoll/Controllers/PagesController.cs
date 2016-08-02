using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TojeTedaGoll.Data;

namespace TojeTedaGoll.Controllers
{
    public class PagesController : Controller
    {
        private TojeTedaGollRepository _tojeTedaGollRepository = null;

        public PagesController()
        {
            _tojeTedaGollRepository = new TojeTedaGollRepository();
        }
               
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Gifts()
        {
            var weddinGifts = _tojeTedaGollRepository.GetWeddingGifts();   
            return View(weddinGifts);
        }

        public ActionResult GiftDetail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var weddingGift = _tojeTedaGollRepository.GetWeddingGift((int)id);

            return View(weddingGift);
        }

        public ActionResult Schedule()
        {
            return View();
        }
    }
}