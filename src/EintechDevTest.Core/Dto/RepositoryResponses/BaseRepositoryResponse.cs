using System.Collections.Generic;

namespace EintechDevTest.Core.Dto.RepositoryResponses
{
  public abstract class BaseRepositoryResponse
  {
    public bool Success { get; }
    public IEnumerable<Error> Errors { get; }

    protected BaseRepositoryResponse(bool success = false, IEnumerable<Error> errors = null)
    {
      Success = success;
      Errors = errors;
    }
  }
}

