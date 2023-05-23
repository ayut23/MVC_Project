using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PROG123.DAL;
using PROG123.Models;
using PROG123.utils;

namespace PROG123.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // this is for testing purpuse only.
            DatabaseHelper dbh = new DatabaseHelper(_configuration);
            ConnStatusModel status = dbh.GetConnectionStringAndConnectionStatus();
            ViewBag.ConnStr = status.ConnStr;
            ViewBag.DBStatus = status.DBConnectionStatus;
            ViewBag.Exception = status.Exception;
            return View();
        }

        // add your actions here 

        //firstPage create instant of the PersonModel class and return model
        public IActionResult firstPage()
        {
            var model = new PersonModel();
            return View(model);
        }

      
        /* public IActionResult M...(1... 2...)
         {
             return View(2...);
         }*/

        //secondPage takes PersonModel as parameter which is data submitted from first page 
        //then return model
        //second page display Info

        public IActionResult secondPage(PersonModel person)
        {
            //WEEK_03
            //instantiated dp class and object named _configuration

            DALPerson dp = new DALPerson(_configuration);
            //took a pID var and called AddPerson method which takes person object as parameter
            //adds it to the data store.

            string pID = dp.AddPerson(person);
            
            //The AddPerson method returns the unique identifier (PersonID) of the newly added person
            //changed its name to "pID"

            person.PersonID = pID;

            //session added

            HttpContext.Session.SetString("pID", pID.ToString());
            string strPID = HttpContext.Session.GetString("pID");

            return View(person);
        }

        //WEEK04
        public IActionResult EditPerson()
        {

            string pID = HttpContext.Session.GetString("pID");

            DALPerson dp = new DALPerson(_configuration);

            PersonModel person = dp.getPerson(pID); 
            
            var pmd = new PersonModel();
            
            return View(person); }

        //nextweek //Week05
        public IActionResult UpdatePerson(PersonModel person)
        {
            //Get User ID from Session
            string pID = HttpContext.Session.GetString("pID");
            //Assigned UserID in Person Object
            person.PersonID = pID;

            //instantiate DalPerson class
            DALPerson dp = new DALPerson(_configuration);
            //get UpdatePerson method with person object
            dp.UpdatePerson(person);

            //instead of returning just person object, returned secondPage as view and person object as well
            return View("secondPage",person);
        }
        public IActionResult DeletePerson()
        {

            string pID = HttpContext.Session.GetString("pID");

            DALPerson dp = new DALPerson(_configuration);
            PersonModel person = dp.getPerson(pID);

            dp.DeletePerson(pID);
 
            return View(person);
        }
    }
   
      
}
