using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_19c.Data.Models
{
    /// <summary>
    /// Person class represents a person
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Id of the person
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        /// <summary>
        /// First name of the person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of the person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Birthdate of the person
        /// </summary>
        public DateTime Birthdate { get; set; }
        /// <summary>
        /// Pesel of the person
        /// </summary>
        public string Pesel { get; set; }
        /// <summary>
        /// Function to get age of the person
        /// </summary>
        /// <returns>Returns age of the person in integer</returns>
        public int getAge()
        {
            return DateTime.Now.Year - Birthdate.Year;
        }
        public Person()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
