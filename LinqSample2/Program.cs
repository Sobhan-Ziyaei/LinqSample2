using LinqSample2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();

            Person p1 = new Person();
            p1.personId = 1;
            p1.name = "Sobhan";
            p1.family = "Ziyaei";
            p1.age = 28;
            people.Add(p1);

            Person p2 = new Person()
            {
                personId = 2,
                name = "Sama",
                family = "Ziyaei",
                age = 18,
            };
            people.Add(p2);

            Person p3 = new Person()
            {
                personId = 3,
                name = "Ali",
                family = "Ahmadi",
                age = 45,
            };
            people.Add(p3);

            List<PersonCar> personCarList = new List<PersonCar>() {

                new PersonCar() {personId = 1,personCarName="Pride",personCarModel ="1385"},
                new PersonCar() { personId = 2,personCarName = "Peykan" ,personCarModel = "1382"},

            };

            //var res1 = people.ToList();

            //foreach (var person in res1)
            //{
            //    Console.WriteLine($"Id : {person.personId} , Name is : {person.name} , FamilyName is : {person.family} , Age is : {person.age} ");
            //}

            //--------------------------------------------------------------------------------------------------------------------------------------------

            //var res1 = people.OrderByDescending(p => p.age).ToList();

            //foreach (var person in res1)
            //{
            //    Console.WriteLine($"Id : {person.personId} , Name is : {person.name} , FamilyName is : {person.family} , Age is : {person.age} ");
            //}

            //--------------------------------------------------------------------------------------------------------------------------------------------

            //var res1 = people.Where(p => p.name.ToLower() == "sobhan").ToList();

            //foreach (var person in res1)
            //{
            //    Console.WriteLine($"Id : {person.personId} , Name is : {person.name} , FamilyName is : {person.family} , Age is : {person.age} ");
            //}

            //--------------------------------------------------------------------------------------------------------------------------------------------

            //var res1 = people.Select(p => p.name).ToList();

            //foreach (var person in res1)
            //{
            //    //Console.WriteLine($"Id : {person.personId} , Name is : {person.name} , FamilyName is : {person.family} , Age is : {person.age} ");
            //    Console.WriteLine($"Name is {person}");
            //}

            //--------------------------------------------------------------------------------------------------------------------------------------------

            //var res1 = people.Select(p => new { p.name, p.age }).ToList();

            //foreach (var person in res1)
            //{
            //    //Console.WriteLine($"Id : {person.personId} , Name is : {person.name} , FamilyName is : {person.family} , Age is : {person.age} ");
            //    Console.WriteLine($"Name is {person.name} and Age is {person.age}");
            //}

            //--------------------------------------------------------------------------------------------------------------------------------------------

            var join = (from person in people
                        join car in personCarList on person.personId equals car.personId
                        select new
                        {

                            person.personId,
                            person.name,
                            person.family,
                            person.age,
                            car.personCarName,
                            car.personCarModel,
                        });

            foreach (var item in join)
            {
                Console.WriteLine($"Name is : {item.name} , FamilyName is : {item.family} , Age is {item.age} , Car Name is {item.personCarName} , Car Model is {item.personCarModel}");
            }



            Console.ReadKey();
        }
    }
}