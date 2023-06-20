namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Class representing a shift supervisor
    /// </summary>
    public class ShiftSupervisor : SawmillWorker
    {
        /// <summary>
        /// Phone number of the shift supervisor
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email address of the shift supervisor
        /// </summary>
        public virtual ICollection<TaskReport> TaskReports { get; set; }
    }
}
