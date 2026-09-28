using System.Runtime.InteropServices;
using System.Collections;
using System.Diagnostics.Metrics;

class Burger
{
    private int patties;
    private int cheese;
    private int totalCost;
    private bool hasVeggies;

    public Burger()
    {
        patties = 0;
        cheese = 0;
        totalCost = 50;
        hasVeggies = false;
    }

    public void AddPatty(int addedPatties)
    {
        patties += addedPatties;
        CalculateBurgerCostTotal();
    }

    public void AddCheese(int addedCheese)
    {
        cheese += addedCheese;
        CalculateBurgerCostTotal();
    }

    public void AddVeggies()
    {
        hasVeggies = true;
        CalculateBurgerCostTotal();
    }

    private void CalculateBurgerCostTotal()
    {
        totalCost = 50 + (50 * patties) + (25 * cheese);
    }

    public string GetBurger()
    {
        CalculateBurgerCostTotal();

        if (hasVeggies == true)
        {
            return $"Burger with {patties} extra pattie/s, {cheese} extra cheese slices added, and veggies (Subtotal: {totalCost} PHP)";
        }
        else
        {
            return $"Burger with {patties} extra pattie/s, {cheese} extra cheese slices added, and no veggies (Subtotal: {totalCost} PHP)";
        }
    }

    public int GetBurgerCost()
    {
        CalculateBurgerCostTotal();
        return totalCost;
    }

}


class Side
{
    private string type;
    private string size;
    private int cost;

    public Side(){
        type = "";
        size = "";
        cost = 0;
    }

    public void SetTypeAndSize(int setSide, int setSize)
    {
        if (setSize == 1)
        {
            size = "Medium";
        }
        else if (setSize == 2)
        {
            size = "Large";
        }
        else
        {
            size = "";
        }

        switch (setSide)
        {
            case 1:
                type = "fries";
                break;
            case 2:
                type = "onion rings";
                break;
            case 3:
                type = "bacon chips";
                break;
            default:
                type = "";
                break;
        }
        CalculateSideCostTotal();
    }

