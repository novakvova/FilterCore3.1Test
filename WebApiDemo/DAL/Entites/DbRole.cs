﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.DAL.Entites
{
    public class DbRole : IdentityRole<long>
    {
        public ICollection<DbUserRole> UserRoles { get; set; }
    }
}
