using blazor_19c.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        public async Task<Data.Models.Task?> GetTasks(string TaskId)
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

        public async Task<bool> GiveTaskToGroup(string TaskId, string GroupId)
        {
            var task = await _context.Task.FindAsync(TaskId);
            var group = await _context.WorkersGroup.FindAsync(GroupId);
            if (task != null && group != null)
            {
                task.WorkersGroups.Add(group);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
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
