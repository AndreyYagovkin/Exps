using System;

namespace Exps.Core.Entities
{
    public class Journal
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        //[RegularExpression(@"^\d+\.\d{0,2}$")]
        //[Range(0, 999999999.99)]
        public decimal Sum { get; set; }

    }
}
