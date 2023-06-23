using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Class representing a work on order
    /// </summary>
    public class WorkOnOrder
    {
        /// <summary>
        /// Id of the work on order
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        /// <summary>
        /// Work start time
        /// </summary>
        public DateTime WorkStart { get; set; }
        /// <summary>
        /// Work end time
        /// </summary>
        public DateTime WorkEnd { get; set; }
        /// <summary>
        /// List of tasks
        /// </summary>
        public virtual ICollection<Task> Tasks { get; set; }
        /// <summary>
        /// Order
        /// </summary>
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        /// <summary>
        /// Id of the order
        /// </summary>
        public string OrderId { get; set; }
        public WorkOnOrder()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
