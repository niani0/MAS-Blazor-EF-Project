using blazor_19c.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace blazor_19c.Services
{
    public class GroupService : IGroupService
    {
        private readonly SawmillGruszkaDBContext _context;
        public GroupService(SawmillGruszkaDBContext context)
        {
            _context = context;
        }

        public async Task<List<WorkersGroup>> GetGroups()
        {
            return await _context.WorkersGroup.Include(e => e.SawmillWorkers).ToListAsync();
        }
    }
}
