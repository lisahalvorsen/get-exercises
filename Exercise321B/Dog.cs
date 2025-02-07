using CommonInterfaces;

namespace Exercise321B;

public class Dog : IExercise
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    public Dog(string name, string breed, string gender, int age)
    {
        Name = name;
        Breed = breed;
        Gender = gender;
        Age = age;
    }

    public Dog()
    {
        
    }

    public void Run()
    {
        var dogs = new[]
        {
            new Dog(name: "Buddy", breed: "Golden Retriever", gender: "Male", age: 3),
            new Dog(name: "Luna", breed: "Siberian Husky", gender: "Female", age: 2),
            new Dog(name: "Charlie", breed: "Beagle", gender: "Male", age: 4),
            new Dog(name: "Bella", breed: "Poodle", gender: "Female", age: 1),
            new Dog(name: "Rocky", breed: "German Shepherd", gender: "Male", age: 5),
        };


        Console.WriteLine("To view the dogs of a specified breed, type in the breed name below:");
        var breed = Console.ReadLine();
        var foundBreed = dogs.Where(d => d.Breed.ToLower() == breed.ToLower()).ToArray();

        if (foundBreed.Length != 0)
        {
            Console.WriteLine($"The dogs of the breed {breed} are:");
            ShowAllDogs(foundBreed);
        }
        else
        {
            Console.WriteLine($"Sorry, no dogs of the breed {breed} were found 😢");
        }
    }

    private static void ShowAllDogs(Dog[] dogs)
    {
        foreach (var dog in dogs)
        {
            Console.WriteLine($"Name: {dog.Name}, Breed: {dog.Breed}, Gender: {dog.Gender}, Age: {dog.Age}");
        }
    }
}