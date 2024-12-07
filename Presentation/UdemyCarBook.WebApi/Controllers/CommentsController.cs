using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<CommentEntity> _commentRepository;

        public CommentsController(IGenericRepository<CommentEntity> commentRepository)
        {
            _commentRepository = commentRepository;
        }
        [HttpGet]
        public IActionResult GetCommentsList()
        {
            var comments = _commentRepository.GetAll();
            return Ok(comments);
        }
        [HttpPost]
        public IActionResult CreateComment([FromBody] CommentEntity comment)
        {

            _commentRepository.Create(comment);
            return Ok("Yorum Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var value = _commentRepository.GetById(id);
            _commentRepository.Remove(value);
            return Ok("Yorum Başarıyla Silindi");
        }
        [HttpPut]
        public IActionResult UpdateComment(CommentEntity comment)
        {
            _commentRepository.Update(comment);
            return Ok("Yorum Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var comment = _commentRepository.GetById(id);
            return Ok(comment);
        }
        [HttpGet("CommentListByBlog")]
        public IActionResult CommentListByBlog(int id)
        {
            var comment = _commentRepository.GetCommnetsByBlogId(id);
            return Ok(comment);
        }
    }
}
