using cabe_API.Models;
using cabe_API.Models.Context;

namespace cabe_API.Repository.Implementations
{
    public class ContactRepositoryImplementation : IContactRepository
    {
        private MySQLContext _context;

        public ContactRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }


        public Contact Create(Contact contact)
        {
            try
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the contact.", ex);
            }
            return contact;
        }

        Contact? IContactRepository.FindById(int id)
        {
            return _context.Contacts.ToList().SingleOrDefault(p => p.Id.Equals(id));
        }

        List<Contact> IContactRepository.FindAll()
        {
            return _context.Contacts.ToList();
        }

        public Contact Update(Contact contact)
        {
            var existingContact = _context.Contacts.SingleOrDefault(p => p.Id == contact.Id);

            if (existingContact != null)
            {
                try
                {
                    _context.Entry(existingContact).CurrentValues.SetValues(contact);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while updating the contact.", ex);
                }
            } else
            {
                throw new Exception("Contact not found.");
            }

            return contact;
        }
        
        public void Delete(int id)
        {
            var existingContact = _context.Contacts.SingleOrDefault(p => p.Id == id);

            if (existingContact != null)
            {
                try
                {
                    _context.Remove(existingContact);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while updating the contact.", ex);
                }
            }
            else
            {
                throw new Exception("Contact not found.");
            }
        }
    }
}
