﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace studapi.Models
{
    public class deptstudmap
    {
        public int ID { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Dateofbirth { get; set; }
        public int DeptID { get; set; }
        public String Deptname { get; set; }
        public String HODname { get; set; }
    }
}
