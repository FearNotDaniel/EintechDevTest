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
    public sealed class AddPersonUseCase : IAddPersonUseCase
    {
        private readonly IPersonRepository _personRepository;

        public AddPersonUseCase(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<bool> Handle(AddPersonRequest message, IOutputPort<AddPersonResponse> outputPort)
        {
            var response = await _personRepository.Create(new Person(message.FullName, message.GroupID, DateTime.Now, message.UserID, DateTime.Now, message.UserID));
            outputPort.Handle(response.Success ? new AddPersonResponse(response.Id, true) : new AddPersonResponse(response.Errors.Select(e => e.Description)));
            return response.Success;
        }
    }
}
