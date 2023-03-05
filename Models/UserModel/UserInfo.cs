﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR.Models.UserModel
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public Guid ID { get; set; }
    }
}
