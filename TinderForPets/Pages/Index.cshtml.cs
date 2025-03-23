using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using TinderForPets.Model;

namespace TinderForPets.Pages
{
    public class IndexModel : PageModel
    {

        //  public Animal Cat { set;get; }

        private Pet[] animals = new Pet[3];

        private readonly ILogger<IndexModel> _logger;

        public Pet[] Pets { get => animals; set => animals = value; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Cat = new Animal("Buster", "Verdens sødeste kat", "flatten.jpg");


            Pets[0] = new Pet("Buster", "Verdens sødeste kat", "flatten.jpg","Kat",5);

            Pets[1] = new Pet("Simba", "En stor mis", "Simba21-1024x683.jpg","Kat", 2);

            Pets[2] = new Pet("Garfield", "En doven kat", "garfield-cat-breed-compressed.jpg", "Kat", 5);
        }
    }
}