    private void CalculateSideCostTotal()
    {
        switch (size)
        {
            case "Medium":
                switch (type)
                {
                    case "fries":
                        cost = 50;
                        break;
                    case "onion rings":
                        cost = 60;
                        break;
                    case "bacon chips":
                        cost = 70;
                        break;
                    default:
                        break;
                }
                break;
            case "Large":
                switch (type)
                {
                    case "fries":
                        cost = 75;
                        break;
                    case "onion rings":
                        cost = 90;
                        break;
                    case "bacon chips":
                        cost = 105;
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
    }

    public string GetSide()
    {
        CalculateSideCostTotal();
        return $"{size} {type} (Subtotal: {cost} PHP)";
    }

    public int GetSideCost()
    {
        CalculateSideCostTotal();
        return cost;
    }
}


class Wrap
{
    private bool allMeat;
    private int cheese;
    private string spiceLevel;
    private int cost;

    public Wrap()
    {
        allMeat = false;
        cheese = 0;
        spiceLevel = "";
        cost = 100;
    }

    public void AddCheese(int addedCheese)
    {
        cheese += addedCheese;
    }

    public void SetSpiceLevel(int setSpiceLevel)
    {
        switch (setSpiceLevel)
        {
            case 1:
                spiceLevel = "mild";
                break;
            case 2:
                spiceLevel = "spicy";
                break;
            case 3:
                spiceLevel = "very spicy";
                break;
            default:
                spiceLevel = "";
                break;
        }
    }

    public void RemoveVeggies(string remove)
    {
        if (remove == "y") 
        {
            allMeat = true;
        }
        else if (remove == "n")
        {
            allMeat = false;
        }
        else
        {
            allMeat = false;
            Console.WriteLine($"Input received is {remove} and out of expected inputs, allMeat has been set to false by default.");
        }
    }

    private void CalculateWrapCostTotal()
    {
        cost = 100 + (20 * cheese);
    }

    public string GetWrap()
    {
        CalculateWrapCostTotal();
        if (allMeat == true)
        {
            if (cheese == 0) {
                return $"All meat {spiceLevel} wrap with no extra cheese (Subtotal: {cost} PHP)";
            }
            else
            {
                return $"All meat {spiceLevel} wrap with {cheese} extra cheese/s included (Subtotal: {cost} PHP)";
            }
        }
        else
        {
            string inputSpice = spiceLevel;
            string outputSpice = char.ToUpper(inputSpice[0]) + inputSpice.Substring(1);
            if (cheese == 0)
            {
                return $"{outputSpice} wrap with no extra cheese (Subtotal: {cost} PHP)";
            }
            else
            {
                return $"{outputSpice} wrap with {cheese} extra cheese/s (Subtotal: {cost} PHP)";
            }
        }
    }

    public int GetWrapCost()
    {
        CalculateWrapCostTotal();
        return cost;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayList foodItems = new ArrayList();
        
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPlease choose an option: ");
            Console.WriteLine("(1) Burger (50 PHP)");
            Console.WriteLine("(2) Side (Varies)");
            Console.WriteLine("(3) Wrap (100 PHP)");
            Console.WriteLine("(4) View items");
            Console.WriteLine("(5) Remove an item");
            Console.WriteLine("(6) Finish Order");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Burger borgir = new Burger();
                    Console.Write("Please input the number of extra patties you wish to add (50 PHP per patty): ");
                    borgir.AddPatty(int.Parse(Console.ReadLine()));

                    Console.Write("Please input the number of extra cheese slices you wish to add (20 PHP per cheese slice): ");
                    borgir.AddCheese(int.Parse(Console.ReadLine()));

                    Console.Write("Would you like to add veggies (y/n)?: ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        borgir.AddVeggies();
                    }
                    foodItems.Add(borgir);
                    Console.WriteLine($"{borgir.GetBurger()} added.");

                    break;

                case "2":
                    Side sideDish = new Side();
                    Console.WriteLine("Please choose a side dish: ");
                    Console.WriteLine("(1) Fries (50 PHP for Regular, 75 PHP for Large)");
                    Console.WriteLine("(2) Onion Rings (60 PHP for Regular, 90 PHP for Large)");
                    Console.WriteLine("(3) Bacon Chips (70 PHP for Regular, 105 PHP for Large)");
                    string sideType = Console.ReadLine();

                    Console.Write("Please choose the size of your side dish: ");
                    string sideSize = Console.ReadLine();

                    sideDish.SetTypeAndSize(int.Parse(sideType), int.Parse(sideSize));

                    foodItems.Add(sideDish);
                    Console.WriteLine($"{sideDish.GetSide()} added.");

                    break;

                case "3":
                    Wrap wrapped = new Wrap();
                    Console.Write("Would you like your wrap to be all meat (y/n)?: ");
                    wrapped.RemoveVeggies(Console.ReadLine().ToLower());

                    Console.Write("Please enter the number of extra cheese you would like to add (20 PHP per cheese slice): ");
                    wrapped.AddCheese(int.Parse(Console.ReadLine()));

                    Console.WriteLine("Please select a spice level: ");
                    Console.WriteLine("(1) Mild");
                    Console.WriteLine("(2) Spicy");
                    Console.WriteLine("(3) Very Spicy");
                    wrapped.SetSpiceLevel(int.Parse(Console.ReadLine()));

                    foodItems.Add(wrapped);
                    Console.WriteLine($"{wrapped.GetWrap()} added.");

                    break;

                case "4":
                    Console.WriteLine("Your Order: ");
                    int index = 1;

                    foreach (object food in foodItems)
                    {
                        if (food is Burger itemB)
                        {
                            Console.WriteLine($"{index} {itemB.GetBurger()}");
                        }
                        else if (food is Side itemS)
                        {
                            Console.WriteLine($"{index} {itemS.GetSide()}");                        }
                        else if (food is Wrap itemW)
                        {
                            Console.WriteLine($"{index} {itemW.GetWrap()}");
                        }
                        index++;
                    }

                    break;

                case "5":
                    Console.WriteLine("Which would you like to remove: ");
                    int indexOfToBeRemoved = 1;

                    foreach (object food in foodItems)
                    {
                        if (food is Burger itemB)
                        {
                            Console.WriteLine($"{indexOfToBeRemoved} {itemB.GetBurger()}");
                        }
                        else if (food is Side itemS)
                        {
                            Console.WriteLine($"{indexOfToBeRemoved} {itemS.GetSide()}");
                        }
                        else if (food is Wrap itemW)
                        {
                            Console.WriteLine($"{indexOfToBeRemoved} {itemW.GetWrap()}");
                        }
                        index++;
                    }

                    break;

                case "6":
                    Console.WriteLine("Your Order: ");
                    int total = 0;
                    int countPos = 1;

                    foreach(object food in foodItems)
                    {
                        if (food is Burger itemB)
                        {
                            Console.WriteLine($"{countPos} {itemB.GetBurger()}");
                            total += itemB.GetBurgerCost();
                        }
                        else if (food is Side itemS)
                        {
                            Console.WriteLine($"{countPos} {itemS.GetSide()}");
                            total += itemS.GetSideCost();
                        }
                        else if(food is Wrap itemW)
                        {
                            Console.WriteLine($"{countPos} {itemW.GetWrap()}");
                            total += itemW.GetWrapCost();   
                        }
                        countPos++;
                    }

                    Console.WriteLine($"Total Price: {total} PHP");

                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid or no input, please try again.");
                    break;
            }
        }
    }
}