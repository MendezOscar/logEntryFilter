using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using log4net.Repository.Hierarchy;
using WebGrease;

namespace logEntryFilter
{
    public class RegisterAttribute : FilterAttribute, IActionFilter, IResultFilter, IExceptionFilter
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
          Logger.Info(filterContext.ActionDescriptor.ActionName.ToString()); 
                 
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
           
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
        
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
        }

        public void OnException(ExceptionContext filterContext)
        {
         Logger.ErrorException(filterContext.Exception.Message.ToString(),filterContext.Exception); 
        }
    {
    }
}