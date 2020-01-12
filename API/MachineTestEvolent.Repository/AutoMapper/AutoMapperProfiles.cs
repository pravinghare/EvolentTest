using AutoMapper;
using BusinessObject;
using MachineTestEvolent.EF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineTestEvolent.Repository.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ContactEntity, Contact>();
            CreateMap<Contact, ContactEntity>();
            CreateMap<List<Contact>, List<ContactEntity>>();
            CreateMap<List<ContactEntity>, List<Contact>>();
        }
    }
}
