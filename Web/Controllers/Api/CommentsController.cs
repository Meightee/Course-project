using System.Collections.Generic;
using Entities;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private ICommentRepository _commentRepository { get; set; }

        public CommentsController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _commentRepository.GetAll();
        }


        [HttpGet("{id}")]
        public Comment Get(int id)
        {
            return _commentRepository.Get(id);
        }


        [HttpPost]
        public ActionResult Comment([FromBody] Comment comment)
        {
            _commentRepository.Add(comment);
            return Ok();
        }
    }
}
