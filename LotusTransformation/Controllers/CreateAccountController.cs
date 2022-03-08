using LotusTransformation.Data;
using LotusTransformation.Models;
using LotusTransformation.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        [HttpPost]
        [RequireHttps]
        public IActionResult AccountCreation(ClientSignUpVM NewUser)
        {


            if (ModelState.IsValid && NewUser.Password.Equals(NewUser.ConfirmPassword))
            {
                ClientAccountInformation user = new ClientAccountInformation()
                {
                    FirstName = NewUser.FirstName,
                    MiddleInitial = NewUser.MiddleInitial,
                    LastName = NewUser.LastName,
                    UserName = NewUser.UserName,
                    Password = NewUser.Password, // Learn to SALT and Encypt Passwords & UserName 
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

            else return View();
        }

        [HttpGet]
        public IActionResult FirstPreSession(long id)
        {

            return View();
        }
    }
}
