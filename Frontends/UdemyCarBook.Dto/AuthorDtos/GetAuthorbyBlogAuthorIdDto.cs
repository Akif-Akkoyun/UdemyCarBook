using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.AuthorDtos
{
    public class GetAuthorbyBlogAuthorIdDto
    {
        public int Id { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public string AuthorDescription { get; set; } = string.Empty;
        public string AuthorImageUrl { get; set; } = string.Empty;
        public int AuthorID { get; set; }
    }
}
