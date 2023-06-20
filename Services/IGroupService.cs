using blazor_19c.Data.Models;
using System.Text.RegularExpressions;

namespace blazor_19c.Services
{
    public interface IGroupService
    {
        public Task<List<WorkersGroup>> GetGroups();
        public Task<WorkersGroup> GetGroups(string GroupID);
        public Task<bool> ConnectGroupToTask(String taskId, WorkersGroup group);
        public Task<WorkersGroup> AddGroup(string Specialization, List<SawmillWorker> selectedWorkers);
    }
}
