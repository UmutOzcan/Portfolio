using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    // Experience CRUD islemlerini tutan Interface
    public interface IExperienceDal : IGenericDal<Experience> { } // IGeneric interfaceine Experience entitysini yollariz 
}