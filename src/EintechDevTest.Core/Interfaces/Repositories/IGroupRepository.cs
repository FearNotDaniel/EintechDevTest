using System.Collections.Generic;
using System.Threading.Tasks;
using EintechDevTest.Core.Domain.Entities;
using EintechDevTest.Core.Dto.RepositoryResponses;

namespace EintechDevTest.Core.Interfaces.Repositories
{
    public interface IGroupRepository
    {
        Task<IEnumerable<Group>> GetAll();
    }
}
