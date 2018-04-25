using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DXWebApplication1.Controllers
{
    public class libroController : Controller
    {
        //
        // GET: /libro/
        public ActionResult Index()
        {
            return View();
        }

        DXWebApplication1.Models.BIBLIOTECAEntities db = new DXWebApplication1.Models.BIBLIOTECAEntities();

        [ValidateInput(false)]
        public ActionResult GridView1Partial()
        {
            var model = db.LIBRO;
            return PartialView("~/Views/_GridView1Partial.cshtml", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialAddNew(DXWebApplication1.Models.LIBRO item)
        {
            var model = db.LIBRO;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/_GridView1Partial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialUpdate(DXWebApplication1.Models.LIBRO item)
        {
            var model = db.LIBRO;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.ID == item.ID);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/_GridView1Partial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialDelete(System.Int32 ID)
        {
            var model = db.LIBRO;
            if (ID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.ID == ID);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("~/Views/_GridView1Partial.cshtml", model.ToList());
        }
	}
}