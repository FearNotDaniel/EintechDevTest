using System;
using System.Collections.Generic;
using System.Text;
using EintechDevTest.Core.Domain.Entities;
using EintechDevTest.Core.Interfaces;

namespace EintechDevTest.Core.Dto.UseCaseResponses
{
    public class ViewAllGroupsResponse : UseCaseResponseMessage
    {
        public IEnumerable<Group> Results { get; }
        public IEnumerable<string> Errors { get; }

        public ViewAllGroupsResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public ViewAllGroupsResponse(IEnumerable<Group> results, bool success = false, string message = null) : base(success, message)
        {
            Results = results;
        }
    }
}
