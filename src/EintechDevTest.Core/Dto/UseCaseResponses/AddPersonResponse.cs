using System;
using System.Collections.Generic;
using System.Text;
using EintechDevTest.Core.Interfaces;

namespace EintechDevTest.Core.Dto.UseCaseResponses
{
    public class AddPersonResponse : UseCaseResponseMessage
    {
        public int ID { get; }
        public IEnumerable<string> Errors { get; }

        public AddPersonResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public AddPersonResponse(int id, bool success = false, string message = null) : base(success, message)
        {
            ID = id;
        }
    }
}
