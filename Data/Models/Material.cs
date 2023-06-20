using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Represents a material used in the company.
    /// </summary>
    public class Material
    {
        /// <summary>
        /// Gets or sets the id of the material.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the material.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price per kilo of the material.
        /// </summary>
        public float PricePerKilo { get; set; }

        /// <summary>
        /// Gets or sets the list of materials deliveries.
        /// </summary>
        public virtual ICollection<MaterialsDelivery> MaterialsDeliveries { get; set; }

        /// <summary>
        /// Gets or sets the list of tasks.
        /// </summary>
        public virtual ICollection<Task> Tasks { get; set; }

        public Material()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
