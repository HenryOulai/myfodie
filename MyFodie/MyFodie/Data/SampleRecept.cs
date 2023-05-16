using MyFodie.Models;

namespace MyFodie.Data
{
    public class SampleRecep
    {
        public static void Create(AppDbContext database)
        {
            
            if (!database.Recepts.Any(a => a.ID != 0))
            {
                database.Recepts.Add(new recept
                {
                    Name = "Sushi",
                    Description = "Sushi is one of the quintessential Japanese dishes that is loved around the world. Sushi rice, flavored with rice vinegar, is delicately hand-pressed and topped with various kinds of raw seafood.",
                    Category = "Asian",
                    Ingredient = "soy sauce, wasabi, ginger"
                });
                database.Recepts.Add(new recept
                {
                    Name = "Kimchi",
                    Description = "Korea is known for its fermenting and pickling of foods, and kimchi is at the top of the list.",
                    Category = "Asian",
                    Ingredient = "hot chili peppers, salty fish paste, leeks, ginger, sugar, and garlic"
                });
                database.Recepts.Add(new recept
                {
                    Name = "Dim Sum",
                    Description = "Dim sum is a variety of bite-sized foods served with Chinese tea. These delicious small treats can include small dumplings, buns, and noodle rolls, served in bamboo steamers.",
                    Category = "Asian",
                    Ingredient = "BBQ pork buns, chicken feet, rice noodle rolls"
                });
            }

            database.SaveChanges();
        }
    }
}
