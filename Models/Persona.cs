using System;
using System.ComponentModel.DataAnnotations;

namespace Santarsieri.Andrea._5H.PrimaWeb.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        [Required(ErrorMessage="Inserisci un'email valida")]
        [EmailAddress]
        public string EMail{ get; set; }

       
    }
}
