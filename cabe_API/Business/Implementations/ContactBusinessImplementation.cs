using cabe_API.Models;
using cabe_API.Repository;

namespace cabe_API.Business.Implementations
{
    public class ContactBusinessImplementation : IContactBusiness
    {
        private IContactRepository _repository;

        public ContactBusinessImplementation(IContactRepository repository)
        {
            _repository = repository;
        }

        public Contact Create(Contact contact)
        {
            return _repository.Create(contact);
        }
        List<Contact> IContactBusiness.FindAll()
        {
            return _repository.FindAll();
        }

        Contact? IContactBusiness.FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Contact Update(Contact contact)
        {
            return _repository.Update(contact);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
