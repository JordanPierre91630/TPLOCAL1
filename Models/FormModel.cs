using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required]
        [Display(Name = "Nom")]
        public  string  Nom {  get; set; }
        [Required]
        [Display(Name = "Prenom")]
        public  string  Prenom { get; set; }
        [Required]
        [Display(Name = "Sexe")]
        public  string  Sexe { get; set; }
        [Required]
        [Display(Name = "Adresse")]
        public  string  Adresse { get; set; }
        [Required]
        [RegularExpression(@"^(\b\d{5}\b)$")]
        [Display(Name = "Code Postal")]
        public  string  Zipcode { get; set; }
        [Required]
        [Display(Name = "Ville")]
        public  string  Ville { get; set; }
        [Required]
        [Display(Name = "Adresse Mail")]
        public  string  Email { get; set; }
        [Required]
        [Display(Name = "Date de début de formation")]
        public  DateTime Debut { get; set; }
        [Required]
        [Display(Name = "Type de formation")]
        public  string  Formation { get; set; }
        [Required]
        [Display(Name = "Avis sur la formation COBOL")]
        public  string  Avis1 { get; set; }
        [Required]
        [Display(Name = "Avis sur la formation C#")]
        public  string  Avis2 { get; set; }


    }
}
