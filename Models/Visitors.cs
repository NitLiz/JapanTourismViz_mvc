using System;
using System.ComponentModel.DataAnnotations;

namespace JapanTourism.Models
{
	public class Visitors
	{
        public int Id { get; set; }
        public string? Country { get; set; }
        [DataType(DataType.Date)]
        public DateTime Month_come { get; set; }
        [DataType(DataType.Date)]
        public DateTime Year_come { get; set; }
        //public string? Genre { get; set; }
        public decimal No_of_visitors { get; set; }
    }
}

