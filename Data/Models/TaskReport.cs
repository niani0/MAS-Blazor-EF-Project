using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Class representing a task report
    /// </summary>
    public class TaskReport
    {
        /// <summary>
        /// Id of the task report
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        /// <summary>
        /// Name of the task
        /// </summary>
        public string TaskName { get; set; }
        /// <summary>
        /// Description of the task
        /// </summary>
        public string TaskDescription { get; set; }
        /// <summary>
        /// Date of creation of the report
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// List of tasks
        /// </summary>
        public virtual ICollection<Task> Tasks { get; set; }
        /// <summary>
        /// Shift supervisor
        /// </summary>
        [ForeignKey("ShiftSupervisorId")]
        public virtual ShiftSupervisor ShiftSupervisor { get; set; }
        /// <summary>
        /// Shift supervisor id
        /// </summary>
        public string ShiftSupervisorId { get; set; }
        public TaskReport()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
