using Microsoft.VisualStudio.TestTools.UnitTesting;
using Senhas.Controllers.Api;
using Senhas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Senhas.Controllers.Api.Tests
{
    [TestClass()]
    public class LoginApiControllerTests
    {
        private LoginApiController controller;
        public LoginApiControllerTests()
        {
            //controller.Configuration = new System.Web.Http.HttpConfiguration();
        }

        [TestMethod()]
        public void PostTest()
        {
            var model = new Login
            {
                Email = "pedro@gmail.com",
                Password = "123"
            };

            var userController = new LoginApiController();
            MockModelState(model, userController);
            var result = userController.Post(model);

            //controller.Validate(model);
            //var resultado = controller.Post(model);

            //Assert.IsNotNull(resultado);
            //Assert.IsTrue(resultado.IsSuccessStatusCode);
        }

        protected void MockModelState<TModel, TController>(TModel model, TController controller) where TController : LoginApiController
        {
            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            //foreach (var validationResult in validationResults)
            //{
            //    controller. ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            //}
        }
    }
}