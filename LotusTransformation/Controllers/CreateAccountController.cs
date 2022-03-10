using LotusTransformation.Data;
using LotusTransformation.Models;
using LotusTransformation.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LotusTransformation.Controllers
{
    public class CreateAccountController : Controller
    {

        private readonly LotusTransformationDBContext _dbContext;

        public CreateAccountController(LotusTransformationDBContext Acc)
        {
            _dbContext = Acc;
        }

        [HttpGet]
        [RequireHttps]
        public ActionResult AccountCreation()
        {
            List<string> existingUserNames = _dbContext.ClientAccountInformation.Select(u => u.UserName).ToList();
            ViewBag.existingUserNames = existingUserNames;
            return View();
        }

        [HttpPost]
        [RequireHttps]
        public IActionResult AccountCreation(ClientSignUpVM NewUser)
        {

            ViewBag.NewUser = NewUser;
            if (ModelState.IsValid && NewUser.Password.Equals(NewUser.ConfirmPassword))
            {
                ClientAccountInformation user = new ClientAccountInformation()
                {
                    FirstName = NewUser.FirstName,
                    MiddleInitial = NewUser.MiddleInitial,
                    LastName = NewUser.LastName,
                    UserName = NewUser.UserName,
                    Password = NewUser.Password, //TODO: Learn to SALT and Encypt Passwords & UserName 
                    Contact = new ClientContactInformation()
                    {
                        Address1 = NewUser.Address1,
                        Address2 = NewUser.Address2,
                        City = NewUser.City,
                        StateOrProvince = NewUser.StateOrProvince,
                        Country = NewUser.Country,
                        ZIPorPostal = NewUser.ZIPorPostal,
                        PhoneNumber = NewUser.PhoneNumber,
                        PhoneType = NewUser.PhoneType,
                        Email = NewUser.Email,
                    },

                    Employment = new ClientWorkInformation()
                    {
                        Occupation = NewUser.Occupation,
                        Company = NewUser.Company,
                        CompanyStreetAddress1 = NewUser.CompanyStreetAddress1,
                        CompanyStreetAddress2 = NewUser.CompanyStreetAddress2,
                        CompanyCity = NewUser.CompanyCity,
                        CompanyState = NewUser.CompanyState,
                        CompanyPostal = NewUser.CompanyPostal,
                        CompnayCountry = NewUser.CompanyCountry,
                        WorkEmail = NewUser.WorkEmail,

                    },
                };

                _dbContext.AddRange(user);
                _dbContext.SaveChanges();

                return RedirectToAction("FirstPreSession");
            }

            else if (!ModelState.IsValid)
            {
                return View();

            }
            else
            {
                ViewBag.NewUser.PasswordMismatch = true;
                return View("AccountCreation", NewUser);
            }
        }

        [HttpGet]
        public IActionResult FirstPreSession(long id)
        {

            return View();
        }
    }
}
