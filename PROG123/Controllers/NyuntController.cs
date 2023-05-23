using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PROG123.DAL;
using PROG123.Models;
using PROG123.utils;
using static System.Net.Mime.MediaTypeNames;

namespace PROG123.Controllers
{
    public class NyuntController : Controller
    {
        

        private readonly ILogger<NyuntController> _logger;
        private readonly IConfiguration _configuration;

        public NyuntController(ILogger<NyuntController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        //Authentication Action
        public IActionResult LogIn(LogInCredentialsModel logInCredentialsModel) {

			//instantiate DalPerson class
			DALPerson dp = new DALPerson(_configuration);

            PersonModel person = dp.CheckLogInCredentials(logInCredentialsModel);


            if (person == null)
            {
                ViewBag.LoginMessage= "Log In Failed";

			}
            else {

				HttpContext.Session.SetString("PersonID", person.PersonID);
				HttpContext.Session.SetString("UserName", person.UserName);
                ViewBag.UserFirstName = person.UserName;

			}

			return View("Index");

		}
    }
}
