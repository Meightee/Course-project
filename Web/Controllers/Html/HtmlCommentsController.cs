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
    public class HtmlCommentsController : Controller
    {
        private ICommentRepository _commentRepository { get; set; }

        public HtmlCommentsController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet]
        public ActionResult Index(int id)
        {
            return View(_commentRepository.GetAll().Where(p=>p.PostId == id));
        }

        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_commentRepository.Get(id));
        }


        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Comment comment)
        {
            try
            {
                _commentRepository.Add(comment);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return new BadRequestResult();
            }
        }
    }
}
