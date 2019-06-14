using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class GroupingDishes
    {
        public Dictionary<string, int> AddIngredientsAndCountsToDictionary(string[][] dishes)
        {
            Dictionary<string, int> IngredientCount = new Dictionary<string, int>();

            for (int row = 0; row < dishes.Length; row++)
            {
                for (int col = 1; col < dishes[row].Length; col++)
                {
                    if (IngredientCount.ContainsKey(dishes[row][col]))
                        IngredientCount[dishes[row][col]]++;
                    else
                        IngredientCount.Add(dishes[row][col], 1);
                }
            }

            return IngredientCount;
        }

        
        public Dictionary<string, List<string>> AddIngredientsAndTheirDishesToDictionary(string[][] dishes)
        {
            Dictionary<string, List<string>> IngredientsAndTheirDishes = new Dictionary<string, List<string>>();
   
            
            for (int row = 0; row < dishes.Length; row++)
            {
                string dish = dishes[row][0];

                for (int col = 1; col < dishes[row].Length; col++)
                {
                    string ingredient = dishes[row][col];

                    if (!IngredientsAndTheirDishes.ContainsKey(ingredient))
                        IngredientsAndTheirDishes.Add(ingredient, new List<string>());

                    IngredientsAndTheirDishes[ingredient].Add(dish);
                    //IngredientsAndTheirDishes[dishes[row][col]].Add(dishes[row][0]);
                }
            }
            
            return IngredientsAndTheirDishes;
        }

        public List<string> GetListOfIngredients(Dictionary<string, List<string>> Ingredients)
        {
            List<string> keys = Ingredients.Keys.ToArray().ToList();
            return keys;
        }

        public List<string> GetSortedListOfIngredients(List<string> ingredients)
        {
            List<string> sortedList = new List<string>();
            ingredients.Sort();
            sortedList.AddRange(ingredients);

            return sortedList;
        }


        public string[][] GroupingDishesByIngredients(string[][] dishes)
        {

            throw new NotImplementedException();
        }

    }
}
