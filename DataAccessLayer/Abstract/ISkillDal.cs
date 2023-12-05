using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    // Skill CRUD islemlerini tutan Interface
    public interface ISkillDal : IGenericDal<Skill> { } // IGeneric interfaceine Skill entitysini yollariz 
}