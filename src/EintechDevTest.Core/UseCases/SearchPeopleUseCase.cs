using System;
using System.Linq;
using System.Threading.Tasks;
using EintechDevTest.Core.Domain.Entities;
using EintechDevTest.Core.Dto.UseCaseRequests;
using EintechDevTest.Core.Dto.UseCaseResponses;
using EintechDevTest.Core.Interfaces;
using EintechDevTest.Core.Interfaces.Repositories;
using EintechDevTest.Core.Interfaces.UseCases;

namespace EintechDevTest.Core.UseCases
{
    public sealed class SearchPeopleUseCase : ISearchPeopleUseCase
    {
        private readonly IPersonRepository _personRepository;

        public SearchPeopleUseCase(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<bool> Handle(SearchPeopleRequest message, IOutputPort<SearchPeopleResponse> outputPort)
        {
            var response = await _personRepository.Search(message.SearchText);
            outputPort.Handle(new SearchPeopleResponse(response, true));
            return true;
        }
    }
}
