using System;
using System.Collections.Generic;

namespace Exps.Core.Entities
{
    /// <summary> Journal contains records about all expenses </summary>
    public class Journal
    {
        /// <summary> Row unique identifier </summary>
        public int Id { get; set; }

        /// <summary> Date of expense had been done </summary>
        public DateTime Date { get; set; }

        /// <summary> Expense sum </summary>
        //[RegularExpression(@"^\d+\.\d{0,2}$")]
        //[Range(0, 999999999.99)]
        public decimal Sum { get; set; }

        /// <summary> High level group of expense </summary>
        //public int GroupId { get; set; }
        //public Group Group { get; set; }
    }
}
