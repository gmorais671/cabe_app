using cabe_API.Models;

namespace cabe_API.Repository
{
    public interface IContactRepository
    {
        Contact Create(Contact product);
        Contact? FindById(int id);
        List<Contact> FindAll();
        Contact Update(Contact product);
        void Delete(int id);
    }
}
