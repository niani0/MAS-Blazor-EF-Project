using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Class representing a task
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Id of the task
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        /// <summary>
        /// Current state of the task
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Date of the task creation
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Finish date of the task
        /// </summary>
        public DateTime? FinishDate { get; set; }
        /// <summary>
        /// Materials needed for the task
        /// </summary>
        public virtual ICollection<Material> Materials { get; set; }
        /// <summary>
        /// Reports of the task
        /// </summary>
        public virtual ICollection<TaskReport> Reports { get; set; }
        /// <summary>
        /// Work done on the order
        /// </summary>
        public virtual ICollection<WorkOnOrder> WorkOnOrders { get; set; }
        /// <summary>
        /// Workers groups
        /// </summary>
        public virtual ICollection<WorkersGroup> WorkersGroups { get; set; }
        public Task()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
