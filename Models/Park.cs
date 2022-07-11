using System;
using System.ComponentModel.DataAnnotations;

namespace NationalPark.Models
{
    public class Park
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100), Display(Name = "Park Name")]
        public string Name { get; set; }

        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyy}"), Display(Name = "Started On")]
        public DateTime StartedOn { get; set; }

        [Required, StringLength(100), Display(Name = "Type")]
        public string Type { get; set; }

        [Required, Display(Name = "Open for Public")]
        public bool IsOpen { get; set; }

    }
}
