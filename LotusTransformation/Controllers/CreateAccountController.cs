using System;
using System.Collections.Generic;
using System.Linq;
using LotusTransformation.Data;
using LotusTransformation.Models;
using LotusTransformation.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LotusTransformation.Controllers
{
    public class CreateAccountController : Controller
    {
        
        private readonly LotusTransformationDBContext _dbContext;

        public CreateAccountController(LotusTransformationDBContext Acc)
        {
            _dbContext = Acc;
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
                    Contact = new ClientContactInformation()
                    {
                        Address1 = NewUser.Address1,
                        Address2 = NewUser.Address2,
                        City = NewUser.City,
                        StateOrProvince = NewUser.StateOrProvince,
                        Country = NewUser.Country,
                        ZIPorPostal = NewUser.ZIPorPostal,
                        Email = NewUser.Email,
                        PhoneNumber = NewUser.PhoneNumber,
                        PhoneType = NewUser.PhoneType,             
                    },

                    Employment = new ClientWorkInformation()
                    {
                        Occupation = NewUser.Occupation,
                        Company = NewUser.Company,
                        CompanyStreetAddress = NewUser.CompanyStreetAddress,
                        CompanyCity = NewUser.CompanyCity,
                        CompanyState = NewUser.CompanyState,
                        CompanyPostal = NewUser.CompanyPostal,
                        WorkEmail = NewUser.WorkEmail,

                    },
            };
                _dbContext.Add(user);
                _dbContext.SaveChanges();

               

                return RedirectToAction("FirstPreSession");
            }

            else return View();
        }

        [HttpGet]
        public IActionResult FirstPreSession(long id)
        {
           
            return View();
        }
    }
}
