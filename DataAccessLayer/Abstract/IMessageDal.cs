using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    // Message CRUD islemlerini tutan Interface
    public interface IMessageDal : IGenericDal<Message> { } // IGeneric interfaceine Message entitysini yollariz 
}