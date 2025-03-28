using TinderForPets.Model;

namespace TinderForPets.Repository
{
    /// <summary>
    /// Repræsenterer et interface for et repository, der håndterer kæledyr.
    /// Et interface definerer en kontrakt – det vil sige, det angiver,
    /// hvilke metoder en klasse skal implementere, hvis den "lover" at følge interfacet.
    /// 
    /// Dette interface bruges til at sikre, at vi kan arbejde med forskellige slags repositories
    /// (f.eks. en liste i hukommelsen eller en database) uden at ændre resten af koden.
    /// </summary>
    public interface IPetRepository  
    {
        /// <summary>
        /// Tilføjer et nyt kæledyr til repositoryet.
        /// </summary>
        /// <param name="pet">Det kæledyr, der skal tilføjes.</param>
        void Add(Pet pet);

        /// <summary>
        /// Henter alle kæledyr fra repositoryet.
        /// </summary>
        /// <returns>En liste af kæledyr.</returns>
        List<Pet> GetAll();
    }
}
