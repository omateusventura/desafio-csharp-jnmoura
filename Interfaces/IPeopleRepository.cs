using API.Models;

namespace API.Interfaces
{
    public interface IPeopleRepository
    {
        Task<List<PeopleEntity>> findAll();
        Task<PeopleEntity> findById(int peopleId);
        Task<PeopleEntity> add(PeopleEntity people);
        Task<PeopleEntity> update(PeopleEntity people, int peopleId);
        Task<bool> delete(int peopleId);

    }
}
