using System;
using System.Linq;

namespace KitchenPC.Modeler
{
   /// <summary>
   /// This contains a model generated by a modeling session.  The RecipeIDs contain the suggested recipes to make, and the leftover amounts indicate
   /// the quantity of given ingredients that would be left in the user's pantry after making the suggested recipes.
   /// </summary>
   public class Model
   {
      readonly Guid[] _recipeids;
      readonly PantryItem[] _pantry;
      readonly double _score;

      public Guid[] RecipeIds
      {
         get
         {
            return _recipeids;
         }
      }

      public PantryItem[] Pantry
      {
         get
         {
            return _pantry;
         }
      }

      public int Count
      {
         get
         {
            return _recipeids.Length;
         }
      }

      public double Score
      {
         get
         {
            return _score;
         }
      }

      public Model(RecipeNode[] recipes, PantryItem[] pantry, double score)
      {
         this._recipeids = recipes.Select(r => { return r.RecipeId; }).ToArray();
         this._pantry = pantry;
         this._score = score;
      }
   }
}