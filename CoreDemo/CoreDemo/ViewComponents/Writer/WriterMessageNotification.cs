using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "telepati@gmail.com";
            var value = mm.GetInboxListByWriter(p);
            return View(value);

        }
    }
}
