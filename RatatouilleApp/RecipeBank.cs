using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;

namespace RatatouilleApp
{
    [Serializable]
    class RecipeBank
    {
        private static RecipeBank instance = new RecipeBank();
        private List<Recipe> RecipeList;
        private List<int> RecentlyViewed;
        private static readonly List<string> DeletedRecipesImageList = new();

        /// <summary>
        /// RecipeBank Constructor
        /// </summary>
        private RecipeBank()
        {
            this.RecipeList = new List<Recipe>();
            this.RecentlyViewed = new List<int>();
        }

        /// <summary>
        /// Gets Instance of the RecipeBank
        /// </summary>
        /// <returns>Returns the instance of the RecipeBank.</returns>
        public static RecipeBank GetInstance()
        {
            return instance;
        }

        /// <summary>
        /// Generates new RecipeID 
        /// </summary>
        /// <returns>Returns newly generated RecipeID.</returns>
        public int GenerateNewRecipeID()
        {
            return (this.RecipeList.OrderByDescending(x => x.RecipeID).First().RecipeID) + 1;
        }

        /// <summary>
        /// Gets all Recipes
        /// </summary>
        /// <returns>Returns an instance of the RecipeList.</returns>
        public List<Recipe> GetRecipes()
        {
            return new List<Recipe>(RecipeList);
        }

        /// <summary>
        /// Get Recipe
        /// </summary>
        /// <param name="recipe_id">RecipeID of the Recipe.</param>
        /// <returns>Returns an instance of the Recipe found.</returns>
        public Recipe GetRecipeWithID(int recipe_id)
        {
            Recipe recipe = this.RecipeList.Find(x => x.RecipeID == recipe_id);
            return recipe;
        }

        /// <summary>
        /// Gets the RecentlyViewed List
        /// </summary>
        /// <returns>Returns the RecentlyViewed List.</returns>
        public List<Recipe> GetRecentlyViewedRecipes()
        {
            List<Recipe> new_list = new List<Recipe>();

            /// Reverses the RecentlyViewed List and limits its count only upto 3 Recipes
            this.RecentlyViewed.Reverse();
            while (RecentlyViewed.Count > 3)
            {
                RecentlyViewed.RemoveAt(3);
            }

            foreach (int i in this.RecentlyViewed)
                new_list.Add(this.RecipeList.Find(x => x.RecipeID == i));

            return new_list;
        }

        /// <summary>
        /// Gets Favorite Recipes
        /// </summary>
        /// <returns>Returns a lsit of Favorite Recipes.</returns>
        public List<Recipe> GetFavoriteRecipes()
        {
            List<Recipe> recipe_list = this.RecipeList.FindAll(FindFavorites);
            return recipe_list;
        }

        /// <summary>
        /// A Predicate for finding Favorite Recipes
        /// </summary>
        /// <returns>Returns the Favorite Status of a Recipe.</returns>
        private static bool FindFavorites(Recipe recipe)
        {
            return recipe.Isfavorite;
        }

        /// <summary>
        /// Gets Random Recipe from the RecipeList for Suggested Recipe
        /// </summary>
        /// <returns>Returns the randomly selected Recipe.</returns>
        public Recipe GetRandomRecipe()
        {
            Random r = new Random();
            int rand = (RecipeList.Count == 1) ? 0 : r.Next(0, RecipeList.Count);
            return RecipeList[rand];
        }

        /// <summary>
        /// Adds Recipe to the RecipeList and sorts the list 
        /// </summary>
        /// <param name="r">Recipe to be added to the RecipeList.</param>
        public void AddRecipe(Recipe r)
        {
            this.RecipeList.Add(r);
            this.RecipeList = this.RecipeList.OrderBy(x => x.Name).ToList(); // Sorts the Recipe List Order By Name Ascending
        }

        /// <summary>
        /// Adds RecipeID to the RecentlyViewed List
        /// </summary>
        /// <param name="recipe_id">RecipeID of a Recipe.</param>
        public void AddRecipeToRecentlyViewed(int recipe_id)
        {
            /// Checks if the passed RecipeID already exists in the RecentlyViewed List
            if (!this.RecentlyViewed.Contains(recipe_id))
            {
                RecentlyViewed.Add(recipe_id);
            }
        }

        /// <summary>
        /// Adds ImagePath of a Recipe to the DeletedRecipesImageList
        /// </summary>
        /// <param name="image_path">ImagePath of a Recipe.</param>
        public void AddImagePathToDeletedRecipesImageList(string image_path)
        {
            DeletedRecipesImageList.Add(image_path);
        }

        /// <summary>
        /// Updates the Favorite Status of a Recipe
        /// </summary>
        /// <param name="recipe_id">RecipeID of a Recipe.</param>
        /// <param name="isFavorite">New Favorite Status of a Recipe.</param>
        public void UpdateRecipeFavoriteStatus(int recipe_id, bool isFavorite)
        {
            int index = this.RecipeList.FindIndex(x => x.RecipeID == recipe_id);
            this.RecipeList[index].Isfavorite = isFavorite;
        }

