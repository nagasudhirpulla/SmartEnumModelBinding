using Microsoft.AspNetCore.Mvc;
using SmartEnumBinding.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartEnumBinding.Entities
{
    public class AppUser
    {
        public string UserName { get; set; }
        public GenderEnum Gender { get; set; }
        public RoleEnum UsrRole { get; set; }
    }
}
