using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    public class Dog
    {
        public string Name { get; set; }
        public int age {  get; set; }
    }
    class Pogram
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>() { 
            new Dog{Name="Ramo", age=12},
            new Dog{Name="Shyam",age=13},
            new Dog{Name="Parthiv",age=15}
            
            };
            var newDogList=dogs.Select(x=>new { DogName=x.Name, Age=x.age }).ToList();
            foreach(var dog in newDogList)
            {
                Console.WriteLine(dog);
            }
            var sortedDogs = dogs.OrderByDescending(x => x.age);
            foreach(var dog in sortedDogs)
            {
                    Console.WriteLine("Dog {0} is {1} years old",dog.Name,dog.age);
            }
        }
    }
}
