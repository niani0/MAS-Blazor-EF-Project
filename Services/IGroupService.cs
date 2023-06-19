using blazor_19c.Data.Models;

namespace blazor_19c.Services
{
    public interface IGroupService
    {
        public Task<List<WorkersGroup>> GetGroups();
    }
}
