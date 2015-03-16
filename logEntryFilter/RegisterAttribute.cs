using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using log4net.Repository.Hierarchy;
using WebGrease;
using LogManager = log4net.LogManager;

namespace logEntryFilter
{
    public class RegisterAttribute : FilterAttribute, IActionFilter, IResultFilter, IExceptionFilter
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RegisterAttribute));
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
         Logger.Error(filterContext.Exception.Message.ToString(),filterContext.Exception); 
        }
    
    }
}