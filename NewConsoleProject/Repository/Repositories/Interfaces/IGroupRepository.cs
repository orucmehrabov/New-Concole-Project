using System.Text.RegularExpressions;

namespace Repository.Repositories.Interfaces
{
    public interface IGroupRepository
    {
        void Create(Group group);
        void Delete(int groupId);
        void Edit(Group group);
        Group GetById(int groupId);
        List<Group> GetAll();
        List<Group> Search(string groupName);
        List<Group> SortingByCapacity();
    }
}