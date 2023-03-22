using QairService.DB;
namespace QairService.Services
{
    public class DBServicecs
    {
        public QairDBContext Context { get; set; } 
        public DBServicecs() { 
         Context = new QairDBContext();
        }
        public QairDBContext GetDBInstance()
        {
            return Context;
        }
    }
}
