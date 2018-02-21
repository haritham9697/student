using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using studapi.Models;
using studapi.deptstudbl;

namespace studapi.Controllers
{
    public class deptstudmapController : ApiController
    {
        [HttpGet]
        [ActionName("Getstuddept")]
        public List<deptstudmap> Getstud(int id)
        {
            deptstudbll b = new deptstudbll();
            return b.Getstud(id);
        }


    }
}
