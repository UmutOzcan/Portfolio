using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    // Contact CRUD islemlerini tutan Interface
    public interface IContactDal : IGenericDal<Contact> { } // IGeneric interfaceine Contact entitysini yollariz 
}