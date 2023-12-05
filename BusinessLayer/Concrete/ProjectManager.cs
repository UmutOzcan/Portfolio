using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : IGenericService<Project>
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal) 
        {
            _projectDal = projectDal;
        }

        public void TAdd(Project entity)
        {
            _projectDal.Insert(entity);
        }

        public void TDelete(Project entity)
        {
            _projectDal.Delete(entity);
        }

        public Project TGetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public List<Project> TGetList()
        {
            return _projectDal.GetList();
        }

        public void TUpdate(Project entity)
        {
            _projectDal.Update(entity);
        }
    }
}
