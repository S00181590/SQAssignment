using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public int carValue { get; set; }

        public insurancetype Insurance { get; set; }

        public int PenaltyPoints { get; set; }

        public enum insurancetype {Comprehensive, ThirdParty}
    }
}