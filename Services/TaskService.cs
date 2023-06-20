using blazor_19c.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

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
            return await _context.Task.Include(e => e.WorkersGroups).ToListAsync();
        }

        public async Task<Data.Models.Task> GetTasks(string TaskId)
        {
            return await _context.Task.Include(e => e.WorkersGroups).FirstOrDefaultAsync(e => e.Id == TaskId);
        }

        public async Task<List<Data.Models.Task>> GetTasksByGroup(string GroupId)
        {
            var tasks = await _context.Task
                .Include(e => e.WorkersGroups)
                .Where(e => !e.WorkersGroups.Any(wg => wg.Id == GroupId))
                .ToListAsync();
            return tasks;
        }

        public async Task<List<Data.Models.Task>> UpdateStateOfAllTask()
        {
            var tasks = await _context.Task
                    .Include(e => e.WorkersGroups)
                    .ToListAsync();

            foreach (var task in tasks)
            {
                if (task.WorkersGroups.Any())
                {
                    task.State = TaskState.InProgress.ToString();
                }
                else if (task.FinishDate < DateTime.Now)
                {
                    task.State = TaskState.Finished.ToString();
                }
            }

            await _context.SaveChangesAsync();
            return tasks;
        }
    }
}
