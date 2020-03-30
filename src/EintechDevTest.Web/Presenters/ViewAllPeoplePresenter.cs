using System.Net;
using System.Text;
using EintechDevTest.Core.Dto.UseCaseResponses;
using EintechDevTest.Core.Interfaces;
using EintechDevTest.Serialization;

namespace EintechDevTest.Web.Presenters
{
    public sealed class SearchPeoplePresenter : IOutputPort<SearchPeopleResponse>
    {
        public SearchPeopleViewModel ViewModel { get; }

        public SearchPeoplePresenter()
        {
            ViewModel = new SearchPeopleViewModel();
        }

        public void Handle(SearchPeopleResponse response)
        {
            ViewModel.People = response.SearchResults;
        }
    }
}
