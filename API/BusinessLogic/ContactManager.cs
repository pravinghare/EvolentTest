using BusinessObject;
using MachineTestEvolent.Abstraction;
using MachineTestEvolent.EF.Model;
using MachineTestEvolent.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ContactManager:IContactManager
    {
        readonly IContactRepository _contactRepository;

        public ContactManager(IContactRepository contact)
        {
            _contactRepository = contact;
        }


        public async Task<IList<ContactEntity>> GetContactAsync()
        {
            return await _contactRepository.GetContactAsync();
        }
        public async Task<ContactEntity> AddContactAsync(ContactEntity contact)
        {
            return await _contactRepository.AddContactAsync(contact);
        }
        public async Task<ContactEntity> EditContactAsync(ContactEntity contact)
        {
            return await _contactRepository.EditContactAsync(contact);
        }
       

        public Task<bool> DeleteContactAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
