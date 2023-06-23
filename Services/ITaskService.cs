using blazor_19c.Data.Models;

namespace blazor_19c.Services
{
    public interface ITaskService
    {
        public Task<List<Data.Models.Task>> GetTasks();
        public Task<List<Data.Models.Task>> GetTasksByGroup(string GroupId);
        public Task<Data.Models.Task> GetTasks(string TaskID);
        public Task<List<Data.Models.Task>> UpdateStateOfAllTask();
<<<<<<< HEAD
=======
        public Task<bool> GiveTaskToGroup(string TaskId, string GroupId);
>>>>>>> feature-branch
    }
}
