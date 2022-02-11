using System;
using System.Collections.Generic;
using System.Linq;

namespace ProTrans.Optimiz.Mvc4KendoWeb.Areas.LogOn.Controllers
{
    public class TestClass
    {
        public static void Main(string[] args)
        {
            //Task 1. Add the manufacturedDetail1, manufacturedDetail2 and manufacturedDetail3 into the manufacturedDetails list and add some list to manufacturedDetails(eg: manufacturedDetails4,...)

            List<ManufacturedDetails> manufacturedDetails = new List<ManufacturedDetails>();
            var manufacturedDetail1 = new ManufacturedDetails()
            {
                Id = 1,
                FoodName = "Biscuit",
                ManufacturingDate = new DateTime(2018, 12, 29),
                ExpiredDate = new DateTime(2019, 07, 15),
                IsColdItem = true
            };
            var manufacturedDetail2 = new ManufacturedDetails()
            {
                Id = 2,
                FoodName = "Honey",
                ManufacturingDate = new DateTime(2019, 01, 10),
                ExpiredDate = new DateTime(2019, 06, 25),
                IsColdItem = false
            };
            var manufacturedDetail3 = new ManufacturedDetails()
            {
                Id = 3,
                FoodName = "ButterChocolate",
                ManufacturingDate = new DateTime(2018, 10, 30),
                ExpiredDate = new DateTime(2019, 03, 12),
                IsColdItem = false
            };
            var manufacturedDetail4 = new ManufacturedDetails()
            {
                Id = 4,
                FoodName = "Icecream",
                ManufacturingDate = new DateTime(2022, 05, 02),
                ExpiredDate = new DateTime(2022, 11, 02),
                IsColdItem = true
            };
            var manufacturedDetail5 = new ManufacturedDetails()
            {
                Id = 5,
                FoodName = "Chips",
                ManufacturingDate = new DateTime(2022, 01, 18),
                ExpiredDate = new DateTime(2022, 02, 20),
                IsColdItem = false
            };

            manufacturedDetails.Add(manufacturedDetail1);
            manufacturedDetails.Add(manufacturedDetail2);
            manufacturedDetails.Add(manufacturedDetail3);
            manufacturedDetails.Add(manufacturedDetail4);
            manufacturedDetails.Add(manufacturedDetail5);


            foreach (ManufacturedDetails foodlist in manufacturedDetails)
            {
                Console.WriteLine(foodlist.Id + ". Name :" + foodlist.FoodName + " Manufactured Date : " + foodlist.ManufacturingDate.ToShortDateString() + "Expired Date : " + foodlist.ExpiredDate.ToShortDateString() + " Is cold item : " + foodlist.IsColdItem + "\n");
            }

            Console.ReadLine();




            //Task 2. Remove from the manufacturedDetails list, if ExpiredDate is Expired in (Check with CurrentDate).

            manufacturedDetails.RemoveAll(Date => Date.ExpiredDate <= DateTime.Today);





            //Task 3. Display all manufacturedDetails from the manufacturedDetails list. RECORDWISE TABLE SEPARATED VALUES.

            Console.WriteLine("Id" + " \t " + "Foodname" + " \t " + "ManufacturingDate" + " \t " + "ExpiredDate" + " \t " + "IsColdItem");
            Console.WriteLine("--------------------------------------------------------------------------------");
            foreach (var detail in manufacturedDetails)
            {
                Console.WriteLine(detail.Id + " \t " +
                    detail.FoodName + "\t  " +
                    detail.ManufacturingDate.ToShortDateString() + " \t\t " +
                    detail.ExpiredDate.ToShortDateString() + " \t \t" + 
                    detail.IsColdItem + "\n");
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();





            //Task 4. Initialize the values for the "Vitamins" property. This should be a collection of strings, using an inbuilt method.
            manufacturedDetail1.Vitamins = new List<string> { "Vitamin A", "Vitamin B" };
            manufacturedDetail2.Vitamins = new List<string> { "Vitamin B", "Vitamin C" };
            manufacturedDetail3.Vitamins = new List<string> { "Vitamin C", "Vitamin D" };
            manufacturedDetail4.Vitamins = new List<string> { "Vitamin D", "Vitamin A" };
            manufacturedDetail5.Vitamins = new List<string> { "Vitamin E", "Vitamin A" };





            //Task 5. Print the Name of the FoodName and Vitamins in console as comma separated values.
            foreach (var details in manufacturedDetails)
            {
                Console.WriteLine(details.FoodName + " \t " + 
                    string.Join(",", details.Vitamins));
            }
            Console.ReadLine();





            //Task 9. Initialize the values for the "Ingredients" property to new class. This should be a collection of strings, using an inbuilt method.

            List<NewClass> newDetails = new List<NewClass>();
            var newDetails1 = new NewClass()
            {
                Id = 6,
                FoodName = "Fruitsalad",
                ManufacturingDate = new DateTime(2018, 12, 29),
                ExpiredDate = new DateTime(2019, 12, 15),
                IsColdItem = true,
                Vitamins = new List<string> { "Vitamin A" },
                ManufacturedCity = "Chennai",
                ManufacturedCompany = "Fresh greens",
                Ingredients = new List<string> { "Apple" }

            };
            newDetails.Add(newDetails1);
            manufacturedDetails.Add(newDetails1);






            //Task 10. Display all data like (Id,FoodName,ManufacturingDate,ExpiredDate,IsColdItem,Vitamins,ManufacturedCompany,Ingredients) in RECORDWISE TABLE SEPARATED VALUES and Lists are in comma separated value.
            Console.WriteLine("ID" + " \t " + "FOODNAME" + " \t " + "MANUFACTURINGDATE" + " \t " + "EXPIREDDATE" + " \t " + "ISCOLDITEM" + " \t" + "VITAMINS" + "\t " + "MANUFACTURED CITY" + "\t" + "MANUFACTURED COMPANY" + "\t " + "INGREDIENTS");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var allDetails in newDetails)
            {
                Console.WriteLine(allDetails.Id + " \t " +
                    allDetails.FoodName + " \t " +
                    allDetails.ManufacturingDate.ToShortDateString() + " \t \t" +
                    allDetails.ExpiredDate.ToShortDateString() + "\t " +
                    allDetails.IsColdItem + "\t \t " + String.Join(",", allDetails.Vitamins) + " \t" +
                    allDetails.ManufacturedCity + "\t \t" +
                    allDetails.ManufacturedCompany + " \t\t" +
                    String.Join(",", allDetails.Ingredients));
            }
            Console.ReadLine();




            ManufacturedDetails.AddVitamins(manufacturedDetail1, "Vitamin B");

            var vitaminDetails = manufacturedDetail1.GetVitamins();
        }

    }


    public class Food
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
    }

    public class ManufacturedDetails : Food
    {
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public bool IsColdItem { get; set; }
        public ICollection<string> Vitamins { get; set; }



        //Task 6.  Create a method "AddVitamins" to add new ManufacturedDetails to the "Vitamins" collection.
        public static void AddVitamins(ManufacturedDetails mdetails, string newVitamin)
        {
            mdetails.Vitamins.Add(newVitamin);

        }




        //Task 7. Create another method "GetVitamins", to get the values from the "Vitamins" collection.

        public List<string> GetVitamins()
        {
            return Vitamins.ToList();

        }




    }


    //Task 8. Create a new class inherits with ManufacturedDetai1s and add some property like 
    public class NewClass : ManufacturedDetails
    {
        public string ManufacturedCompany { get; set; }
        public ICollection<string> Ingredients { get; set; }

        public int ManufacturedYear { get; set; }
        public string ManufacturedCity { get; set; }



    }



}











