using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Class representing a group of workers
    /// </summary>
    public class WorkersGroup
    {
        /// <summary>
        /// Id of the group
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        /// <summary>
        /// Specialization of the group
        /// </summary>
        public string Specialization { get; set; }
        /// <summary>
        /// Sawmill workers
        /// </summary>
        public virtual ICollection<SawmillWorker> SawmillWorkers { get; set; }
        /// <summary>
        /// Tasks of the group
        /// </summary>
        public virtual IEnumerable<Task> Tasks { get; set; }
        public WorkersGroup()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
