﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerun.Models
{
    internal class ChangePasswordModel
    {
        public int UserID { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword{ get; set; }
    }
}
