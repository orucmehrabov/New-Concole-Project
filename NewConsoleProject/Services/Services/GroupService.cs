using Repository.Repositories.Interfaces;
using System.Text.RegularExpressions;

namespace Services.Services
{
    public class GroupService
    {
        private readonly IGroupRepository _groupRepository;

        public GroupService(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public void Create(Group group)
        {
            _groupRepository.Create(group);
        }

        public void Delete(int groupId)
        {
            _groupRepository.Delete(groupId);
        }

        public void Edit(Group group)
        {
            _groupRepository.Edit(group);
        }

        public Group GetById(int groupId)
        {
            return _groupRepository.GetById(groupId);
        }

        public IGroupRepository Get_groupRepository()
        {
            return _groupRepository;
        }

        public List<Group> GetAll(IGroupRepository _groupRepository)
        {
            return _groupRepository.GetAll();
        }

        public List<Group> Search(string groupName)
        {
            return _groupRepository.Search(groupName);
        }

        public List<Group> SortingByCapacity()
        {
            return _groupRepository.SortingByCapacity();
        }
    }
}