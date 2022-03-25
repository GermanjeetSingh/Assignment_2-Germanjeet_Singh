using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [ApiController]
    [Route("api/[controller]/Menu")]
    // controller gets replaced with filename minus Controller keyword
    public class J1Controller : ControllerBase
    {

        [HttpGet("{burger}/{drink}/{side}/{dessert}")]
        public string Get(int burger, int drink, int side, int dessert)
        {
            /*
             * Check for correct input
             */
            if (!FoodCalorie.burgers.ContainsKey(burger))
            {
                return "Burger value should range from 1 to 4";
            }

            if (!FoodCalorie.drinks.ContainsKey(drink))
            {
                return "Drink value should range from 1 to 4";
            }

            if (!FoodCalorie.sides.ContainsKey(side))
            {
                return "Side value should range from 1 to 4";
            }

            if (!FoodCalorie.desserts.ContainsKey(dessert))
            {
                return "Dessert value should range from 1 to 4";
            }

            // Add total calories and return ouptut
            return string.Format("Your total calorie count is {0}",
                FoodCalorie.burgers[burger] +
                FoodCalorie.drinks[drink] +
                FoodCalorie.sides[side] +
                FoodCalorie.desserts[dessert]);
        }


    }
}
