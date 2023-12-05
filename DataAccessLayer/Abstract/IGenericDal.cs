namespace DataAccessLayer.Abstract
{
    // Tek tek her entity icin Interface olusturmak yerine bir tane IGeneric olustururuz
    public interface IGenericDal<T> where T : class // T entityden gelen sınıf degeri
    {
        void Insert(T entity); // entity parametresi alan Insert Methodu
        void Delete(T entity); // entity parametresi alan Delete Methodu
        void Update(T entity); // entity parametresi alan Update Methodu
        List<T> GetList(); // verilen entity listesini donen Method
        T GetById(int id); // verilen idye göre entity elemanı donen method
    }
}
