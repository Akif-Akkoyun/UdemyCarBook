using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class BlogEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public int AuthorID { get; set; }
        public AuthorEntity Author { get; set; } = default!;
        public int CategoryID { get; set; }
        public CategoryEntity Category { get; set; } = default!;
        public List<TagCloudEntity> TagClouds{ get; set; } = default!;
    }
}
