using System;
using System.Collections.Generic;
using System.Text;
using EintechDevTest.Core.Interfaces;
using EintechDevTest.Core.Dto.UseCaseResponses;

namespace EintechDevTest.Core.Dto.UseCaseRequests
{
    public class SearchPeopleRequest : IUseCaseRequest<SearchPeopleResponse>
    {
        public string SearchText { get; }

        public SearchPeopleRequest(string searchText)
        {
            SearchText = searchText;
        }
    }
}
