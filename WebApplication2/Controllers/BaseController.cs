using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public abstract class BaseController : Controller
    {
        //protected override void HandleUnknownAction(string actionName)
        //{
        //    //base.HandleUnknownAction(actionName);
        //    this.Redirect("/?redir=" + actionName).ExecuteResult(ControllerContext);
        //}

        protected override void HandleUnknownAction(string actionName)
        {
            Debug.WriteLine(actionName);
            this.Redirect("/?redir=" + actionName).ExecuteResult(ControllerContext);
        }
    }
}