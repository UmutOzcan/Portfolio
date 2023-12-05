using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Feature
{
    public class FeatureList : ViewComponent // Feature kısmı icin VİewComponent tanımı
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal()); // Managerdan nesne olusturdum

        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values); // Default olarak ViewComponenti Shared/Components/FeatureList/Default.cshtml dosyasına bakararak arar
        }
    }
}
