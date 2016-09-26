﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ApiWeb.Models
{
    public class UserAccount
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Postal { get; set; }

        public string Email { get; set; }
    }
}
