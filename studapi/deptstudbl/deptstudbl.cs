using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using studapi.Models;
using studapi.deptstudmapdl;

namespace studapi.deptstudbl
{
    public class deptstudbll
    {
        public List<deptstudmap> Getstud(int id)
        {
            deptstuddl d = new deptstuddl();
            return d.Getstud(id);
        }
    }
}