//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lambda_Expression
//{
   
//    public class Dog
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
       

//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            // the Select method is used in LINQ (Language Integrated Query) to transform the elements of a collection into a new form.
//           // It's commonly used to project each element of a sequence into a new form by applying a function to each element.
//            List<Dog> dogs = new List<Dog>()
//            {
//                new Dog{Name="Rocky",Age=2},
//                new Dog{Name="Ramo",Age=7},
//                new Dog{Name="Shyamu",Age=6}
//            };
//            var DogName = dogs.Select(x => x.Age).ToList();
//            foreach(var dog in DogName)
//            {
//                Console.WriteLine(dog);
//            }
//        }

//    }


//}
