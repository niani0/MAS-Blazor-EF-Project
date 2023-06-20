using blazor_19c.Data.Models;
using System.Text.RegularExpressions;

namespace blazor_19c.Services
{
    public interface IGroupService
    {
        public Task<List<WorkersGroup>> GetGroups();
        public Task<WorkersGroup> GetGroups(string GroupID);
    }
}
