using System.Threading.Tasks;
using Moq;
using Xunit;
using EintechDevTest.Core.Domain.Entities;
using EintechDevTest.Core.Dto.RepositoryResponses;
using EintechDevTest.Core.Dto.UseCaseRequests;
using EintechDevTest.Core.Dto.UseCaseResponses;
using EintechDevTest.Core.Interfaces;
using EintechDevTest.Core.Interfaces.Repositories;
using EintechDevTest.Core.UseCases;

namespace EintechDevTest.Core.UnitTests.UseCases

{
    public class AddPersonUseCaseUnitTest
    {
        [Fact]
        public async void Can_Add_Person()
        {
            // ARRANGE: set up mock repository
            var mockPersonRepository = new Mock<IPersonRepository>();
            mockPersonRepository
                .Setup(repo => repo.Create(It.IsAny<Person>()))
                .Returns(Task.FromResult(new CreatePersonResponse(0, true)));

            // ARRANGE: create the use case to be tested
            var useCase = new AddPersonUseCase(mockPersonRepository.Object);

            // ARRANGE: set up mock output port to receive the use case's response
            var mockOutputPort = new Mock<IOutputPort<AddPersonResponse>>();
            mockOutputPort.Setup(port => port.Handle(It.IsAny<AddPersonResponse>()));

            // ACT: pass a request into the use case
            var response = await useCase.Handle(new AddPersonRequest("Full Name", 0, ""), mockOutputPort.Object);

            // ASSERT: the user case handler should return true when the person has been added
            Assert.True(response);
        }
    }
}
