using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zaatra.Services;

namespace Zaatra.Controllers
{
    public class HotelController : BaseController
    {
        readonly HotelService _hotelService = new HotelService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllHotels()
        {
            var hotels = _hotelService.GetHotelList();
            return Json(hotels, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int id = 0)
        {
            var hotel = _hotelService.GetHotel(id);
            return View(hotel);
        }
    }
}
