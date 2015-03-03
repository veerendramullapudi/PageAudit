using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuditFilt.Common;

namespace AuditFilt.Controllers
{
    public class HomeController : Controller
    {
        [TrackExecutionTime]
        public string Index()
        {
            return "Index Action Invoked";
        }
        [TrackExecutionTime]
        public string Welcome()
        {
            throw new Exception("Exception Occured");
        }
    }
}
