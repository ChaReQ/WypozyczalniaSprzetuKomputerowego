using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WypozyczalniaSprzetuKomputerowego.Constants;

namespace WypozyczalniaSprzetuKomputerowego.Models
{
    public class Equipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "{0} nie może mieć więcej niż {1} znaków")]
        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Kategoria")]
        public EquipmentCategory Category { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Data produkcji")]
        public DateTime DateProduced { get; set; }

        public int AverageRating { get; set; }

        [StringLength(250, ErrorMessage = "{0} nie może mieć więcej niż {1} znaków")]
        [DisplayName("Opis")]
        public string Description { get; set; }

        [Range(0, 1000, ErrorMessage = "W magazynie nie może być więcej niż 1000 sztuk tego przedmiotu")]
        [DisplayName("Ilość dostępnych sztuk")]
        public int NumberAvailable { get; set; }

        public bool IsAvailable => NumberAvailable > 0;
    }
}
