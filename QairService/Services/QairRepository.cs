using NuGet.Protocol.Core.Types;
using QairService.DB;
using QairService.Models;

namespace QairService.Services
{
    public class QairRepository : IRepository<Qair>
    {
        public QairDBContext db { get; }

        public QairRepository(DBServicecs dBServicecs)
        {
            db = dBServicecs.GetDBInstance();
        }

        public void Create(Qair entity)
        {
            db.Qairs.Add(entity.Map());
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public Qair Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Qair> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Qair entity)
        {
            throw new NotImplementedException();
        }
    }
}
