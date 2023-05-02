
namespace Nbg_2023_CRM.Repositories
{
    public interface IRepository<T> where T : class
    {
        //CRUD
        int Create(T t);
        T ?Read(int id);
        IList<T> ReadAll();
        bool Update(T customer, int id);
        bool Delete(int id);
    }
}
