﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class TagCloudEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
        public BlogEntity Blog { get; set; }
    }
}
