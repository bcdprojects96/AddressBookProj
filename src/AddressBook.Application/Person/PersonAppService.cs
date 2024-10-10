using Abp.Domain.Repositories;
using Abp.UI;
using AddressBook.Person.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Person { 

    public interface IPersonAppService : IServiceProvider
    {
        public List<PersonDto> GetPersonList();
    }
    public class PersonAppService : AddressBookAppServiceBase
    {
        IRepository<Models.Person> _personRepository;
        public PersonAppService(IRepository<Models.Person> personRepository) { 
            _personRepository = personRepository;
        }

        public List<PersonDto> GetHardCodedPersonList()
        {
            try
            {
                var personList = new List<PersonDto>
                {
                    new PersonDto
                    {
                        FirstName = "James",
                        LastName = "Anderson",
                        Address = "221B Baker Street, London NW1 6XE, UK"
                    },
                    new PersonDto
                    {
                        FirstName = "Giulia",
                        LastName = "Rossi",
                        Address = "Via Roma, 10, 00184 Roma RM, Italy"
                    },
                    new PersonDto
                    {
                        FirstName = "Lucas",
                        LastName = "Dupont",
                        Address = "15 Rue de Rivoli, 75001 Paris, France"
                    }
                };

                return personList;
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException("Eroare", ex.Message);
            }
        }

        public List<PersonDto> GetDatabasePersonList()
        {
            try
            {
                var personList = _personRepository.GetAll().Where(f => f.State == Enums.State.Active).ToList();
                var personListDto = ObjectMapper.Map<List<PersonDto>>(personList);

                return personListDto;
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException("Eroare", ex.Message);
            }
        }
    }
}
