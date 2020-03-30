using System.Net;
using EintechDevTest.Core.Dto.UseCaseResponses;
using EintechDevTest.Core.Interfaces;
using EintechDevTest.Serialization;

namespace EintechDevTest.Web.Presenters
{
    public sealed class AddPersonApiPresenter : IOutputPort<AddPersonResponse>
    {
        public JsonContentResult ContentResult { get; }

        public AddPersonApiPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(AddPersonResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            ContentResult.Content = JsonSerializer.SerializeObject(response);
        }
    }
}
