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
        totalCost = 0;
        hasVeggies = false;
    }

    public void AddPatty(int addedPatties)
    {
        patties += addedPatties;
    }

    public void AddCheese(int addedCheese)
    {
        cheese += addedCheese;
    }

    public void AddVeggies()
    {
        hasVeggies = true;
    }

    private void burgerCostTotal()
    {
        totalCost = 50 + (50 * patties) + (25 * cheese);
    }

    public void getBurger()
    {
        burgerCostTotal();

        if (hasVeggies == true)
        {
            Console.WriteLine($"Burger with {patties} extra pattie/s, {cheese} extra cheese/s, and veggies added! Subtotal: {totalCost} PHP");
        }
        else
        {
            Console.WriteLine($"Burger with {patties} extra pattie/s, {cheese} extra cheese/s and no veggies added! Subtotal: {totalCost} PHP");
        }
    }

    public int getBurgerCost()
    {
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

    public void setTypeAndSize(int setSide, int setSize)
    {
        if (setSize == 1)
        {
            size = "medium";
        }
        else if (setSize == 2)
        {
            size = "large";
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
    }

    private void sideCostTotal()
    {
        switch (size)
        {
            case "medium":
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
            case "large":
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

    public void getSide()
    {
        sideCostTotal();

        string inputSize = size;
        string outputSize = char.ToUpper(size[0]) + inputSize.Substring(1);

        Console.WriteLine($"{outputSize} {type} added! Subtotal: {cost} PHP");
    }

    public int getSideCost()
    {
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
        cost = 0;
    }

    public void AddCheese(int addedCheese)
    {
        cheese += addedCheese;
    }

    public void SetSpicyLevel(string spice)
    {
        spiceLevel = spice;
    }

    public void RemoveVeggies()
    {
        allMeat = true;
    }

    private void wrapCostTotal()
    {
        cost = 100 + (20 * cheese);
    }

    public void setSpice(int setSpiceLevel)
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

    public void getWrap()
    {
        wrapCostTotal();
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

    public int getWrapCost()
    {
        return cost;
    }
}