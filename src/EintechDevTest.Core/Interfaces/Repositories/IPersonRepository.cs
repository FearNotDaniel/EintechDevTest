using System.Collections.Generic;
using System.Threading.Tasks;
using EintechDevTest.Core.Domain.Entities;
using EintechDevTest.Core.Dto.RepositoryResponses;

namespace EintechDevTest.Core.Interfaces.Repositories
{
    public interface IPersonRepository
    {
        Task<CreatePersonResponse> Create(Person person);
        Task<IEnumerable<Person>> Search(string searchText);
        Task<IEnumerable<Person>> GetAll();
    }
}
