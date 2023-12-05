using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial() 
        {
            return PartialView();
        }

        // Message yollama 
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            message.Date = Convert.ToDateTime(DateTime.Now.ToString("dd MMM yyyy hh:mm"));
            message.Status = true;
            messageManager.TAdd(message);
            return RedirectToAction("Index", "Default");
        }
    }
}
