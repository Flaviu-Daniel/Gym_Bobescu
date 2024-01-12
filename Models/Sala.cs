using System.ComponentModel.DataAnnotations;

namespace Gym_Bobescu.Models
{
    public class Sala
    {
        public int ID { get; set; }
        [Display(Name = "Numele Sali")]
        public string NumeSala { get; set; }
        public string Oras { get; set; }
        public string Strada { get; set; }
       
        public ICollection<Antrenor>? Antrenori { get; set; }
    }
}
