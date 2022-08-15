using CoffeeClasses.Models;
using CoffeeClasses.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace CoffeeClasses.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public Coffee? Coffee { get; set; }
        [Display(Name = "Select a Coffee Type")]
        public EnumCoffeeType CoffeeSelector { get; set; }
        public int? SelectedCoffee { get; set; }
        public bool HasData { get; set; } = false;


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPost()
        {
            HasData = true;
            Coffee = Factory.GetAStudent(SelectedCoffee);

           
            
            return Page();
        }

    }
}