using NUnit.Framework;
using Senhas.Controllers.Api;
using Senhas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhasTests.Controllers.Api
{
    [TestFixture(typeof(int),"b")]
    public class LoginApiControllerTests
    {
        private LoginApiController controller;
        private string a;
        public LoginApiControllerTests(string a)
        {
            this.a = a;
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            controller = new LoginApiController();
        }

        [Test]
        [TestCase(1)]
        public void PostTestAtLastOneDigit()
        {
            var model = new Login
            {
                Email = "pedro@gmail.com",
                Password = "123"
            };

            var resultado = controller.Post(model);

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.IsSuccessStatusCode);            
        }

        [Test]
        [TestCase(1)]
        public void PostTestAt()
        {
            var model = new Login
            {
                Email = "pedro@gmail.com",
                Password = "123"
            };

            var resultado = controller.Post(model);

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.IsSuccessStatusCode);
        }
    }
}