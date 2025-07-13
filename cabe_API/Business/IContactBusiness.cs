using cabe_API.Models;

namespace cabe_API.Business
{
    public interface IContactBusiness
    {
        Contact Create(Contact contact);
        Contact? FindById(int id);
        List<Contact> FindAll();
        Contact Update(Contact contact);
        void Delete(int id);
    }
}
