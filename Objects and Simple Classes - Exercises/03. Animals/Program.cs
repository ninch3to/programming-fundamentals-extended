using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            string input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                string[] inputTokens = input.Split(' ').ToArray();
                string command = inputTokens[0];
                string name = inputTokens[1];

                if (command == "talk")
                {
                    if (dogs.ContainsKey(name))
                    {
                        dogs[name].ProduceSound();
                    }
                    else if (cats.ContainsKey(name))
                    {
                        cats[name].ProduceSound();
                    }
                    else
                    {
                        snakes[name].ProduceSound();
                    }
                }
                else
                {
                    int age = int.Parse(inputTokens[2]);
                    int parameter = int.Parse(inputTokens[3]);

                    if (command == "Dog")
                    {
                        dogs.Add(name, new Dog(name, age, parameter));
                    }
                    else if (command == "Cat")
                    {
                        cats.Add(name, new Cat(name, age, parameter));
                    }
                    else
                    {
                        snakes.Add(name, new Snake(name, age, parameter));
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var currentDog in dogs)
            {
                Dog dog = currentDog.Value;
                Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}",
                    dog.Name, dog.Age, dog.NumberOfLegs);
            }

            foreach (var currentCat in cats)
            {
                Cat cat = currentCat.Value;
                Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}",
                    cat.Name, cat.Age, cat.IntelligenceQuotient);
            }
            foreach (var currentSnake in snakes)
            {
                Snake snake = currentSnake.Value;
                Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}",
                    snake.Name, snake.Age, snake.CrueltyCoefficient);
            }
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public Dog(string name, int age, int numberOfLegs)
        {
            this.Name = name;
            this.Age = age;
            this.NumberOfLegs = numberOfLegs;
        }
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }

        public Cat(string name, int age, int iQ)
        {
            this.Name = name;
            this.Age = age;
            this.IntelligenceQuotient = iQ;
        }
        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    class Snake
    {
        public  string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public Snake(string name, int age, int crueltyCoef)
        {
            this.Name = name;
            this.Age = age;
            this.CrueltyCoefficient = crueltyCoef;
        }
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
}
