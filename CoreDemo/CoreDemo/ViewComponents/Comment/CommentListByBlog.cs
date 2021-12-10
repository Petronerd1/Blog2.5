using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            CommentManager cm = new CommentManager(new EFCommentRepository());
                var value = cm.GetList(id);
            return View(value);

        }

    }
}
