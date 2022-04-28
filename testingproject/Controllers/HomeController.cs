using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using testingproject.Models;

namespace testingproject.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult reports()
        {
            Context stdntcntxt = new Context();

            var data = stdntcntxt.orderDetails;
            return View(data.ToList());
        }
        
        [HttpPost]
        public ActionResult ExportToExcel()
        {
            Context stdntcntxt = new Context();

            var data = stdntcntxt.orderDetails;
            var gv = new GridView();
            gv.DataSource = data.ToList();
            gv.DataBind();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=DemoExcel.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            StringWriter objStringWriter = new StringWriter();
            HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);
            gv.RenderControl(objHtmlTextWriter);
            Response.Output.Write(objStringWriter.ToString());
            Response.Flush();
            Response.End();
            return null;
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult Measurmentpdf()
        {
            return View();
        }

        public ActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginPage(string EMPLOYEE_ID, string Password)
        {
            var db = new Context();
            var has = db.Login.Where(p => p.Username == EMPLOYEE_ID && p.Password == Password).FirstOrDefault();
            if(has!=null)
            {
                return RedirectToAction("Reports", "Home");
            }

            return View();
        }

        public ActionResult AboutUS()
        {
            return View();
        }

        public ActionResult Arangetram()
        {
            return View();
        }

        public ActionResult bharatanatyam()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult Kuchipud()
        {
            return View();
        }

        public ActionResult Ornaments()
        {
            return View();
        }

        public ActionResult MakeupKit()
        {
            return View();
        }

        public ActionResult Adrdanareshwar()
        {
            return View();
        }

        public ActionResult StageProgram()
        {
            return View();
        }

        public ActionResult GroupDance()
        {
            return View();
        }

        public ActionResult Kirshnadress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddImage(OrderDetails o)
        {
            try
            {
                var db = new Context();
                o.Updated_User = "92270";
                o.Updated_Date = DateTime.Now;
                db.orderDetails.Add(o);
                db.SaveChanges();
                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}