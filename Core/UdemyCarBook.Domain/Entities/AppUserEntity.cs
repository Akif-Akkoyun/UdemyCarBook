﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class AppUserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password{ get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Mail{ get; set; }
        public int AppRoleId{ get; set; }
        public AppRoleEntity AppRole { get; set; }
    }
}
