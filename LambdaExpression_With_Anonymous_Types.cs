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
//    class Demo
//    {
//        static void Main(string[] args)
//        {
//            List<Dog> dogs = new List<Dog>()
//            {
//                new Dog{Name="Rex",Age=4},
//                new Dog{Name="Sean",Age=0},
//                new Dog{Name="Stacy",Age=3}
//            };
//            var newDogList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
//            foreach(var item in newDogList)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
