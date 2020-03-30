using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EintechDevTest.Core.Domain.Entities;
using EintechDevTest.Core.Dto;
using EintechDevTest.Core.Dto.RepositoryResponses;
using EintechDevTest.Core.Interfaces.Repositories;
using EintechDevTest.Infrastructure.Data.Entities;
using EintechDevTest.Infrastructure.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace EintechDevTest.Infrastructure.Data.Repositories
{
  internal sealed class PersonRepository : IPersonRepository
  {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public PersonRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CreatePersonResponse> Create(Person person)
        {
            var dbPerson = _mapper.Map<DbPerson>(person);
            var errors = new List<Error>();
            _db.People.Add(dbPerson);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                errors.Add(new Error(ex.GetType().ToString(), ex.Message));
            }
            
            return new CreatePersonResponse(dbPerson.ID, !errors.Any(), errors.Any() ? errors : null);
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            var results = await _db.People.Include(p => p.Group).ToListAsync();
            return results.Select(p => _mapper.Map<Person>(p));
        }

        public async Task<IEnumerable<Person>> Search(string searchText)
        {
            var results = await _db.People
                .Include(p => p.Group)
                .Where(p =>
                p.FullName.Contains(searchText) ||
                p.Group.GroupName.Contains(searchText)
            ).ToListAsync();
            return results.Select(p => _mapper.Map<Person>(p));
        }
  }
}
