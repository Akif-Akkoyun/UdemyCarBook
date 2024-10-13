using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.BlogDtos
{
    public class ResultLast3BlogsWithAuthors
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public string AuthorName { get; set; } = string.Empty;
    }
}
