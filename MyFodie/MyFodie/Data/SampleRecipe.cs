using MyFodie.Models;
using System.Linq;

namespace MyFodie.Data
{
    public class SampleRecipe
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Recipes.Any())
            {
                context.Recipes.Add(new Recipe
                {
                    Name = "Sushi",
                    Description = "Sushi is one of the quintessential Japanese dishes that is loved around the world. Sushi rice, flavored with rice vinegar, is delicately hand-pressed and topped with various kinds of raw seafood.",
                    Category = "Asian",
                    Ingredient = "soy sauce, wasabi, ginger"
                });
                context.Recipes.Add(new Recipe
                {
                    Name = "Kimchi",
                    Description = "Korea is known for its fermenting and pickling of foods, and kimchi is at the top of the list.",
                    Category = "Asian",
                    Ingredient = "hot chili peppers, salty fish paste, leeks, ginger, sugar, and garlic"
                });
                context.Recipes.Add(new Recipe
                {
                    Name = "Dim Sum",
                    Description = "Dim sum is a variety of bite-sized foods served with Chinese tea. These delicious small treats can include small dumplings, buns, and noodle rolls, served in bamboo steamers.",
                    Category = "Asian",
                    Ingredient = "BBQ pork buns, chicken feet, rice noodle rolls"
                });

                context.SaveChanges();
            }
        }
    }
}
