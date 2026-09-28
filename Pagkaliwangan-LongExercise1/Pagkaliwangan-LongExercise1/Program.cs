using System.Runtime.InteropServices;
using System.Collections;

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

    public void GetBurger()
    {
        CalculateBurgerCostTotal();

        if (hasVeggies == true)
        {
            Console.WriteLine($"Burger with {patties} extra pattie/s, {cheese} extra cheese/s, and veggies added! Subtotal: {totalCost} PHP");
        }
        else
        {
            Console.WriteLine($"Burger with {patties} extra pattie/s, {cheese} extra cheese/s and no veggies added! Subtotal: {totalCost} PHP");
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

    public void GetSide()
    {
        CalculateSideCostTotal();
        Console.WriteLine($"{size} {type} added! Subtotal: {cost} PHP");
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

    public void RemoveVeggies()
    {
        allMeat = true;
    }

    private void CalculateWrapCostTotal()
    {
        cost = 100 + (20 * cheese);
    }

    public void GetWrap()
    {
        CalculateWrapCostTotal();
        if (allMeat == true)
        {
            if (cheese == 0) {
                Console.WriteLine($"All meat {spiceLevel} wrap with no extra cheese included! Subtotal: {cost} PHP");
            }
            else
            {
                Console.WriteLine($"All meat {spiceLevel} wrap with {cheese} extra cheese/s included! Subtotal: {cost} PHP");
            }
        }
        else
        {
            string inputSpice = spiceLevel;
            string outputSpice = char.ToUpper(inputSpice[0]) + inputSpice.Substring(1);
            if (cheese == 0)
            {
                Console.WriteLine($"{outputSpice} wrap with no extra cheese included! Subtotal: {cost} PHP");
            }
            else
            {
                Console.WriteLine($"{outputSpice} wrap with {cheese} extra cheese/s included! Subtotal: {cost} PHP");
            }
        }
    }

    public int GetWrapCost()
    {
        CalculateWrapCostTotal();
        return cost;
    }
}