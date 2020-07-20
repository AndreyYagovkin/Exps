using System;
using System.ComponentModel.DataAnnotations;

namespace Exps.WebClient.Areas.Journal.Models
{
    public class RecordListModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public decimal Sum { get; set; }
    }
}
