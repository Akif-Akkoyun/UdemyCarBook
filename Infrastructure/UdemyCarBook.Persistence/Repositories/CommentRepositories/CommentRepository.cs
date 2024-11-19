using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<CommentEntity>
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Create(CommentEntity entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<CommentEntity> GetAll()
        {
            return _context
                .Comments
                .Select(x => new CommentEntity
                {
                    Id = x.Id,
                    BlogId = x.BlogId,
                    CreatedAt = x.CreatedAt,
                    Description = x.Description,
                    Name = x.Name
                }).ToList();
        }

        public CommentEntity GetById(int id)
        {
            return _context.Comments.Find(id) ?? throw new InvalidOperationException();
        }

        public void Remove(CommentEntity entity)
        {
            var comment = _context.Comments.Find(entity.Id);
            _context.Comments.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(CommentEntity entity)
        {
            _context.Comments.Update(entity);
            _context.SaveChanges();
        }
    }
}
