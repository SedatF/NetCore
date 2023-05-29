using CoreDemos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemos.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment> {
                new UserComment
                {
                    ID=1,
                    Username="Sedat"
                },
                new UserComment
                {
                    ID=2,
                    Username="Vedat"
                },
                new UserComment
                {
                    ID=3,
                    Username="Ahmet"
                } 
            };
            return View(commentvalues);
        }
    }
}
