using blazor_19c.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace blazor_19c.Services
{
    public class TaskService : ITaskService
    {
        private readonly SawmillGruszkaDBContext _context;
        public TaskService(SawmillGruszkaDBContext context)
        {
            _context = context;
        }

        public async Task<List<Data.Models.Task>> GetTasks()
        {
            return await _context.Task.ToListAsync();
        }

        public Task<List<Data.Models.Task>> GetTasks(string GroupId)
        {
            throw new NotImplementedException();
        }
    }
}
