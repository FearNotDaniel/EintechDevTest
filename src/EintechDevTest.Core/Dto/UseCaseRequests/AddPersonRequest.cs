using System;
using System.Collections.Generic;
using System.Text;
using EintechDevTest.Core.Interfaces;
using EintechDevTest.Core.Dto.UseCaseResponses;

namespace EintechDevTest.Core.Dto.UseCaseRequests
{
    public class AddPersonRequest : IUseCaseRequest<AddPersonResponse>
    {
        public string FullName { get; }
        public int GroupID { get; }
        public string UserID { get; }

        public AddPersonRequest(string fullName, int groupID, string userID)
        {
            FullName = fullName;
            GroupID = groupID;
            UserID = userID;
        }
    }
}
