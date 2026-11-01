namespace Pagkaliwangan_LongExercise2
{

    public interface Food
    {
        String GetFoodDescription();
        int GetFoodCost();
    }

    class Burger : Food
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

        public string GetFoodDescription()
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

        public int GetFoodCost()
        {
            CalculateBurgerCostTotal();
            return totalCost;
        }

    }


    class Side : Food
    {
        private string type;
        private string size;
        private int cost;

        public Side()
        {
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

        public string GetFoodDescription()
        {
            CalculateSideCostTotal();
            return $"{size} {type} (Subtotal: {cost} PHP)";
        }
        
        public int GetFoodCost()
        {
            CalculateSideCostTotal();
            return cost;
        }
    }


    class Wrap : Food
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

        public string GetFoodDescription()
        {
            CalculateWrapCostTotal();
            if (allMeat == true)
            {
                if (cheese == 0)
                {
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

        public int GetFoodCost()
        {
            CalculateWrapCostTotal();
            return cost;
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}