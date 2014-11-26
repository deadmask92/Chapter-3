using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public String Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ActionResult AutoProperty()
        {
            //create a new Product object
            Product myProduct = new Product();

            //set name product
            myProduct.Name = "Kayak";

            //get the property
            string productName = myProduct.Name;

            //generate the view
            return View("Result", (object)String.Format("Product Name: {0}", productName));
        }

	}
}