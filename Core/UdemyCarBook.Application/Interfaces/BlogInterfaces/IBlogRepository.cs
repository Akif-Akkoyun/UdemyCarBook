using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public List<BlogEntity> GetLast3BlogsWithAuthors();
        public List<BlogEntity> GetAllBlogsAuthors();
        public List<BlogEntity> GetBlogByAuthorId(int id);
    }
}
