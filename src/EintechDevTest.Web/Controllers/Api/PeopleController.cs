using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EintechDevTest.Core.Dto.UseCaseRequests;
using EintechDevTest.Core.Interfaces.UseCases;
using EintechDevTest.Web.Models;
using EintechDevTest.Web.Presenters;

namespace EintechDevTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IAddPersonUseCase _addPersonUseCase;
        private readonly AddPersonApiPresenter _addPersonApiPresenter;

        public PeopleController(IAddPersonUseCase addPersonUseCase, AddPersonApiPresenter addPersonApiPresenter)
        {
            _addPersonUseCase = addPersonUseCase;
            _addPersonApiPresenter = addPersonApiPresenter;
        }

        // POST api/people/create
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreatePersonViewModel request)
        {
            if (!ModelState.IsValid)
            { // re-render the view when validation failed.
                return BadRequest(ModelState);
            }
            // TODO: add API authentication and include User ID
            await _addPersonUseCase.Handle(new AddPersonRequest(request.FullName, request.GroupID, "ApiUserID"), _addPersonApiPresenter);
            return _addPersonApiPresenter.ContentResult;
        }
    }
}
