using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrkFloMealPlanner
{
    //Meal class to represent a name and url attached to a meal
    public class Meal
    {
        private string name;
        private string url;

        //Meal property to store information for a meal
        public Meal(string name = "None", string url = null) 
        {
            this.name = name;
            this.url = url;
        }

        //Name property for meals
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //URL property for meals
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
    //Enum for different meal types
    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner
    }

    //Constructor for a MealPlan which holds info about a day's meals
    public class MealPlan
    {
        private DateTime date;
        private Meal breakfast;
        private Meal lunch;
        private Meal dinner;

        
        //Creates a new meal plan for a day
        public MealPlan(DateTime date)
        { 
            this.date = date;
            this.breakfast = new Meal();
            this.lunch = new Meal();
            this.dinner = new Meal();

        }
        //Adds a meal 
        public void AddMeal(MealType meal, string name, string url)
        {
            switch (meal)
            {
                case MealType.Breakfast:
                    updateMeal(breakfast, name, url);
                    break;
                case MealType.Lunch:
                    updateMeal(lunch, name, url);
                    break;
                case MealType.Dinner:
                    updateMeal(dinner, name, url);
                    break;
                default: 
                    break;
            }
        }
        //Changes the meal's stored name and URL
        public void updateMeal(Meal meal, string name, string url)
        {
            meal.Name = name;
            meal.Url = url;
        }
        //Returns a string for a meal's name
        public string GetMeal(MealType meal)
        {
            switch (meal)
            {
                case MealType.Breakfast:
                    return breakfast.Name;
                    break;
                case MealType.Lunch:
                    return lunch.Name;
                    break;
                case MealType.Dinner:
                    return dinner.Name;
                    break;
                default:
                    return "None";
                    break;
            }
        }
        //Returns a string for a meal's URL
        public string GetMealURL(MealType meal)
        {
            switch (meal)
            {
                case MealType.Breakfast:
                    return breakfast.Url;
                    break;
                case MealType.Lunch:
                    return lunch.Url;
                    break;
                case MealType.Dinner:
                    return dinner.Url;
                    break;
                default:
                    return "None";
                    break;
            }
        }
    }
}
