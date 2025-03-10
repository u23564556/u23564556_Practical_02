using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u23564556_Practical_02.Controllers
{
    public class studyGroupController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Names()
        {
            List<Models.studyGroup> members = new List<Models.studyGroup>();
            {
                members.Add(new Models.studyGroup { StudentNumber = "u23564556", FirstName = "Scott", LastName = "Allen", Age = 20, IsAlive = true, EmailAddress = "scott.doe@tuks.co.za", myLink = "~/HTML/Scott.html"  });
                members.Add(new Models.studyGroup { StudentNumber = "u24852504", FirstName = "Kallie", LastName = "Kotze", Age = 19, IsAlive = true, EmailAddress = "kallie.doe@tuks.co.za", myLink = "~/HTML/Kallie.html"  });
                members.Add(new Models.studyGroup { StudentNumber = "u24637646", FirstName = "Xario", LastName = "Zeekoei", Age = 19, IsAlive = true, EmailAddress = "xari.zee@tuks.co.za", myLink = "~/HTML/Xario.html"  });
                members.Add(new Models.studyGroup { StudentNumber = "u24521793", FirstName = "Yaasir", LastName = "Yacoob", Age = 19, IsAlive = true, EmailAddress = "yaasir.yaa@tuks.co.za", myLink = "~/HTML/Yaasir.html"  });
                members.Add(new Models.studyGroup { StudentNumber = "u24647686", FirstName = "Nabeeha", LastName = "Mohammad", Age = 19, IsAlive = true, EmailAddress = "nabeeha.moh@tuks.co.za", myLink = "~/HTML/Nabeeha.html"  });
            };
            return View(members);
        }
    }
}