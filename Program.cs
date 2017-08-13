using System;

namespace IntroToOOP
{
    class Program
    {

        // the big concept that we want to model real world data inside of our code


        // Store points 
        /**
            Point has
                latitude
                longitude
                label
                
         */


        public class Coordinate
        {
            public decimal Latitude { get; set; }
            public decimal Longitude { get; set; }
            public string Label { get; set; }

            public override string ToString()
            {
                // print out the objects lat/long with the label
                return $"{Label} is located at {Latitude}, {Longitude}";
            }
        }


        public class Pet
        {
            // Properties
            public string Name { get; set; }
            public string Breed { get; set; }
            public DateTime Birthday { get; set; } = DateTime.Now;
            public int Age { get; set; } = 0;
            public bool IsAdopted { get; set; } = false;

            public string OwnerName { get; set; }


            // Constructors
            // these are only run once, and that is when the class is created (instanctiated (sp?))
            public Pet(string name, string breed)
            {
                Console.WriteLine("Creating new pet");
                //define values that are require
                Name = name;
                Breed = breed;
            }

            // Methods
            public Boolean Adopt(string owner)
            {
                IsAdopted = true;
                OwnerName = owner;
                return IsAdopted;
            }




        }


        public class BackPack
        {
            // owner
            public string Owner { get; set; }
            // color
            public string Color { get; set; }
            // numberOfItems
            public int NumberOfItems { get; set; } = 0;
            // maxNumberOfItems
            public int MaxNumberOfItems { get; set; }

            // Who owns it, what color it is, max number items allows
            public BackPack(string owner, string color, int maxItems)
            {
                Owner = owner;
                Color = color;
                MaxNumberOfItems = maxItems;
            }

            // add an item
            public int AddItem()
            {
                // check to make sure we dont overflow our backpack
                if (NumberOfItems < MaxNumberOfItems)
                {
                    NumberOfItems++; // <- this will increment the value of NumberOfItem by one
                    return NumberOfItems;
                }
                else
                {
                    return NumberOfItems;
                }
            }

            // remove an item
            public int RemoveItem()
            {
                if (NumberOfItems > 0)
                {
                    NumberOfItems--;
                }
                return NumberOfItems;
            }


            public override string ToString()
            {
                return $"{this.Owner}, {this.Color}, {this.NumberOfItems}/{this.MaxNumberOfItems}";
            }

        }


        static void Main(string[] args)
        {

            // model w/o OOP
            // var point1Latitude = 13d;
            // var point1Longitude = 82d;
            // var point1Label = "Not good";

            // With OOP
            var point = new Coordinate();

            point.Latitude = (decimal)-82.12341;
            point.Longitude = (decimal)-27.9464;
            point.Label = "Somewhere over the rainbow";

            //  Console.WriteLine(point);

            var cat = new Pet("Fluffy", "Russian Blue");

            cat.Adopt("Peter Smith");

            //Console.WriteLine($"{cat.OwnerName} has adopted {cat.Name} that is a {cat.Breed}");

            var spot = new Pet("Spot", "Dog");
            spot.Adopt("Jannie");

            //Console.WriteLine($"{spot.OwnerName} has adopted {spot.Name} that is a {spot.Breed}");


            var myPack = new BackPack("mark", "grey", 6);
            for (var i = 0; i < 3; i++)
            {
                myPack.AddItem();
            }
            var campingPack = new BackPack("mark", "orange", 32);
            for (var i = 0; i < 13; i++)
            {
                campingPack.AddItem();
            }
            var girlFriendsPurse = new BackPack("girlfriend", "black", 3);
            for (var i = 0; i < 10; i++)
            {
                girlFriendsPurse.AddItem();
            }


            Console.WriteLine(myPack);
            Console.WriteLine(campingPack);
            Console.WriteLine(girlFriendsPurse);



        }
    }
}
