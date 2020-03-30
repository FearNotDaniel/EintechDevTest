using System.Net;
using System.Text;
using EintechDevTest.Core.Dto.UseCaseResponses;
using EintechDevTest.Core.Interfaces;
using EintechDevTest.Serialization;

namespace EintechDevTest.Web.Presenters
{
    public sealed class AddPersonPresenter : IOutputPort<AddPersonResponse>
    {
        public AddPersonViewModel ViewModel { get; }

        public AddPersonPresenter()
        {
            ViewModel = new AddPersonViewModel();
        }

        public void Handle(AddPersonResponse response)
        {
            ViewModel.Success = response.Success;
            if (response.Success)
            {
                ViewModel.ResultMessage = "Success! New person added.";
                ViewModel.ID = response.ID;
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine("Failed to register course(s)");
                foreach (var e in response.Errors)
                {
                    sb.AppendLine(e);
                }

                ViewModel.ResultMessage = sb.ToString();
            }
        }
    }
}
