using DemoAPI.Models;
using Lib.Entities;
using Lib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DemoAPI.Controllers.api
{
    public class BaiHatController : Controller
    {
        BaiHatService baiHatService = new BaiHatService();
        [HttpPost]
        [Route("api/BaiHat/insertBaiHat")]
        public ActionResult insertBaiHat(BaiHatModel baiHat)
        {
            BaiHat r = new BaiHat();
            r.LoiBaiHat = baiHat.LoiBaiHat;
            r.TenBaiHat = baiHat.TenBaiHat;
            r.TenCaSi = baiHat.TenCaSi;
            r.HinhNenBaiHat = baiHat.HinhNenBaiHat;
            r.LinkBaiHat = baiHat.LinkBaiHat;
            r.IdAlbum = baiHat.IdAlbum;
            r.IdTheLoai = baiHat.IdTheLoai;
            r.IdPlayList = baiHat.IdPlayList;
            baiHatService.insertBaiHat(r);
            return
            Json(new
            {
                message = "sucess",
            }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        [Route("api/BaiHat/getBaiHat")]
        public ActionResult getBaiHat()
        {

            List<BaiHat> baiHats = baiHatService.GetBaiHats();
            return
            Json(new
            {
                message = "sucess",
                data = baiHats
            }, JsonRequestBehavior.AllowGet); ;
        }
        //[HttpGet]
        //[Route("api/BaiHat/getBaiHat")]
        //public ActionResult getQuangCao()
        //{

        //    List<BaiHat> baiHats = baiHatService.GetBaiHats();
        //    return
        //    Json(new
        //    {
        //        message = "sucess",
        //        data = baiHats
        //    }, JsonRequestBehavior.AllowGet); ;
        //}
    }
}