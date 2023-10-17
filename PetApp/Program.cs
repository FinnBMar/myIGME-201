using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp{ //Finn Marable Pet App Program for PE13

    internal class Program
    {
        public class Pets //pet class
        {
            public List<Pet> petList = new List<Pet>(); //field

            public Pet this[int petIndex ] //property
            {
                get
                {
                    Pet returner;
                    try
                    {
                        returner = (Pet)petList[petIndex];
                    }
                    catch
                    {
                        returner = null;
                    }

                    return (returner);
                }

                set
                {
                    if (petIndex < petList.Count) //if the index is less than the number of list elements
                    {
                        petList[petIndex] = value; //update the existing value at that index
                    }
                    else
                    {
                        petList.Add(value); //add the value to the list
                    }
                }
            }
            public int Count //methods
            {
                get
                {
                    return petList.Count;
                }
            }
            public void Add(Pet pet)
            {
                this.petList.Add(pet);
            }
            public void Remove(Pet pet)
            {
                this.petList.Remove(pet);
            }
            public void RemoveAt(int petEl)
            {
                this.petList.RemoveAt(petEl);
            }
        }
        public abstract class Pet //Pet abstract Class
        {
            private string name; //fields 
            public int age;

            public string Name //methods
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }

            public abstract void Eat(); //abstract methods
            public abstract void Play();
            public abstract void GotoVet();

            public Pet() //empty constructor
            {
            }

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        public interface ICat //Cat interface
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
            void GotoVet();

        }
        public interface IDog //Dog Interface
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();
        }
 
        public class Cat : Pet, ICat //Cat Class
        {
            
            public override void Eat() //methods
            {
                Console.WriteLine(base.Name + ": Mew Mew");
            }
            public override void Play()
            {
                Console.WriteLine(base.Name + ": Mrow Mrow");
            }
            public void Purr()
            {
                Console.WriteLine(base.Name + ": Purrrrrr Purrrrr");
            }
            public void Scratch()
            {
                Console.WriteLine(base.Name + ": Kheeee Kheeee");
            }
            public override void GotoVet()
            {
                Console.WriteLine(base.Name + ": Nooooooooooo");
            }

            public Cat() //Constructor
            {

            }
        }

        public class Dog : Pet, IDog //Dog Class
        {
            
            public string license; //fields

            public override void Eat() //methods
            {
                Console.WriteLine(base.Name + ": Nom Nom Nom");
            }
            public override void Play()
            {
                Console.WriteLine(base.Name + ": Boof Boof!");
            }
            public void Bark()
            {
                Console.WriteLine(base.Name + " Woof Woof");
            }
            public void NeedWalk()
            {
                Console.WriteLine(base.Name + ": *sigh*");
            }
            public override void GotoVet()
            {
                Console.WriteLine(base.Name + ": Awoooo");
            }

            public Dog(string szLicense, string szName, int nAge) : base(szName, nAge) //Constructors
            {
                this.license = szLicense;
            }
        }

        static void Main(string[] args)
        {
            Pet thisPet = null; //refrence variables 
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets(); //list of pet

            Random rand = new Random(); //random number generator

            for (int i = 0; i < 50; i++) //for loop
            {
                if (rand.Next(1, 11) == 1) //10% chance of adding an animal
                {
                    if (rand.Next(0, 2) == 0) //creates a dog using user input
                    {
                        Console.WriteLine("You bought a dog!");
                        Console.WriteLine("What is your dog's name?"); //propmt user input for name
                        string tempName = Console.ReadLine();
                        Console.WriteLine("How old is your dog?");
                        int tempAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is your dog's 3 digit license?");
                        string tempLi = Console.ReadLine();

                        dog = new Dog(tempLi, tempName, tempAge);

                        pets.Add(dog);

                        Console.WriteLine("Dog's Name => " + tempName);
                        Console.WriteLine("Age => " + tempAge);
                        Console.WriteLine("License => " + tempLi);

                    }
                    else //creates a cat using user input
                    {
                        Console.WriteLine("You bought a cat!");
                        Console.WriteLine("What is your cat's name?"); //prompt user input for name
                        string tempName = Console.ReadLine();
                        Console.WriteLine("How old is your cat?");
                        int tempAge = int.Parse(Console.ReadLine());

                        cat = new Cat();
                        cat.Name = tempName;
                        cat.age = tempAge;

                        pets.Add(cat);

                        Console.WriteLine("Cat's Name => " + tempName);
                        Console.WriteLine("Age => " + tempAge);
                    }
                }
                else
                {
                    int randPet = rand.Next(0, pets.Count); //choose random pet
                    thisPet = pets[randPet];

                    if (thisPet == null) //invalid input loops
                    {
                        continue;
                    }
                    
                    else if (thisPet.GetType() == typeof(Dog)) //checks if dog type
                    {
                        iDog = (Dog)thisPet;

                        int randMethod = rand.Next(0, 5); //chooses the right method for the correct class
                        switch (randMethod)
                        {
                            case 0:
                                iDog.Eat();
                                break;
                            case 1:
                                iDog.Play();
                                break;
                            case 2:
                                iDog.Bark();
                                break;
                            case 3:
                                iDog.NeedWalk();
                                break;
                            case 4:
                                iDog.GotoVet();
                                break;
                        }
                    }
                    
                    else if (thisPet.GetType() == typeof(Cat)) //initialize a cat type 
                    {
                        iCat = (Cat)thisPet;

                        int randMethod = rand.Next(0, 5); //switch statement that randomly applies methods of the relavant class
                        switch (randMethod)
                        {
                            case 0:
                                iCat.Eat();
                                break;
                            case 1:
                                iCat.Play();
                                break;
                            case 2:
                                iCat.Purr();
                                break;
                            case 3:
                                iCat.Scratch();
                                break;
                            case 4:
                                iCat.GotoVet();
                                break;
                        }
                    }

                }
            }
        }
    }
}