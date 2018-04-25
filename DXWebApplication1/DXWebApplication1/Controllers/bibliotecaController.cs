using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DXWebApplication1.Controllers
{
    public class bibliotecaController : Controller
    {
        //
        // GET: /biblioteca/
        public ActionResult Index()
        {
            return View();
        }

        DXWebApplication1.Models.BIBLIOTECAEntities db = new DXWebApplication1.Models.BIBLIOTECAEntities();

        [ValidateInput(false)]
        public ActionResult GridView2Partial()
        {
            var model = db.USUARIO;
            return PartialView("~/Views/_GridView2Partial.cshtml", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridView2PartialAddNew(DXWebApplication1.Models.USUARIO item)
        {
            var model = db.USUARIO;
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
            return PartialView("~/Views/_GridView2Partial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView2PartialUpdate(DXWebApplication1.Models.USUARIO item)
        {
            var model = db.USUARIO;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.nombre == item.nombre);
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
            return PartialView("~/Views/_GridView2Partial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView2PartialDelete(System.String nombre)
        {
            var model = db.USUARIO;
            if (nombre != null)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.nombre == nombre);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("~/Views/_GridView2Partial.cshtml", model.ToList());
        }
	}
}