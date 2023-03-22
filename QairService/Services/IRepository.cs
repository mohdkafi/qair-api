using QairService.DB;

namespace QairService.Services
{
    public interface IRepository<T>
    {
        public QairDBContext db { get; }

        public T Get(int id);
        public IEnumerable<T> GetAll();
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(int id);
        public void DeleteAll();

    }
}