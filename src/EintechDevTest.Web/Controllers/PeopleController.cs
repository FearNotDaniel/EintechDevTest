using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EintechDevTest.Core.Dto.UseCaseRequests;
using EintechDevTest.Core.Interfaces.UseCases;
using EintechDevTest.Web.Models;
using EintechDevTest.Web.Presenters;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EintechDevTest.Web.Controllers
{
    public class PeopleController : Controller
    {
        // Use Cases
        private readonly IAddPersonUseCase _addPersonUseCase;
        private readonly ISearchPeopleUseCase _searchPeopleUseCase;
        private readonly IViewAllPeopleUseCase _viewAllPeopleUseCase;
        private readonly IViewAllGroupsUseCase _viewAllGroupsUseCase;

        // Presenters
        private readonly AddPersonPresenter _addPersonPresenter;
        private readonly SearchPeoplePresenter _searchPeoplePresenter;
        private readonly ViewAllPeoplePresenter _viewAllPeoplePresenter;
        private readonly ViewAllGroupsPresenter _viewAllGroupsPresenter;

        public PeopleController(IAddPersonUseCase addPersonUseCase, ISearchPeopleUseCase searchPeopleUseCase,
            IViewAllPeopleUseCase viewAllPeopleUseCase, IViewAllGroupsUseCase viewAllGroupsUseCase,
            AddPersonPresenter addPersonPresenter, SearchPeoplePresenter searchPeoplePresenter,
            ViewAllPeoplePresenter viewAllPeoplePresenter, ViewAllGroupsPresenter viewAllGroupsPresenter)
        {
            _addPersonUseCase = addPersonUseCase;
            _searchPeopleUseCase = searchPeopleUseCase;
            _viewAllPeopleUseCase = viewAllPeopleUseCase;
            _viewAllGroupsUseCase = viewAllGroupsUseCase;
            _addPersonPresenter = addPersonPresenter;
            _searchPeoplePresenter = searchPeoplePresenter;
            _viewAllPeoplePresenter = viewAllPeoplePresenter;
            _viewAllGroupsPresenter = viewAllGroupsPresenter;
        }

        public async Task<IActionResult> Index()
        {
            var useCaseRequestMessage = new ViewAllPeopleRequest();
            var responseMessage = await _viewAllPeopleUseCase.Handle(useCaseRequestMessage, _viewAllPeoplePresenter);
            return View(_viewAllPeoplePresenter.ViewModel.People);
        }

        public async Task<IActionResult> Create()
        {
            var person = new CreatePersonViewModel();
            await BuildSelectors(person);
            return View(person);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                // TODO: add authentication to project, pass logged-in user ID as parameter
                var addPersonUseCaseRequestMessage = new AddPersonRequest(person.FullName, person.GroupID, "WebUserID");
                var addPersonResponseMessage = await _addPersonUseCase.Handle(addPersonUseCaseRequestMessage, _addPersonPresenter);
                if (_addPersonPresenter.ViewModel.Success) return RedirectToAction("Index");

                // Use case response indicates failure, pass message on to user
                ViewBag.FailureMessage = _addPersonPresenter.ViewModel.ResultMessage;
            }
            await BuildSelectors(person);
            return View(person);
        }

        private async Task BuildSelectors(CreatePersonViewModel person)
        {
            // retrieve list of groups to use in selector
            var groupsUseCaseRequestMessage = new ViewAllGroupsRequest();
            var groupsResponseMessage = await _viewAllGroupsUseCase.Handle(groupsUseCaseRequestMessage, _viewAllGroupsPresenter);
            var groups = _viewAllGroupsPresenter.ViewModel.Groups;
            ViewBag.GroupID = new SelectList(groups.OrderBy(g => g.GroupName), "ID", "GroupName", person.GroupID);
        }

        public async Task<IActionResult> Search(string searchText)
        {
            var searchPeopleUseCaseRequestMessage = new SearchPeopleRequest(searchText);
            var seachPeopleResponseMessage = await _searchPeopleUseCase.Handle(searchPeopleUseCaseRequestMessage, _searchPeoplePresenter);
            ViewBag.SearchText = searchText;
            return View("Index", _searchPeoplePresenter.ViewModel.People);
        }
    }
}