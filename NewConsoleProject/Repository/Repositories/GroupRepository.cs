using Repository.Repositories.Interfaces;
using System.Text.RegularExpressions;

namespace Repository.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public void Create(Group group)
        {
            throw new NotImplementedException();
        }

        public void Delete(int groupId)
        {
            throw new NotImplementedException();
        }

        public void Edit(Group group)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll()
        {
            throw new NotImplementedException();
        }

        public Group GetById(int groupId)
        {
            throw new NotImplementedException();
        }

        public List<Group> Search(string groupName)
        {
            throw new NotImplementedException();
        }

        public List<Group> SortingByCapacity()
        {
            throw new NotImplementedException();
        }
    }
}
