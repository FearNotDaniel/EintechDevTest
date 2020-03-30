using System.Net;
using System.Text;
using EintechDevTest.Core.Dto.UseCaseResponses;
using EintechDevTest.Core.Interfaces;
using EintechDevTest.Serialization;

namespace EintechDevTest.Web.Presenters
{
    public sealed class ViewAllGroupsPresenter : IOutputPort<ViewAllGroupsResponse>
    {
        public ViewAllGroupsViewModel ViewModel { get; }

        public ViewAllGroupsPresenter()
        {
            ViewModel = new ViewAllGroupsViewModel();
        }

        public void Handle(ViewAllGroupsResponse response)
        {
            ViewModel.Groups = response.Results;
        }
    }
}
