using System;
using System.ComponentModel.DataAnnotations;

namespace Exps.WebClient.Areas.Journal.Models
{
    public class AddRecordModel
    {
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public decimal Sum { get; set; }
    }
}
