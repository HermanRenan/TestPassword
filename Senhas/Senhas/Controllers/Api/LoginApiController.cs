using Senhas.Models;
using Senhas.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Senhas.Controllers.Api
{
    public class LoginApiController : ApiController
    {
        // GET: api/LoginApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LoginApi/5
        public string Get(int id)
        {
            return "value";
        }
        // POST: api/LoginApi
        public HttpResponseMessage Post(Login login)
        {

            if (ModelState.IsValid)
            {                
                return Request.CreateResponse(HttpStatusCode.OK, login);
            }
            else
            {
                var message = Utilities.GetErrorModalState(ModelState);
                HttpError error = new HttpError(message);                
                return Request.CreateResponse(HttpStatusCode.InternalServerError, error);
            }
        }

        // PUT: api/LoginApi/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/LoginApi/5
        public void Delete(int id)
        {
        }
    }
}
