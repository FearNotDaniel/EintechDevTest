﻿using EintechDevTest.Core.Dto.UseCaseRequests;
using EintechDevTest.Core.Dto.UseCaseResponses;

namespace EintechDevTest.Core.Interfaces.UseCases
{
    public interface IAddPersonUseCase : IUseCaseRequestHandler<AddPersonRequest, AddPersonResponse>
    {
    }
}
