using System.Collections.Generic;
using Entities;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IPostRepository _postRepository { get; set; }

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet("{boardId}")]
        public IEnumerable<Post> Get()
        {
            return _postRepository.GetAll();
        }


        [HttpPost]
        public ActionResult Post([FromBody] Post post)
        {
            _postRepository.Add(post);
            return Ok();
        }
    }
}