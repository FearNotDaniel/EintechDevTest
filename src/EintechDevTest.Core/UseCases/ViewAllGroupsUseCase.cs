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
    public sealed class ViewAllGroupsUseCase : IViewAllGroupsUseCase
    {
        private readonly IGroupRepository _groupRepository;

        public ViewAllGroupsUseCase(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<bool> Handle(ViewAllGroupsRequest message, IOutputPort<ViewAllGroupsResponse> outputPort)
        {
            var response = await _groupRepository.GetAll();
            outputPort.Handle(new ViewAllGroupsResponse(response, true));
            return true;
        }
    }
}
