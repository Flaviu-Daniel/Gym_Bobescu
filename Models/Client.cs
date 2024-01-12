using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Gym_Bobescu.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public decimal Greutate { get; set; }
        [Display(Name = "Data Nasterii")]
        [DataType(DataType.Date)]
        public DateTime Born { get; set; }
        public int? AntrenorID { get; set; }
        public Antrenor? Antrenor { get; set; }
    }
}
