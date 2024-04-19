using KtraTxuyen1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KtraTxuyen1.Controllers
{
    public class QuanlyNhanvienController : Controller
    {
        // GET: QuanlyNhanvien
        public static List<Nhanvien> nhanviens;
        public QuanlyNhanvienController()
        {
            nhanviens = new List<Nhanvien>()
            {
                new Nhanvien("NV01", "Nguyễn Vân Anh", "Hà nội", 15, 200000),
                new Nhanvien("NV02", "Lê Thu Hà", "Hà nội", 27, 250000),
                new Nhanvien("NV03", "Nguyễn Văn Hoàng", "Hà nội", 18, 250000),
                new Nhanvien("NV04", "Trần Thu Hương", "Hà nội", 25, 190000),
                new Nhanvien("NV05", "Ngô Phương Thảo", "Hà nội", 20, 180000),
            };

        }
        public ActionResult Index()
        {
            var danhSach1 = nhanviens.Where(x => x.songaylam < 20).ToList();
            var danhSach2 = nhanviens.Where(x => x.luongngay > 190000).ToList();
            ViewBag.DanhSach1 = danhSach1;
            ViewBag.DanhSach2 = danhSach2;
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Nhanvien model)
        {
            return RedirectToAction("HienThiAdd", model);
        }
        public ActionResult HienThiAdd(Nhanvien data)
        {
           return View(data);
        }

    }
}