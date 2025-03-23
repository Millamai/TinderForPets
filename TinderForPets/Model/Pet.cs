namespace TinderForPets.Model
{
    public class Pet
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { set; get; }
        public int Age { get; set; }
        public string Species { set; get; }

        public Pet(string name, string description, string imagePath, string species, int age)
        {
            Name = name;
            Description = description;
            ImagePath = imagePath;
            Species = species;
            Age = age;

        }
    }
}