        /// <summary>
        /// Updates Recipe
        /// </summary>
        /// <param name="recipe_id">RecipeID of a Recipe.</param>
        /// <param name="recipe">Instance of the updated Recipe.</param>
        public void UpdateRecipeWithID(int recipe_id, Recipe recipe)
        {
            bool is_fav;
            int index = this.RecipeList.FindIndex(x => x.RecipeID == recipe_id);
            is_fav = this.RecipeList[index].Isfavorite;

            this.RecipeList[index] = recipe;
            this.RecipeList[index].Isfavorite = is_fav;
        }

        /// <summary>
        /// Deletes Recipe
        /// </summary>
        /// <param name="recipe_id">RecipeID of the Recipe to be deleted.</param>
        public void DeleteRecipeWithID(int recipe_id)
        {
            /// Removes the Recipe from the RecentlyViewed List
            this.RecentlyViewed.Remove(recipe_id);

            /// Removes the Recipe from the RecipeList 
            int index = this.RecipeList.FindIndex(x => x.RecipeID == recipe_id);
            this.RecipeList.RemoveAt(index);
        }

        /// <summary>
        /// Moves images Form Temp folder to Images folder and deletes all images in Temp folder
        /// </summary>
        public static void MoveAndDeleteAllTempImages()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            string dest = @"Images\";
            foreach (var file in Directory.EnumerateFiles(@"Temp\"))
            {
                string destFile = Path.Combine(dest, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

            DirectoryInfo di = new DirectoryInfo("Temp");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        /// <summary>
        /// Deletes all images in Images folder that is found in DeletedRecipesImageList
        /// </summary>
        private static void DeleteImagesOfDeletedRecipes()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            string path = @"Images\";
            foreach (string s in DeletedRecipesImageList)
            {
                string full_path = Path.Combine(path, s);
                if(File.Exists(full_path)) File.Delete(full_path);
            }

            /// Clears the DeletedRecipesImageList
            DeletedRecipesImageList.RemoveRange(0, DeletedRecipesImageList.Count);
        }

        /// <summary>
        /// Checks if the Recipe Name exists in the RecipeList
        /// </summary>
        /// <param name="name">Recipe Name of the Recipe.</param>
        /// <returns>Returns true if a Recipe with a name is found otherwise false.</returns>
        public bool IsRecipeWithNameExists(string name)
        {
            Recipe recipe = this.RecipeList.Find(x => x.Name == name);
            return recipe != null;
        }

        /// <summary>
        /// Checks if the Recipe Name exists in the RecipeList except with the same RecipeID
        /// </summary>
        /// <param name="name">Recipe Name of the Recipe.</param>
        /// <param name="recipe_id">RecipeId of the Recipe to be excluded in the search.</param>
        /// <returns>Returns true if a Recipe with a name is found otherwise false.</returns>
        public bool IsRecipeWithNameExists(string name, int recipe_id)
        {
            Recipe recipe = this.RecipeList.Find(x => x.Name == name && x.RecipeID != recipe_id);
            return recipe != null;
        }

        /// <summary>
        /// Searches through the RecipeList
        /// </summary>
        /// <param name="keywords">Keywords to be search.</param>
        /// <returns>Returns a list of the matched recipes.</returns>
        public List<Recipe> SearchRecipeList(IEnumerable<Control> keywords)
        {
            List<Recipe> recipe_list = new List<Recipe>();
            Recipe[] all_recipes = this.RecipeList.ToArray();

            for (int i = 0; i < all_recipes.Length; i++)
            {
                int ingredients_ctr = 0;

                foreach (var keyword in keywords)
                {
                    string paragraph = all_recipes[i].Name + all_recipes[i].Ingredients + all_recipes[i].Procedure;
                    bool contains = paragraph.IndexOf(keyword.Text, StringComparison.OrdinalIgnoreCase) >= 0;

                    if (contains) ingredients_ctr++;
                }

                all_recipes[i].KeywordsFound = ingredients_ctr;
                if (all_recipes[i].KeywordsFound > 0)
                {
                    recipe_list.Add(all_recipes[i]);
                }
            }

            recipe_list = recipe_list.OrderByDescending(o => o.KeywordsFound).ToList();

            return recipe_list;
        }

        /// <summary>
        /// Reads Data from local repository and saves to the instance of the RecipeBank
        /// Called at the start of the application
        /// </summary>
        public static void ReadObject()
        {
            try
            {
                string path = "RecipeBank.rbank";
                if (!File.Exists(path)) 
                    File.Create(path);

                FileStream f = File.OpenRead(path);
                BinaryFormatter bf = new BinaryFormatter();
                instance = (RecipeBank)bf.Deserialize(f);
                
                f.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Writes Data to local repository
        /// Called On Close of the application
        /// </summary>
        public static void WriteObject()
        {
            MoveAndDeleteAllTempImages();
            DeleteImagesOfDeletedRecipes();
            try
            {
                string path = "RecipeBank.rbank";
                if (!File.Exists(path))
                    File.Create(path);

                FileStream f = File.OpenWrite(path);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, instance);
                f.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
