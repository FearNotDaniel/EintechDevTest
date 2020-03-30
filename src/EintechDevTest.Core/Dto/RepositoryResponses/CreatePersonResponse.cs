using System.Collections.Generic;

namespace EintechDevTest.Core.Dto.RepositoryResponses
{
  public sealed class CreatePersonResponse : BaseRepositoryResponse
  {
    public int Id { get; }
    public CreatePersonResponse(int id, bool success = false, IEnumerable<Error> errors = null) : base(success, errors)
    {
      Id = id;
    }
  }
}
