using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WypozyczalniaSprzetuKomputerowego.Models
{
    public class Comment
    {
        public Comment(string UserId)
        {
            DateAdded = DateTime.Now;
            this.UserId = UserId;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "{0} nie może mieć więcej niż {1} znaków")]
        [DisplayName("Treść")]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; private set; }
    }
}
