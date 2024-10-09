using AddressBook.Person.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class DtoMappings : Profile
    {
        public DtoMappings() {
            CreateMap<Models.Person, PersonDto>();
        }
    }
}
