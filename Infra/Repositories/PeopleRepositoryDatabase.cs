using API.Infra.Database;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Infra.Repositories
{
    public class PeopleRepositoryDatabase : IPeopleRepository
    {
        private readonly DatabaseContext _databaseContext;
        public PeopleRepositoryDatabase(DatabaseContext databaseContext) 
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<PeopleEntity>> findAll()
        {
            return await _databaseContext.Peoples.ToListAsync();
        }

        public async Task<PeopleEntity> findById(int personId)
        {
            return await _databaseContext.Peoples.FirstOrDefaultAsync(person => person.id == personId);
        }

        public async Task<PeopleEntity> add(PeopleEntity person)
        {
            await _databaseContext.Peoples.AddAsync(person);
            await _databaseContext.SaveChangesAsync();

            return person;
        }

        public async Task<PeopleEntity> update(PeopleEntity people, int peopleId)
        {
            PeopleEntity peopleUpdate = await findById(peopleId);

            if (peopleUpdate == null)
            {
                throw new Exception("O id informado é inválido");
            }

            peopleUpdate.fullname = people.fullname;
            peopleUpdate.dateofbirth = people.dateofbirth;
            peopleUpdate.inactive = people.inactive;
            peopleUpdate.nationality = people.nationality;
            peopleUpdate.document = people.document;
            peopleUpdate.passport = people.passport;

            _databaseContext.Update(peopleUpdate);
            await _databaseContext.SaveChangesAsync();

            return peopleUpdate;
        }

        public async Task<bool> delete(int peopleId)
        {
            PeopleEntity peopleDelete = await findById(peopleId);

            if (peopleDelete == null)
            {
                throw new Exception("O id informado é inválido");
            }

            _databaseContext.Peoples.Remove(peopleDelete);
            await _databaseContext.SaveChangesAsync();

            return true;
        }
    }
}
