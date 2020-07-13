using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeeting.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Conductor { get; set; }
        public string OpeningHymn { get; set; }
        public string SacramentHymn { get; set; }
        public string ClosingHymn { get; set; }
        public string MusicalNumber { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
    }
}