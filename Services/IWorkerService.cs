using blazor_19c.Data.Models;

namespace blazor_19c.Services
{
    public interface IWorkerService
    {
        public Task<List<SawmillWorker>> GetWorkers();


    }
}
