using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using TinderForPets.Model;
using TinderForPets.Service;

namespace TinderForPets.Pages
{
    public class IndexModel : PageModel
    {



        private readonly ILogger<IndexModel> _logger;
        private readonly PetService _ps;

        public List<Pet> Pets { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, PetService petservice)
        {
            _logger = logger;
            _ps = petservice;
        }

        public void OnGet()
        {
            Pets = _ps.GetAll();
        }
    }
}
