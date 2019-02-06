using System;
using System.Collections.Generic;

class Ninja
{
	private int calorieIntake;
	public List<Food> FoodHistory;
	
	public Ninja()
	{
		calorieIntake = 0;
	}
	
	public void Eat(Food item)
	{
		if (calorieIntake <= 1200) {
			calorieIntake += item.Calories;
			FoodHistory.Add(item);
			if (item.IsSweet && item.IsSpicy) {
				Console.WriteLine(item.Name + "hmmm tastes Sweet and Spicy");
			} else if (item.IsSweet || item.IsSpicy) {
				if (item.IsSweet) {
					Console.WriteLine(item.Name + "hmmm tastes Sweet");
				} else {
					Console.WriteLine(item.Name + "hmm tastes Spicy");
				}
			}
		} else {
			Console.WriteLine("Ninja does not need food badly.");
		}
	}
}

class Food
{
	public string Name;
	public int Calories;
	
	public bool IsSpicy;
	public bool IsSweet;
	
	public Food(string name, int cals, bool spicy, bool sweet)
	{
		Name = name;
		Calories = cals;
		IsSpicy = spicy;
		IsSweet = sweet;
	}
}

class Buffet
{
	public List<Food> Menu;
	
	public Buffet()
	{
		/*Menu = new List<Food>()
		{
			//new Food("Hotdog Sushi", 600, false, false);
		};*/
		Food item1 = new Food("Hotdog Sushi", 600, false, false);
		Food item2 = new Food("Pretzel Sushi", 400, false, false);
		Food item3 = new Food("Pickle Sushi", 300, false, false);
		Food item4 = new Food("Peanut Butter Sushi", 333, false, false);
		Food item5 = new Food("Coffee Bean Sushi", 224, false, false);
		Food item6 = new Food("Chocolate Sushi", 660, false, false);
		Food item7 = new Food("Bunny Rabbit Sushi", 543, false, false);
		Menu.Add(item1);
		Menu.Add(item2);
		Menu.Add(item3);
		Menu.Add(item4);
		Menu.Add(item5);
		Menu.Add(item6);
		Menu.Add(item7);
	}
	
	public Buffet(Food _Food)
	{
		Menu.Add(_Food);
	}
	
	public Food Serve()
	{
		Random rand = new Random();
		int x = rand.Next(0,Menu.Count);
		return(Menu[x]);
	}
}
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}