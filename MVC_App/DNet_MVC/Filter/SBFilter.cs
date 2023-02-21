using DNet_MVC.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DNet_MVC.Filter
{
    public class SBFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            MyLogger.CurrentLogger.Log(string.Format("On Action Executing : {0} - Logged at {1}", filterContext.ActionDescriptor.ActionName, DateTime.Now.ToString()));

        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            MyLogger.CurrentLogger.Log(string.Format("OnActionExecuted: {0} - Logged at {1}", filterContext.ActionDescriptor.ActionName, DateTime.Now.ToString()));
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            MyLogger.CurrentLogger.Log(string.Format("OnResultExecuting: Logged at {0}",
                    DateTime.Now.ToString()));
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            MyLogger.CurrentLogger.Log(string.Format("OnResultExecuted: Logged at {0}",
                    DateTime.Now.ToString()));
        }
    }
}