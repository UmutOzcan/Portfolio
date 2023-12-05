using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;

namespace Portfolio.ViewComponents.Quote
{
    public class QuoteList : ViewComponent
    {
        QuoteManager quoteManager = new QuoteManager(new EfQuoteDal());

        public IViewComponentResult Invoke()
        {
            var values = quoteManager.TGetList();
            return View(values);
        }
    }
}
