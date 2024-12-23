﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<BlogEntity> Blogs{ get; set; } = default!;
    }
}
