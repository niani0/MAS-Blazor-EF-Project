using blazor_19c.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace blazor_19c.Services
{
    public class GroupService : IGroupService
    {
        private readonly SawmillGruszkaDBContext _context;
        public GroupService(SawmillGruszkaDBContext context)
        {
            _context = context;
        }
        public async Task<bool> ConnectGroupToTask(string taskId, WorkersGroup group)
        {
            var task = await _context.Task.FindAsync(taskId);
            if (task != null && group != null)
            {
                task.WorkersGroups.Add(group);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<WorkersGroup>> GetGroups()
        {
            return await _context.WorkersGroup.Include(e => e.SawmillWorkers).ToListAsync();
        }

<<<<<<< HEAD
        public async Task<WorkersGroup> GetGroups(string GroupID)
        {
            return await _context.WorkersGroup.Include(e => e.SawmillWorkers).FirstOrDefaultAsync(e => e.Id == GroupID);
        }
=======
        public async Task<WorkersGroup?> GetGroups(string GroupID)
        {
            return await _context.WorkersGroup.Include(e => e.SawmillWorkers).FirstOrDefaultAsync(e => e.Id == GroupID);
        }

        public async Task<WorkersGroup> AddGroup(string specialization, List<SawmillWorker> selectedWorkers)
        {
            WorkersGroup group = new()
            {
                Specialization = specialization,
                SawmillWorkers = selectedWorkers
            };

            _context.WorkersGroup.Add(group);
            await _context.SaveChangesAsync();

            return group;
        }
>>>>>>> feature-branch
    }
}
