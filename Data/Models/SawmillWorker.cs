namespace blazor_19c.Data.Models
{
    /// <summary>
    /// SawmillWorker class represents a worker of the sawmill
    /// </summary>
    public class SawmillWorker : Person
    {
        /// <summary>
        /// Seniority of the worker
        /// </summary>
        public int Seniority { get; set; }
        /// <summary>
        /// Monthly salary of the worker in PLN
        /// </summary>
        public float Salary { get; set; }
        /// <summary>
        /// List of workers groups
        /// </summary>
        public virtual IEnumerable<WorkersGroup> WorkersGroups { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
