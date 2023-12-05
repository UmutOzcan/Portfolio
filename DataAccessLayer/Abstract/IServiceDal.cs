using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    // Service CRUD islemlerini tutan Interface
    public interface IServiceDal : IGenericDal<Service> { } // IGeneric interfaceine Service entitysini yollariz 
}