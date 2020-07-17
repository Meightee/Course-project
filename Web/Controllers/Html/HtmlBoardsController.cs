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
    public class HtmlBoardsController : Controller
    {
        private IBoardRepository _boardRepository { get; set; }

        public HtmlBoardsController(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_boardRepository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_boardRepository.Get(id));
        }


        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Board board)
        {
            try
            {
                _boardRepository.Add(board);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return new BadRequestResult();
            }
        }
    }
}
