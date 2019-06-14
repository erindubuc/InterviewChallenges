using HashTables;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesTests
{
    [TestFixture]
    public class GroupingDishesTests
    {
        GroupingDishes dishesToMake = new GroupingDishes();
        

        [Test]
        public void ForTwoWithOneIngredientEach_AddToDictionaryAndReturnIt()
        {
           string[][] dishes = {
                new string[] { "Salad", "Tomato" },
                new string [] { "Pizza", "Tomato" }
            };

            Dictionary<string, int> Ingredients = new Dictionary<string, int>()
            {
                { "Tomato", 2 }
            };

            foreach (var item in Ingredients)
                Console.WriteLine("key: {0}, Value: {1}", item.Key, item.Value);

            var expected = Ingredients;
            var actual = dishesToMake.AddIngredientsAndCountsToDictionary(dishes);

            Assert.AreEqual(expected, actual);
            
        }

        [Test]
        public void ForFourDishesWithFourIngredientsEach_AddToDictionaryAndReturnIt()
        {
            string[][] dishes = {
                new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" },
                new string [] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" },
                new string[] { "Quesadilla","Chicken","Cheese","Sauce" },
                new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" }
            };

            Dictionary<string, int> Ingredients = new Dictionary<string, int>()
            {
                { "Bread", 1},
                { "Cheese", 2 },
                { "Chicken", 1},
                { "Cucumber", 1 },
                { "Dough", 1},
                { "Salad", 2 },
                { "Sauce", 3 },
                { "Sausage", 1},
                { "Tomato", 3 }
            };

            foreach (var item in Ingredients)
                Console.WriteLine("key: {0}, Value: {1}", item.Key, item.Value);

            var expected = Ingredients;
            var actual = dishesToMake.AddIngredientsAndCountsToDictionary(dishes);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ForFourDishesWithFourIngredientsEach_AddIngredientsAsKeysAndListOfDishes_ReturnDict()
        {
            string[][] dishes = {
                new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" },
                new string [] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" },
                new string[] { "Quesadilla","Chicken","Cheese","Sauce" },
                new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" }
            };

            Dictionary<string, List<string>> Ingredients = new Dictionary<string, List<string>>();

            Ingredients.Add("Bread", new List<string> { "Sandwich" });
            Ingredients.Add("Cheese", new List<string> { "Quesadilla", "Sandwich" });
            Ingredients.Add("Chicken", new List<string> { "Quesadilla" });
            Ingredients.Add("Cucumber", new List<string> { "Salad" });
            Ingredients.Add("Dough", new List<string> { "Pizza" });
            Ingredients.Add("Salad", new List<string> { "Salad", "Sandwich" });
            Ingredients.Add("Sauce", new List<string> { "Salad", "Pizza", "Quesadilla" });
            Ingredients.Add("Sausage", new List<string> { "Pizza" });
            Ingredients.Add("Tomato", new List<string> { "Salad", "Pizza", "Sandwich" });

            foreach (var kvp in Ingredients)
            {
                Console.WriteLine("key: {0}", kvp.Key);

                foreach (string val in kvp.Value)
                {
                    Console.WriteLine("Values: {0}", val);
                }

            }

            var expected = Ingredients;
            var actual = dishesToMake.AddIngredientsAndTheirDishesToDictionary(dishes);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenDictionary_ReturnListofIngredientsWithMoreThanOneDish()
        {
            string[][] dishes = {
                new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" },
                new string [] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" },
                new string[] { "Quesadilla","Chicken","Cheese","Sauce" },
                new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" }
            };

            Dictionary<string, List<string>> Ingredients = new Dictionary<string, List<string>>();

            Ingredients.Add("Bread", new List<string> { "Sandwich" });
            Ingredients.Add("Cheese", new List<string> { "Quesadilla", "Sandwich" });
            Ingredients.Add("Chicken", new List<string> { "Quesadilla" });
            Ingredients.Add("Cucumber", new List<string> { "Salad" });
            Ingredients.Add("Dough", new List<string> { "Pizza" });
            Ingredients.Add("Salad", new List<string> { "Salad", "Sandwich" });
            Ingredients.Add("Sauce", new List<string> { "Salad", "Quesadilla", "Sandwich" });
            Ingredients.Add("Sausage", new List<string> { "Pizza" });
            Ingredients.Add("Tomato", new List<string> { "Salad", "Pizza", "Sandwich" });


            List<string> listOfIngredients = new List<string>();
            listOfIngredients.Add("Bread");
            listOfIngredients.Add("Cheese");
            listOfIngredients.Add("Chicken");
            listOfIngredients.Add("Cucumber");
            listOfIngredients.Add("Dough");
            listOfIngredients.Add("Salad");
            listOfIngredients.Add("Sauce");
            listOfIngredients.Add("Sausage");
            listOfIngredients.Add("Tomato");

            var expected = listOfIngredients;
            var actual = dishesToMake.GetListOfIngredients(Ingredients);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenListOfIngredients_ReturnListSortedLexicographically()
        {
            List<string> listOfIngredients = new List<string>();
            listOfIngredients.Add("Bread");
            listOfIngredients.Add("Cheese");
            listOfIngredients.Add("Tomato");
            listOfIngredients.Add("Cucumber");
            listOfIngredients.Add("Dough");
            listOfIngredients.Add("Salad");
            listOfIngredients.Add("Sauce");
            listOfIngredients.Add("Chicken");
            listOfIngredients.Add("Sausage");

            List<string> sortedList = new List<string>();
            sortedList.Add("Bread");
            sortedList.Add("Cheese");
            sortedList.Add("Chicken");
            sortedList.Add("Cucumber");
            sortedList.Add("Dough");
            sortedList.Add("Salad");
            sortedList.Add("Sauce");
            sortedList.Add("Sausage");
            sortedList.Add("Tomato");

            var expected = sortedList;
            var actual = dishesToMake.GetSortedListOfIngredients(listOfIngredients);

            Assert.AreEqual(expected, actual);

        }
    }
}
