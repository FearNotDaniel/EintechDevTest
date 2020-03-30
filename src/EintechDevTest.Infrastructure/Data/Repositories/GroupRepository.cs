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
  internal sealed class GroupRepository : IGroupRepository
  {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public GroupRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Group>> GetAll()
        {
            var results = await _db.Groups.ToListAsync();
            return results.Select(g => _mapper.Map<Group>(g));
        }
  }
}
