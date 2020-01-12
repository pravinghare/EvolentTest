using BusinessObject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MachineTestEvolent.Abstraction
{
    //IContact interface
    public interface IContactManager
    {
        Task<IList<ContactEntity>> GetContactAsync();
        Task<ContactEntity> AddContactAsync(ContactEntity contact);
        Task<ContactEntity> EditContactAsync( ContactEntity contact);
        Task<bool> DeleteContactAsync(int Id);
    }
}
