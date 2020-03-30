using System;
using System.Collections.Generic;
using System.Text;
using EintechDevTest.Core.Domain.Entities;
using EintechDevTest.Core.Interfaces;

namespace EintechDevTest.Core.Dto.UseCaseResponses
{
    public class ViewAllPeopleResponse : UseCaseResponseMessage
    {
        public IEnumerable<Person> Results { get; }
        public IEnumerable<string> Errors { get; }

        public ViewAllPeopleResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public ViewAllPeopleResponse(IEnumerable<Person> results, bool success = false, string message = null) : base(success, message)
        {
            Results = results;
        }
    }
}
