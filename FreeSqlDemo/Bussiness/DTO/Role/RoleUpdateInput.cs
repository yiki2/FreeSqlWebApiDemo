﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeSqlDemo.Bussiness.DTO.Role
{
    public class RoleUpdateInput
    {
        public string FullName { get; set; }
        public List<int> UserIds { get; set; }
    }
}
