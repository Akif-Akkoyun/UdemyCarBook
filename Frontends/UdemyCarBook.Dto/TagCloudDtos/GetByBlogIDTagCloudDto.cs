using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.TagCloudDtos
{
    public class GetByBlogIDTagCloudDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}
