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

    private void costTotal()
    {
        totalCost = 50 + (50 * patties) + (25 * cheese);
    }

    public void getBurger()
    {
        costTotal();

        if (hasVeggies == true)
        {
            Console.WriteLine($"Burger with {patties} extra pattie/s, {cheese} extra cheese/s, and veggies added! Subtotal: {totalCost}");
        }
        else
        {
            Console.WriteLine($"Burger with {patties} extra pattie/s, {cheese} extra cheese/s and no veggies added! Subtotal: {totalCost}");
        }
    }

    public int getTotalCost()
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

    private void costTotal()
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
        costTotal();
        if (allMeat == true)
        {
            if (cheese == 0) {
                Console.WriteLine($"All meat {spiceLevel} wrap with no extra cheese included! Subtotal: {cost}");
            }
            else
            {
                Console.WriteLine($"All meat {spiceLevel} wrap with {cheese} extra cheese/s included! Subtotal: {cost}");
            }
        }
        else
        {
            string inputSpice = spiceLevel;
            string outputSpice = char.ToUpper(inputSpice[0]) + inputSpice.Substring(1);
            if (cheese == 0)
            {
                Console.WriteLine($"{outputSpice} wrap with no extra cheese included! Subtotal: {cost}");
            }
            else
            {
                Console.WriteLine($"{outputSpice} wrap with {cheese} extra cheese/s included! Subtotal: {cost}");
            }
        }
    }

    public int getCost()
    {
        return cost;
    }
}