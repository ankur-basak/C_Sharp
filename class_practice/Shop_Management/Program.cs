using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodItem
{
    public class FoodItem
    {
        protected string itemName;
        protected double basePrice;

        public FoodItem()
        {

        }
        public FoodItem(string name, double price)
        {
            this.itemName = name;
            this.basePrice = price;
        }
        public virtual void CalculatePrice()
        {
            Console.WriteLine("Item: " + itemName);
            Console.WriteLine("Price: " + basePrice);
        }
    }
    class Pizza : FoodItem
    {
        int numberOfToppings;

        public Pizza() : base()
        {
            numberOfToppings = 0;
        }

        public Pizza(string name, double price, int numberOfToppings) : base(name, price)
        {
            this.numberOfToppings = numberOfToppings;
        }

        public override void CalculatePrice()
        {
            double finalPrice = basePrice + (numberOfToppings * 0.5);

            Console.WriteLine("Item: " + itemName);
            Console.WriteLine("Toppings: " + numberOfToppings);
            Console.WriteLine("Final Price: " + finalPrice);
        }

    }

    class Burger : FoodItem
    {
        public Burger() : base()
        {
            extraCheese = false;
        }
        public Burger(string name, double price, bool extraCheese) : base(name, price)
        {
            this.extraCheese = extraCheese;
        }

        public void CalculatePrice()
        {
            double finalPrice = basePrice;

            if (extraCheese)
            {
                finalPrice += 30
            }
            Console.WriteLine("Item: " + itemName);
            Console.WriteLine("Extra Cheese: " + extraCheese);
            Console.WriteLine("Final Price: " + finalPrice);
        }

        class Program
        {
            static void Main(string[] args)
            {
                Pizza pizza = new Pizza("Chicken Bbq Pizza", 10.0, 3);
                Console.WriteLine("Food Order Details:");
                pizza.CalculatePrice();

                Burger Burger = new Burger("Chicken Smokey Burger", 40, 2);
               Burger.CalculatePrice();

                Console.ReadLine();
            }
        }
    }
