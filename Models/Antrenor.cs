using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Gym_Bobescu.Models
{
    public class Antrenor
    {
        public int ID { get; set; }
        [Display(Name = "Nume Antrenor")]
        public string NumeAntrenor { get; set; }
        [Display(Name = "Ani de experienta")]
        public int AniExperienta { get; set; }
        public ICollection<Client>? Clienti { get; set; }
        public int? SalaID { get; set; }
        public Sala? Sala { get; set; }
    }
}
