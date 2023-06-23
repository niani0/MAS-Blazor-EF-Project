using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Order class represents client's order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id of the order
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        /// <summary>
        /// Description of the order
        /// </summary>
        public string OrderDescription { get; set; }
        /// <summary>
        /// Price of the order
        /// </summary>
        public float OrderPrice { get; set; }
        /// <summary>
        /// Date of the order
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Client of the order
        /// </summary>
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        /// <summary>
        /// Id of the client
        /// </summary>
        public string ClientId { get; set; }
        /// <summary>
        /// List of work on orders
        /// </summary>
        public virtual ICollection<WorkOnOrder> WorkOnOrders { get; set; }
        public Order()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
