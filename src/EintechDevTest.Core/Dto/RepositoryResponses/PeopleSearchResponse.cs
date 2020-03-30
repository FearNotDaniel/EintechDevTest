using System.Collections.Generic;

namespace EintechDevTest.Core.Dto.RepositoryResponses
{
  public sealed class PeopleSearchResponse : BaseRepositoryResponse
  {
    public string Id { get; }
    public PeopleSearchResponse(string id, bool success = false, IEnumerable<Error> errors = null) : base(success, errors)
    {
      Id = id;
    }
  }
}
