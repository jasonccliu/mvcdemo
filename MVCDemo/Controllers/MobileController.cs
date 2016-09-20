using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class MobileController : Controller
    {
        testDBEntities db = new testDBEntities();

        // GET: Mobile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult myDataGrid()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getMobileInfo(string _search, int? page, int? rows, string sord)
        {

            var result = db.Mobile20160830.ToList();

            int pageSize = rows.HasValue ? rows.Value : 10;
            int pageNum = page.HasValue ? page.Value : 1;
            int totalRecords = result.Count;
            int totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);

            var jsonData = new
            {
                total = totalPages,
                page = pageNum,
                records = totalRecords,
                rows = result.Skip((pageNum - 1) * pageSize).Take(pageSize)
            };


            //var jsonData = new
            //{
            //    total = 1,
            //    page = 1,
            //    records = db.Mobile20160830.ToList().Count,
            //    rows = (
            //      from mob in db.Mobile20160830.ToList()
            //      select new
            //      {
            //          id = mob.id,

            //          deviceos = mob.DeviceOS,
            //          devicetype = mob.DeviceType,
            //          userdisplayname = mob.UserDisplayName


            //      }).ToArray()
            //};

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}