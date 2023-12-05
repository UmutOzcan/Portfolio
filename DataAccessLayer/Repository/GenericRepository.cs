using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository
{
    // Abstract içindeki Generic interface i topluca implemente eden GenericRepository
    public class GenericRepository<T> : IGenericDal<T> where T : class // Her seferinde tek tek entity almak yerine hepsini aldım
    {
        public void Delete(T entity)
        {
            using var c = new Context(); // using ile is bitince destructor gelir
            c.Remove(entity); // silme
            c.SaveChanges(); // db kaydet
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using var c = new Context();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
