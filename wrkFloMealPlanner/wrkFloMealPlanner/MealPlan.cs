using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrkFloMealPlanner
{
    public class Meal
    {
        private string name;
        private string url;
        public Meal(string name = "None", string url = null) 
        {
            this.name = name;
            this.url = url;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner
    }
    public class MealPlan
    {
        private DateTime date;
        private Meal breakfast;
        private Meal lunch;
        private Meal dinner;

        
        public MealPlan(DateTime date)
        { 
            this.date = date;
            this.breakfast = new Meal();
            this.lunch = new Meal();
            this.dinner = new Meal();

        }

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

        public void updateMeal(Meal meal, string name, string url)
        {
            meal.Name = name;
            meal.Url = url;
        }

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
