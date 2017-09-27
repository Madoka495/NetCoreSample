using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITI.PrimarySchool.WebApp.Models.TestViewModels
{
    public class BasicTestViewModel
    {
        [Required]
        [Display( Name = "Couleur préférée" )]
        public string Color { get; set; }

        [Required]
        [Range( 18, 25, ErrorMessage = "L'âge n'est pas compris entre les bornes" )]
        [Display( Name = "Âge" )]
        public int Age { get; set; }

        [Required]
        [Range( 94000, 95000, ErrorMessage = "Seuls les codes postaux du 94 sont autorisés" )]
        [Display( Name = "Code postal" )]
        public int PostalCode { get; set; }
    }
}
