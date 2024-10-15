using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _context;

        public BlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<BlogEntity> GetAllBlogsAuthors()
        {
            var values = _context.Blogs
                .Include(x => x.Author)
                .ToList();
            return values;
        }

        public List<BlogEntity> GetLast3BlogsWithAuthors()
        {
            var values = _context.Blogs
                .Include(x => x.Author)
                .OrderByDescending(x => x.Id)
                .Take(3)
                .ToList();
            return values;
        }
    }
}
