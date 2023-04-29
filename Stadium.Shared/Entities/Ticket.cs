using System.ComponentModel.DataAnnotations;

namespace BarkeysPlace.Shared.Entities
{
    public class Ticket
    {
        [Display(Name = "Id Boleta")]
        public int Id { get; set; }

        [Display(Name = "Fecha Uso")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime UseDate { get; set; }

        [Display(Name = "Fue usada")]
        public bool FueUsada { get; set; }

        [Display(Name = "Portería por la que entró la persona")]
        public string Porteria { get; set; } = null!;
    }
}
