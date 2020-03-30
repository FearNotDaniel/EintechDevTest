using System.Net;
using System.Text;
using EintechDevTest.Core.Dto.UseCaseResponses;
using EintechDevTest.Core.Interfaces;
using EintechDevTest.Serialization;

namespace EintechDevTest.Web.Presenters
{
    public sealed class ViewAllPeoplePresenter : IOutputPort<ViewAllPeopleResponse>
    {
        public ViewAllPeopleViewModel ViewModel { get; }

        public ViewAllPeoplePresenter()
        {
            ViewModel = new ViewAllPeopleViewModel();
        }

        public void Handle(ViewAllPeopleResponse response)
        {
            ViewModel.People = response.Results;
        }
    }
}
