namespace InformationalApplication.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using InformationalApplication.Models;

    public class ProductInputModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "Minimum 2 characters required")]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}