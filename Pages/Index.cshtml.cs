using CoffeeClasses.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace CoffeeClasses.Pages
{
   [BindProperties]
    public class IndexModel : PageModel
    {
        [Display(Name="Select a Coffee Type")]
        public EnumCoffeeType CoffeeSelector { get; set; }
        public string? SelectedCoffee { get; set; }


        public void OnGet()
        {

        }
    }
}