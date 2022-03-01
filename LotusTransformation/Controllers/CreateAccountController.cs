using System;
using System.Collections.Generic;
using System.Linq;
using LotusTransformation.Data;
using LotusTransformation.Models;
using LotusTransformation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LotusTransformation.Controllers
{
    public class CreateAccountController : Controller
    {
        
        private readonly LotusTransformationDBContext _efac;

        public CreateAccountController(LotusTransformationDBContext Acc)
        {
            _efac = Acc;
        }

        [HttpGet][RequireHttps]
        public ActionResult AccountCreation()
        {
            return View();
        }

        [HttpPost][RequireHttps]
        public IActionResult AccountCreation(ClientSignUpVM NewUser)
        {


            if (ModelState.IsValid)
            {
                ClientAccountInformation user = new ClientAccountInformation()
                {
                    FirstName = NewUser.FirstName,
                    MiddleInitial = NewUser.MiddleInitial,
                    LastName = NewUser.LastName,
                    UserName = NewUser.UserName,
                    Password = NewUser.Password,
                };


               // if (_existingUser.Account.Select(A => A.PrimaryEmail).Contains(NewUser.PrimaryEmail)) return View();// TODO: Make Email Already Exists View
                // if (_existingUser.Account.Select(A => A.SecondaryEmail).Contains(NewUser.SecondaryEmail)) return View(); //TODO: Make Backup email Already In use View
                // if (_existingUser.Account.Select(A => A.UserName).Contains(NewUser.UserName)) return View(); // TODO: Make UserName Already in Use View

                _efac.Add(user);
                _efac.SaveChanges();

                return View("CreationSuccess");
            }
            else return View();
        }
    }
}
