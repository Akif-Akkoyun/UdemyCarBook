using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CommentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int BlogId { get; set; }
        public BlogEntity Blog { get; set; }
    }
}
