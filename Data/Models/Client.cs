namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Client class represents a client of the company
    /// </summary>
    public class Client : Person
    {
        /// <summary>
        /// Phone number of the client
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email address of the client
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Company name of the client
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Orders of the client
        /// </summary>
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
