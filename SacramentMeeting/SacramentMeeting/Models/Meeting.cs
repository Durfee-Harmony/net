using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeeting.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Conductor { get; set; }

        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [Display(Name = "Musical Number")]
        public string MusicalNumber { get; set; }

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }
    }
}