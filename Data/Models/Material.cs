using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Material class represents a material used in the company
    /// </summary>
    public class Material
    {
        /// <summary>
        /// Id of the material
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        /// <summary>
        /// Name of the material
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Price per kilo of the material
        /// </summary>
        public float PricePerKilo { get; set; }
        /// <summary>
        /// List of materials deliveries
        /// </summary>
        public virtual IEnumerable<MaterialsDelivery> MaterialsDeliveries { get; set; }
        /// <summary>
        /// List of tasks
        /// </summary>
        public virtual IEnumerable<Task> Tasks { get; set; }

        public Material()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}
