using Microsoft.VisualStudio.TestTools.UnitTesting;
using Senhas.Controllers.Api;
using Senhas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerTest.Controllers.Api
{
    [TestClass]
    public class LoginTests
    {
        private LoginApiController LoginController;

        public LoginTests()
        {
            LoginController = new LoginApiController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new System.Web.Http.HttpConfiguration()
            };
        }

        [TestMethod]
        public void PostErrorAmountCharacterTest()
        {
            var model = new Login
            {
                Email = "renan@gmail.com",
                Password = "Abcdef2@"
            };
            
            MockModelState(model, LoginController);
            var result = LoginController.Post(model);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }

        [TestMethod]
        public void PostErrorCharacterSpecialTest()
        {
            var model = new Login
            {
                Email = "renan@gmail.com",
                Password = "Abcdef2187"
            };

            MockModelState(model, LoginController);
            var result = LoginController.Post(model);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }

        [TestMethod]
        public void PostErrorCharactereDistinctsTest()
        {
            var model = new Login
            {
                Email = "renan@gmail.com",
                Password = "Abcdef218@8"
            };

            MockModelState(model, LoginController);
            var result = LoginController.Post(model);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }

        [TestMethod]
        public void PostErrorWithoutDigitTest()
        {
            var model = new Login
            {
                Email = "renan@gmail.com",
                Password = "Abcdefagit@"
            };

            MockModelState(model, LoginController);
            var result = LoginController.Post(model);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }

        [TestMethod]
        public void PostErrorWithoutLowerCaseTest()
        {
            var model = new Login
            {
                Email = "renan@gmail.com",
                Password = "ABCOLERSET.Y2@"
            };

            MockModelState(model, LoginController);
            var result = LoginController.Post(model);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }

        [TestMethod]
        public void PostErrorWithoutUpperCaseTest()
        {
            var model = new Login
            {
                Email = "renan@gmail.com",
                Password = "abcolerset.y2@"
            };

            MockModelState(model, LoginController);
            var result = LoginController.Post(model);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }


        [TestMethod]
        public void PostAcceptTest()
        {
            var model = new Login
            {
                Email = "renan@gmail.com",
                Password = "RenaH125@6"
            };

            MockModelState(model, LoginController);
            var result = LoginController.Post(model);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }

        protected void MockModelState<TModel, TController>(TModel model, TController controller) where TController : LoginApiController
        {
            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError("Password", validationResult.ErrorMessage);
            }
        }
    }
}
