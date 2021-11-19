using System;
using System.Collections.Generic;

namespace Lesson_7_Animal_Adoption_Centre
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet1 = new Pet
            {
                animal = "cat",
                name = "Sooty",
                age = 4
            };

            var pet2 = new Pet();

            pet2.animal = "dog";
            pet2.name = "Lola";
            pet2.age = 2;

            var pet3 = new Pet
            {
                animal = "tortoise",
                name = "Tan",
                age = 16
            };

            var pets = new List<Pet>
            {
                pet1, pet2, pet3
            };

            foreach (var pet in pets)
            {
                pet.DisplayDetails();
            }

            var headOffice = new Address
            {
                streetNumber = "48A",
                streetName = "North Terrace",
                city = "Adelaide",
                postcode = 5000
            };

            var regionalOffice = new Address
            {
                streetNumber = "1034",
                streetName = "Main Street",
                city = "Gawler",
                postcode = 5118
            };
            var headOfficeAddress = headOffice.GetAddress();
            var regionalOfficeAddress = regionalOffice.GetAddress();

            Console.WriteLine($"Our head office is located at {headOfficeAddress} and our regional office is located at {regionalOfficeAddress}.");
        }

        public class Pet
        {
            public string animal;
            public string name;
            public int age;

            public void DisplayDetails()
            {
                Console.WriteLine($"A {age} year old {animal} named {name} is availale for adoption!");
            }

        }

        public class Address
        {
            public string streetNumber;
            public string streetName;
            public string city;
            public int postcode;

            public string GetAddress()
            {
                return $"{streetNumber} {streetName}, {city}";
            }
        }
    }
}
