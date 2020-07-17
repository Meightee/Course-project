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

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _postRepository.GetAll();
        }


        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return _postRepository.Get(id);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Post post)
        {
            _postRepository.Add(post);
            return Ok();
        }
    }
}