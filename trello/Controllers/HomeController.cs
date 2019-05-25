using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trello.ViewModels;

namespace trello.NewFolder
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new BoardList();

            var board = new BoardList.Board();
            board.Title = "Jon's Board";
            model.Boards.Add(board);

            var anotherBoard = new BoardList.Board();
            anotherBoard.Title = "Another Board";
            model.Boards.Add(anotherBoard);

            return View(model);
        }


    }
}