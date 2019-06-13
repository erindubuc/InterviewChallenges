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
            /*
            string dish;
            for (int row = 0; row < dishes[0].Length; row++)
            {
                dish = dishes[row][0];
                Console.WriteLine("dish = {0}", dish);
            }
            */
            
            for (int row = 0; row < dishes.Length; row++)
            {
                string dish = dishes[row][0];

                for (int col = 0; col < dishes[row].Length; col++)
                {
                    
                    if (IngredientsAndTheirDishes.ContainsKey(dishes[row][col]))
                    {
                        IngredientsAndTheirDishes[dishes[row][col]].Add(dishes[row][0]);

                    }
                        
                    else
                    {
                        IngredientsAndTheirDishes.Add(dishes[row][col], new List<string> { dish });

                    }

                }
            }
            
            return IngredientsAndTheirDishes;
        }


        public string[][] GroupingDishesByIngredients(string[][] dishes)
        {

            throw new NotImplementedException();
        }

    }
}
