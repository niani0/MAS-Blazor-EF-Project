using blazor_19c.Data.Models;

namespace blazor_19c.Services
{
    public interface ITaskService
    {
        public Task<List<Data.Models.Task>> GetTasks();
        public Task<List<Data.Models.Task>> GetTasks(string GroupId);
    }
}
