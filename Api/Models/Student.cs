using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Student
    {
        public string Naam { get; set; }
        public string Straat { get; set; }
        public string Gemeente { get; set; }
        public int HuisNr { get; set; }
        public string Email { get; set; }
        public string Opleiding { get; set; }
        public string Campus { get; set; }


    }
}