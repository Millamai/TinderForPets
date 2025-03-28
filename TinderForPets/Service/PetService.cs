using TinderForPets.Model;
using TinderForPets.Repository;

namespace TinderForPets.Service
{
    /// <summary>
    /// PetService fungerer som et mellemled mellem kontrolleren (eller UI-laget)
    /// og repository-laget. 
    /// 
    /// Formålet med en serviceklasse er at håndtere forretningslogik – altså den del af systemet,
    /// hvor regler og processer kan bygges op. I dette eksempel er logikken meget enkel,
    /// men strukturen forbereder koden til fremtidige udvidelser.
    /// 
    /// Ved at bruge et interface til repositoryet (IPetRepository) kan vi nemt udskifte implementeringen
    /// uden at ændre resten af systemet – fx skifte fra en in-memory-liste til en database.
    /// </summary>
    public class PetService
    {
        // Felt til at gemme en reference til repositoryet
        private IPetRepository _repository;

        /// <summary>
        /// Opretter en ny PetService med et givet repository.
        /// Dependency Injection bruges her til at give serviceklassen adgang til repositoryet,
        /// uden at den selv skal oprette det.
        /// </summary>
        /// <param name="repo">Et repository, der implementerer IPetRepository.</param>
        public PetService(IPetRepository repo)
        {
            _repository = repo;
        }

        /// <summary>
        /// Tilføjer et kæledyr til repositoryet via serviceklassen.
        /// I en større applikation kunne man her validere data eller logge handlingen.
        /// </summary>
        /// <param name="pet">Det kæledyr, der skal tilføjes.</param>
        public void Add(Pet pet)
        {
            _repository.Add(pet);
        }

        /// <summary>
        /// Henter alle kæledyr fra repositoryet.
        /// I en større applikation kunne man her sortere, filtrere eller bearbejde data før returnering.
        /// </summary>
        /// <returns>En liste af kæledyr.</returns>
        public List<Pet> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
