using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// MaterialDelivery class represents a delivery of materials
    /// </summary>
    public class MaterialsDelivery
    {
        /// <summary>
        /// Id of the delivery
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        /// <summary>
        /// Date of the delivery
        /// </summary>
        public DateTime DeliveryDate { get; set; }
        /// <summary>
        /// Delivery company name
        /// </summary>
        public string DeliveryCompanyName { get; set; }
        /// <summary>
        /// List of materials
        /// </summary>
        public virtual IEnumerable<Material> Materials { get; set; }

        public MaterialsDelivery()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
