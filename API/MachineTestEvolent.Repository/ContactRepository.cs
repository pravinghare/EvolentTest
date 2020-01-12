using AutoMapper;
using BusinessObject;
using MachineTestEvolent.Abstraction;
using MachineTestEvolent.EF;
using MachineTestEvolent.EF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineTestEvolent.Repository
{
    public class ContactRepository: IContactRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public ContactRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            this._applicationDbContext = applicationDbContext;
            this._mapper = mapper;

        }

        //Manual mapping of Entity to other Object
        //public Contact ToDataObject(ContactEntity obj)
        //{
        //    return new Contact()
        //    {
        //        FirstName = obj.FirstName,
        //        LastName = obj.LastName,
        //        Email = obj.Email,
        //        PhoneNumber = obj.PhoneNumber,
        //        Status = obj.Status,
        //    };
        //}

        //public ContactEntity ToEntityObject(Contact obj)
        //{
        //    return new ContactEntity()
        //    {
        //        FirstName = obj.FirstName,
        //        LastName = obj.LastName,
        //        Email = obj.Email,
        //        PhoneNumber = obj.PhoneNumber,
        //        Status = obj.Status,
        //    };
        //}


            //Using AutoMapper
        public Contact ToDataObject(ContactEntity obj)
        {
            return _mapper.Map<Contact>(obj);
        }
        public ContactEntity ToEntityObject(Contact obj)
        {
            return _mapper.Map<ContactEntity>(obj);
        }

        public IList<ContactEntity> ToEntityListObject(List<Contact> obj)
        {
            return _mapper.Map<IList<Contact>, IList<ContactEntity>>(obj);
        }

        public async Task<ContactEntity> AddContactAsync(ContactEntity quickBookEntity)
        {
            var Connection = ToDataObject(quickBookEntity);
            _applicationDbContext.Contact.Add(Connection);
            await _applicationDbContext.SaveChangesAsync();
            return  ToEntityObject(Connection);
        }

        public async Task<IList<ContactEntity>> GetContactAsync()
        {
           List<Contact> list= await _applicationDbContext.Contact.ToListAsync();
            return ToEntityListObject(list);
        }
       

        public async Task<ContactEntity> EditContactAsync(ContactEntity contact)
        {
          Contact EditContact= await _applicationDbContext.Contact.Where(x=>x.Id==contact.Id).FirstOrDefaultAsync();
            EditContact.FirstName = contact.FirstName;
            EditContact.LastName = contact.LastName;
            EditContact.Email = contact.Email;
            EditContact.PhoneNumber = contact.PhoneNumber;
            EditContact.Status = contact.Status;
            await _applicationDbContext.SaveChangesAsync();
            return ToEntityObject(EditContact);
        }


        public async Task<bool> DeleteContactAsync(int Id)
        {
            Contact deleteContact = await _applicationDbContext.Contact.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _applicationDbContext.Remove(deleteContact);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
