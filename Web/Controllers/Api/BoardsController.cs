using System.Collections.Generic;
using Entities;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private IBoardRepository _boardRepository { get; set; }

        public BoardsController(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        [HttpGet]
        public IEnumerable<Board> Get()
        {
            return _boardRepository.GetAll();
        }


        [HttpGet("{id}")]
        public Board Get(int id)
        {
            return _boardRepository.Get(id);
        }


        [HttpPost]
        public ActionResult Board([FromBody] Board board)
        {
            _boardRepository.Add(board);
            return Ok();
        }
    }
}
