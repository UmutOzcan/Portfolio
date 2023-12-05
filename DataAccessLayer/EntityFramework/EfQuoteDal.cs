using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    // Generic Repository de tanımladığımız methodları direkt cekip Ef 
    public class EfQuoteDal : GenericRepository<Quote>, IQuoteDal { } // IQuoteDal'a gerek yok ama ilerleyen zamanlarda CRUD dışında başka bi işleme ihtiyac duyarsak 
                                                                                       // ve bu islem sadece bu entityde lazım olursa burada tanımlarız
}