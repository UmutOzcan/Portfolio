using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class QuoteManager : IQuoteService
    {
        IQuoteDal _quoteDal;

        public QuoteManager(IQuoteDal quoteDal) 
        {
            _quoteDal = quoteDal;
        }

        public void TAdd(Quote entity)
        {
            _quoteDal.Insert(entity);
        }

        public void TDelete(Quote entity)
        {
            _quoteDal.Delete(entity);
        }

        public Quote TGetById(int id)
        {
            return _quoteDal.GetById(id);
        }

        public List<Quote> TGetList()
        {
            return _quoteDal.GetList();
        }

        public void TUpdate(Quote entity)
        {
            _quoteDal.Update(entity);
        }
    }
}
