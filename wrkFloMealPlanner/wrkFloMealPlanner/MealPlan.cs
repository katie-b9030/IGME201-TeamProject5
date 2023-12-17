using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrkFloMealPlanner
{
    internal class MealPlan
    {
        private DateTime date;
        private KeyValuePair<string, string> breakfast;
        private KeyValuePair<string, string> lunch;
        private KeyValuePair<string, string> dinner;

        public enum Meal
        {
            Breakfast,
            Lunch,
            Dinner
        }

       
        public MealPlan(DateTime date, 
            KeyValuePair<string, string> breakfast = new KeyValuePair<string, string>(), 
            KeyValuePair<string, string> lunch = new KeyValuePair<string, string>(), 
            KeyValuePair<string, string> dinner = new KeyValuePair<string, string>()) 
        { 
            this.date = date;
           
        }

        public KeyValuePair<string, string> Breakfast
        {
            get { return this.breakfast; }
            set { this.breakfast = value; }
        }

        public KeyValuePair<string, string> Lunch
        {
            get { return this.lunch; }
            set { this.lunch = value; }
        }

        public KeyValuePair<string, string> Dinner
        {
            get { return this.dinner; }
            set { this.dinner = value; }
        }

        public void AddMeal(Meal meal, string name, string url)
        {
            switch (meal)
            {
                case Meal.Breakfast:
                    updateMeal(Breakfast, name, url);
                    break;
                case Meal.Lunch:
                    updateMeal(Lunch, name, url);
                    break;
                case Meal.Dinner:
                    updateMeal(Dinner, name, url);
                    break;
                default: 
                    break;
            }
        }

        public void updateMeal(KeyValuePair<string, string> mealKVP, string name, string url)
        {
            mealKVP = new KeyValuePair<string, string>(name, url);
        }
    }
}
