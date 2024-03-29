﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Phonebook.Models;


namespace Phonebook.Controllers
{
    public class UserController : Controller
    {
        static List<User> userlist = new List<User>();
        // GET: User
        public ActionResult Load()

        {
            User u =
                new User
                {
                    Name = "Mani",
                    AddressLine1 = "Tpatty",
                    AddressLine2 = "KN",
                    City = "Namakkal",
                    Pincode = "637404",
                    PhoneNumber = "9080164191"
                };

            return View("User", u);
        }

        public ActionResult CreateUser()
        {
            return View("CreateUser");
        }

        public ActionResult Submit()
        {
            User person = new User();
            person.Name = Request.Form["Name"];
            person.AddressLine1 = Request.Form["AddressLine1"];
            person.AddressLine2 = Request.Form["AddressLine2"];
            person.City = Request.Form["City"];
            person.Pincode = Request.Form["Pincode"];
            person.PhoneNumber = Request.Form["PhoneNumber"];
            
            return View("DisplayUserDetails",person);
        }
        
        public ActionResult DisplayUserDetails(User users)
        {
            //User users = new User();
            //users.Name = Request.Form["Name"];
            //users.AddressLine1 = Request.Form["AddressLine1"];
            //users.AddressLine2 = Request.Form["AddressLine2"];
            //users.City = Request.Form["City"];
            //users.Pincode = Request.Form["Pincode"];
            //users.PhoneNumber = Request.Form["PhoneNumber"];
            userlist.Add(users);
            return View(userlist);
        }
    }
}