using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using studapi.profdl;
using studapi.Models;

namespace studapi.profbll
{
    public class profbal
    {
       
            public List<professor> Getprofessor()
            {
                profdal p = new profdal();
                return p.Getprofessor();
            }
        }
    }

