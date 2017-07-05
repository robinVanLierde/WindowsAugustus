using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    class Leerling

    {
        public Leerling()
        {
            Id = "2";
            Voornaam = "a";
            Naam = "a";
            Email = "a";
            Telefoon = "a";
            Voornaam = "a";
            opleiding = "a";
            campus = "a";

        }

        public String Id { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
        public string Telefoon { get; set; }
        public string opleiding { get; set; }
        public string campus { get; set; }
    }
}
