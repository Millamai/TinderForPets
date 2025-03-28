using TinderForPets.Model;

namespace TinderForPets.Repository
{
    /// <summary>
    /// Repræsenterer et repository (opbevaringssted) for kæledyr.
    /// Et repository bruges som et mellemlag mellem databasen (eller data generelt)
    /// og den kode, der har brug for data. 
    /// Repository-mønsteret gør det nemmere at adskille logik og dataadgang.
    /// </summary>
    public class PetCollectionRepository : IPetRepository
    {
        // Internt lager (in-memory) af kæledyr
        private List<Pet> _pets;

        /// <summary>
        /// Opretter et nyt repository og fylder det med eksempler på kæledyr.
        /// I en rigtig applikation ville vi typisk hente data fra en database,
        /// men her bruger vi en liste i hukommelsen.
        /// </summary>
        public PetCollectionRepository()
        {
            _pets = new List<Pet>();
            Seed();
        }

        /// <summary>
        /// Tilføjer et kæledyr til repositoryet.
        /// Dette svarer til en "Create"-operation i en database.
        /// </summary>
        /// <param name="pet">Kæledyret, der skal tilføjes.</param>
        public void Add(Pet pet)
        {
            _pets.Add(pet);
        }

        /// <summary>
        /// Henter alle kæledyr i repositoryet.
        /// Dette svarer til en "Read all"-operation i en database.
        /// </summary>
        /// <returns>En liste med alle kæledyr.</returns>
        public List<Pet> GetAll()
        {
            return _pets;
        }

        /// <summary>
        /// Fylder repositoryet med nogle eksempler.
        /// Denne metode bruges kun til test og demo og skal fjernes senere.
        /// </summary>
        private void Seed()
        {
            _pets.Add(new Pet("Buster", "Verdens sødeste kat", "flatten.jpg", "Kat", 5));
            _pets.Add(new Pet("Simba", "En stor mis", "Simba21-1024x683.jpg", "Kat", 2));
            _pets.Add(new Pet("Garfield", "En doven kat", "garfield-cat-breed-compressed.jpg", "Kat", 5));
        }
    }
}
