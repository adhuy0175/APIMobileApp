using Lib;
using Lib.Entities;
using Lib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAPI.Controllers
{
    public class HomeController : Controller
    {
        
        BaiHatService baiHatService = new BaiHatService();
        public ActionResult Index()
        {

            
            ViewBag.Title = "Home Page";
            /*ApplicationDbContext _dbContext;
            _dbContext = new ApplicationDbContext();
            Lib.Entities.Student st = new Lib.Entities.Student();
            st.Id = Guid.NewGuid();
            st.Name = "test";
            st.IdentifyCode = "test 2";
            _dbContext.Student.Add(st);
            _dbContext.SaveChanges();
            */
            //insertBaiHat();


            return View();
        }
        public void insertBaiHat() {
            BaiHat r = new BaiHat();
           // r.IdBaiHat = new Guid();
            r.LoiBaiHat = "test";
            r.TenBaiHat = "Sóng bão";
            r.TenCaSi = "Nhu Quynh";
            r.HinhNenBaiHat = "111";
            r.LinkBaiHat = "MP4";
            r.IdAlbum = 1;
            r.IdTheLoai = 2;          
            r.IdPlayList = 1;
            baiHatService.insertBaiHat(r);
        }
    }
}
