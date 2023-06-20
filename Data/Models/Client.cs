namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Represents a client of the company.
    /// </summary>
    public class Client : Person
    {
        /// <summary>
        /// Gets or sets the phone number of the client.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the email address of the client.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the company name of the client.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the orders of the client.
        /// </summary>
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
