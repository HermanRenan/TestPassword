using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace Senhas.Util
{
    public static class Utilities
    {
        public static string GetErrorModalState(dynamic modelState)
        {
            foreach (ModelState _modelState in modelState.Values)
            {
                foreach (ModelError error in _modelState.Errors)
                {
                    return error.ErrorMessage;
                }
            }

            return "";
        }
    }
}