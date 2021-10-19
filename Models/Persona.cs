using System;
using System.ComponentModel.DataAnnotations;

namespace Santarsieri.Andrea._5H.PrimaWeb.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage="Inserisci un cognome")]
        [EmailAddress]
        public string Cognome { get; set; }

       
    }
}
