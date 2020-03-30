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
    public sealed class ViewAllPeopleUseCase : IViewAllPeopleUseCase
    {
        private readonly IPersonRepository _personRepository;

        public ViewAllPeopleUseCase(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<bool> Handle(ViewAllPeopleRequest message, IOutputPort<ViewAllPeopleResponse> outputPort)
        {
            var response = await _personRepository.GetAll();
            outputPort.Handle(new ViewAllPeopleResponse(response, true));
            return true;
        }
    }
}
