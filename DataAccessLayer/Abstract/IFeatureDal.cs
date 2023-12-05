using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    // Feature CRUD islemlerini tutan Interface
    public interface IFeatureDal : IGenericDal<Feature> { } // IGeneric interfaceine Feature entitysini yollariz 
}