using blazor_19c.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace blazor_19c.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly SawmillGruszkaDBContext _context;
        public WorkerService(SawmillGruszkaDBContext context)
        {
            _context = context;
        }


        public async Task<List<SawmillWorker>> GetWorkers()
        {
            return await _context.Person.OfType<SawmillWorker>().ToListAsync();
        }

    }
}
