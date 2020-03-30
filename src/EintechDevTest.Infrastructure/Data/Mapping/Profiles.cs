using AutoMapper;
using EintechDevTest.Core.Domain.Entities;
using EintechDevTest.Infrastructure.Data.Entities;


namespace EintechDevTest.Infrastructure.Data.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<Person, DbPerson>().ConstructUsing(p => new DbPerson { ID = p.ID, FullName = p.FullName, GroupID = p.GroupID, Created = p.Created, CreatedBy = p.CreatedBy, Modified = p.Modified, ModifiedBy = p.ModifiedBy });
            CreateMap<DbPerson, Person>().ConstructUsing(dp => new Person(dp.FullName, dp.GroupID, dp.Created, dp.CreatedBy, dp.Modified, dp.ModifiedBy, dp.ID));
            CreateMap<DbGroup, Group>().ConstructUsing(dg => new Group(dg.GroupName, dg.Created, dg.CreatedBy, dg.Modified, dg.ModifiedBy, dg.ID));
        }
    }
}
