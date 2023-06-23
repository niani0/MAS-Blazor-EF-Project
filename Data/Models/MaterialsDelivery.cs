using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Represents a delivery of materials.
    /// </summary>
    public class MaterialsDelivery
    {
        /// <summary>
        /// Gets or sets the id of the delivery.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the date of the delivery.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the delivery company name.
        /// </summary>
        public string DeliveryCompanyName { get; set; }

        /// <summary>
        /// Gets or sets the list of materials.
        /// </summary>
        public virtual ICollection<Material> Materials { get; set; }

        public MaterialsDelivery()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
