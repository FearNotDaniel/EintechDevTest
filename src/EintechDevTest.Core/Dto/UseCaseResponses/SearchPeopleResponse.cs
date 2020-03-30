using System;
using System.Collections.Generic;
using System.Text;
using EintechDevTest.Core.Domain.Entities;
using EintechDevTest.Core.Interfaces;

namespace EintechDevTest.Core.Dto.UseCaseResponses
{
    public class SearchPeopleResponse : UseCaseResponseMessage
    {
        public IEnumerable<Person> SearchResults { get; }
        public IEnumerable<string> Errors { get; }

        public SearchPeopleResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public SearchPeopleResponse(IEnumerable<Person> searchResults, bool success = false, string message = null) : base(success, message)
        {
            SearchResults = searchResults;
        }
    }
}
