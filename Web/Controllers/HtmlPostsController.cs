using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities;
using Infrastructure;

namespace Web.Controllers
{
    [Route("html/[controller]")]
    public class HtmlPostsController : Controller
    {
        private IPostRepository _postRepository { get; set; }

        public HtmlPostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_postRepository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_postRepository.Get(id));
        }


        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Post post)
        {
            try
            {
                _postRepository.Add(post);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return new BadRequestResult();
            }
        }

        [HttpGet("edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_postRepository.Get(id));
        }

        [HttpPost("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Post post)
        {
            try
            {
                post.Id = id;
                _postRepository.Update(post);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return new BadRequestResult();
            }
        }
    }
}