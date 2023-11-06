using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks
{
    internal class UserInput
    {
        DrinksService drinksService = new();

        internal void GetCategoriesInput()
        {
            var categories = drinksService.GetCategories();

            //User input to choose category of drinks
            Console.WriteLine("Choose Category:");

            string category = Console.ReadLine();
            //while loop to check if the category is invalid
            while (!Validator.IsStringValid(category))
            {
                Console.WriteLine("\nInvalid Category");
                category = Console.ReadLine();
            }

            if(!categories.Any(X => X.strCategory == category))
            {
                Console.WriteLine("Category doesn't Exist.");
                GetCategoriesInput();
            }

            GetDrinksInput(category);
        }
        private void GetDrinksInput(string category)
        {
            var drinks = drinksService.GetDrinksByCategory(category);

            Console.WriteLine("Choose a drink or go back to category menu by typing 0:");

            string drink = Console.ReadLine();

            if (drink == "0") GetCategoriesInput();

            while (!Validator.IsIdValid(drink))
            {
                Console.WriteLine("\nInvalid drink");
                drink = Console.ReadLine();  
            }

            if(!drinks.Any(x => x.idDrink == drink))
            {
                Console.WriteLine("Drink doesn't exist");
                GetDrinksInput(category);
            }

            drinksService.GetDrink(drink);

            Console.WriteLine("Press any key to go back to categories menu");
            Console.ReadKey();
            if (!Console.KeyAvailable) GetCategoriesInput();
        }
    }
}
