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
            Dictionary<string, int> IngredientAndItsCount = new Dictionary<string, int>();
            string ingredient;

            for (int row = 0; row < dishes.Length; row++)
            {
                for (int col = 1; col < dishes[row].Length; col++)
                {
                    ingredient = dishes[row][col];

                    if (IngredientAndItsCount.ContainsKey(ingredient))
                        IngredientAndItsCount[ingredient]++;
                    else
                        IngredientAndItsCount.Add(ingredient, 1);
                }
            }

            return IngredientAndItsCount;
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
                }
            }
            
            return IngredientsAndTheirDishes;
        }

        public List<string> GetListOfIngredientsFromDictionary(Dictionary<string, List<string>> Ingredients)
        {
            List<string> keys = Ingredients.Keys.ToArray().ToList();
            return keys;
        }

        public List<string> GetSortedListOfIngredients(List<string> ingredients)
        {
            
            List<string> sortedList = new List<string>();
            ingredients.Sort();
            foreach(var ingredient in ingredients)
                sortedList.Add(ingredient);

            return sortedList;
        }

        public List<string> GetListOfIngredientsWithMoreThanOneDish(Dictionary<string, List<string>> IngredientsAndTheirDishes)
        {
            List<string> ingredientsWithMoreThanOneDish = new List<string>();

            foreach (string ingredient in IngredientsAndTheirDishes.Keys)
                if (IngredientsAndTheirDishes[ingredient].Count > 1)
                {
                    ingredientsWithMoreThanOneDish.Add(ingredient);
                }

            return ingredientsWithMoreThanOneDish;  
        }

        public string[][] AddDishesToIngredientsList(Dictionary<string, List<string>> IngredientsAndTheirDishes)
        {
            string[][] test = new string[IngredientsAndTheirDishes.Count][];
            string[] single = new string[IngredientsAndTheirDishes.Count];

            List<string> listOfIngredientsWithDishes;

            foreach (var element in IngredientsAndTheirDishes)
            {
                if (element.Value.Count > 1)
                {
                    listOfIngredientsWithDishes = new List<string>();
                    listOfIngredientsWithDishes.Add(element.Key);

                    foreach (var part in element.Value)
                    {
                        listOfIngredientsWithDishes.Add(part);
                    }

                    listOfIngredientsWithDishes.ToArray<string>();
                    listOfIngredientsWithDishes.CopyTo(single);
                    test.Append(single);
                }
                
            }

            /*
            foreach (var ingredient in IngredientsAndTheirDishes.Keys)
            {

                if (IngredientsAndTheirDishes[ingredient].Count > 1)
                {
                    List<string> keys = Ingredients.Keys.ToArray()
                    listOfIngredientsWithDishes = new List<string>();
                    listOfIngredientsWithDishes.Add(IngredientsAndTheirDishes[ingredient].ToString());
                    listOfIngredientsWithDishes.AddRange(IngredientsAndTheirDishes[ingredient].ToList());
                    test.Append(listOfIngredientsWithDishes.ToArray());
                }

             

                }
            /*
                foreach (string ingredient in IngredientsAndTheirDishes.Keys)
            {
                if (IngredientsAndTheirDishes[ingredient].Count > 1)
                {
                    listOfIngredientsWithDishes.Add(new[] { ingredient });

                    foreach (var val in )
                    for (int indexOfDishes = 0; indexOfDishes <= IngredientsAndTheirDishes[ingredient].Count; indexOfDishes++)
                    {
                        
                    }
                    listOfIngredientsWithDishes.Add(new[] { ingredient }
                    .Concat(IngredientsAndTheirDishes[ingredient].ToArray()).ToArray());

                }

                foreach (var item in listOfIngredientsWithDishes)
                {

                }
            }
            */
            
            return test;

        }

        public string[][] GroupingDishesByIngredients(string[][] dishes)
        {
            var listOfIngredientsWithDishes = new List<string[]>();

            Dictionary<string, List<string>> dishDictionary = AddIngredientsAndTheirDishesToDictionary(dishes);
            List<string> ingredientsWithMoreThanOneDish = GetListOfIngredientsWithMoreThanOneDish(dishDictionary);
            var listOfIngredientsAlphabetically = GetSortedListOfIngredients(ingredientsWithMoreThanOneDish);

            foreach (string ingredient in listOfIngredientsAlphabetically)
            {
                if(dishDictionary.Keys.Contains(ingredient) && dishDictionary[ingredient].Count >= 2)
                {
                    listOfIngredientsWithDishes.Add(new[] { ingredient }
                    .Concat(dishDictionary[ingredient].ToArray()).ToArray());
                }

            }

            //list.Sort(new IngredientComparison());
            return listOfIngredientsWithDishes.ToArray();
        }

    }
}
