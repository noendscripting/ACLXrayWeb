using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ACLXrayWeb.Models;

namespace ACLXrayWeb.Controllers
{
    public class SearchController : Controller
    {
        ACLXRAYEntities db = new ACLXRAYEntities();

        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TrusteeSearch(FormCollection form)
        {

            //ADMIN_COUNT aCount = new ADMIN_COUNT();
            //ADMIN_SDHOLDER asdHolder = new ADMIN_SDHOLDER();
            //AD_OBJECT_ACCESS aoacc = new AD_OBJECT_ACCESS();
            //AD_OBJECT_AUDIT aoaudit = new AD_OBJECT_AUDIT();

            
            var textbox = form["Username"];
            //var results = from a in db.ADMIN_COUNT where a.ObjectSID == "me" select new {
            //}; 
            

            return Content(textbox);
        }


        public ActionResult TrusteeSearch()
        {



            return View();

        }
        [HttpPost]
        public ActionResult ComputerSearch()
        {
            return Content("Hello Computer");
        }

        private List<string> getAllSIDs (string userName)
        {
           List<string> sids = new List<string>();
           sids = (from trustees in db.Trustees where trustees.Name == userName select trustees.Sid).ToList();
           return sids; 

        }
    }
}