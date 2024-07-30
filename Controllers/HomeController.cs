using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using TPLOCAL1.Models;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {

        //methode "naturally" call by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "OpinionList":
                        List<Opinion> opinionlist = new OpinionList().GetAvis(@"XlmFile/DataAvis.xml");
                        ViewBag.opinionlist = opinionlist;
                        return View(id);
                        //TODO : code reading of the xml files provide
                        
                    case "Form":
                        //TODO : call the Form view with data model empty
                        return View(id);
                    
                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }



             
        public ActionResult ValidationFormulaire(FormModel FormModel)
        {
            if (!ModelState.IsValid)
            {
                return View("/Views/Shared/Form.cshtml");

            }
            return View(FormModel);
        }


    }




}
            
 