using System.Xml;
using System.Xml.Linq;

namespace Pagkaliwangan_LongExercise2
{
    public partial class Form1 : Form
    {
        // Check if user who ran the program has a orders.xml in their folder near .exe file
        // I found a method for "dynamic/relative" pathing where we make use of the Windows Form Open and Save FileDialog.
        private readonly String XMLFilePath = Path.Combine(Application.StartupPath, "orders.xml");

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Set default values for DropDowns.
            if (cboSideOrder.Items.Count > 0)
            {
                cboSideOrder.SelectedIndex = 0;
            }
            if (cboSideDishSize.Items.Count > 0)
            {
                cboSideDishSize.SelectedIndex = 0;
            }
            if (cboWrapSpiceLevel.Items.Count > 0)
            {
                cboWrapSpiceLevel.SelectedIndex = 0;
            }

            CheckIfXMLExists();

        }

        private void CheckIfXMLExists()
        {
            if (!File.Exists(XMLFilePath))
            {
                XDocument newDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    //Orders as Root node
                    //https://learn.microsoft.com/en-us/dotnet/api/system.xml.linq.xdocument?view=net-10.0
                    new XElement("Orders")
                );
                newDoc.Save(XMLFilePath);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var optionChosen = MessageBox.Show(
                "Are you sure you wish to quit the application?",
                "Quit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1
            );

            if (optionChosen == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnQuitForm_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            List<Food> orderList = new List<Food>();
            String orderSummary = "";

            //Process burger order
            if (chkOrderBurger.Checked)
            {
                Burger borgir = new Burger();

                if (!int.TryParse(txtNumBurgerPatties.Text, out int numBorgirPatty))
                {
                    MessageBox.Show("Please enter a valid numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumBurgerPatties.Focus();
                    return;
                }

                if (!int.TryParse(txtNumBurgerCheeseSlices.Text, out int numBorgirCheese))
                {
                    MessageBox.Show("Please enter a valid numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumBurgerCheeseSlices.Focus();
                    return;
                }

                borgir.AddPatty(numBorgirPatty);
                borgir.AddCheese(numBorgirCheese);

                if (chkBurgerVeggies.Checked)
                {
                    borgir.AddVeggies();
                }

                orderList.Add(borgir);
            }

            //Process wrap order
            if (chkOrderWrap.Checked)
            {
                Wrap wrapped = new Wrap();

                if (!int.TryParse(txtNumWrapCheeseSlices.Text, out int numWrappedCheese))
                {
                    MessageBox.Show("Please enter a valid numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumWrapCheeseSlices.Focus();
                    return;
                }

                wrapped.AddCheese(numWrappedCheese);

                //Since SpiceLevel function starts at 1, we can add 1 to the int since indexes start at 0.
                int spiceLevel = cboWrapSpiceLevel.SelectedIndex + 1;
                wrapped.SetSpiceLevel(spiceLevel);

                if (chkWrapAllMeat.Checked)
                {
                    wrapped.RemoveVeggies("y");
                }
                else
                {
                    wrapped.RemoveVeggies("n");
                }

                orderList.Add(wrapped);
            }

            //Process side order
            if (chkOrderSide.Checked)
            {
                Side sideDish = new Side();

                //Similar instance here as the one in spiceLevel of Wrap.
                int sideTypeVal = cboSideOrder.SelectedIndex + 1;
                int sideSizeVal = cboSideDishSize.SelectedIndex + 1;

                sideDish.SetTypeAndSize(sideTypeVal, sideSizeVal);

                orderList.Add(sideDish);
            }

            if (orderList.Count == 0)
            {
                orderSummary = "Please select at least one meal or item to include in your order.";
                lblOrderMade.Text = orderSummary;
                return;
            }

            //Write Order to orders.xml
            CheckIfXMLExists();
            XDocument doc = XDocument.Load(XMLFilePath);

            int nextOrderID = 1;
            var existingOrders = doc.Root.Elements("Order").ToList();
            if (existingOrders.Count >0)
            {
                int maxID = 0;
                foreach (XElement element in existingOrders)
                {
                    //Type casting similar to java.
                    int currentID = (int) element.Attribute("Id");
                    if (currentID > maxID)
                    {
                        maxID = currentID;
                    }

                }
                nextOrderID = maxID + 1;
            }

            int grandTotal = 0;

            foreach(Food foodOrder in orderList)
            {
                grandTotal += foodOrder.GetFoodCost();
            }

            //Inside Orders root node of XML document
            XElement orderElement = new XElement("Order",
                new XAttribute("Id", nextOrderID),
                new XAttribute("TotalCost", grandTotal),
                new XAttribute("Date", DateTime.Now.ToString("g"))
            );

            //Inside Order with id nextOrderID, grandTotal, and date.
            foreach(Food foodie in orderList)
            {
                orderElement.Add( new XElement("Meal",
                    new XElement("Description", foodie.GetFoodDescription()),
                    new XElement("Cost", foodie.GetFoodCost())
                ));
            }

            doc.Root.Add(orderElement);
            doc.Save(XMLFilePath);

            lblOrderMade.Text = $"Order #{nextOrderID} successfully saved to XML! \nTotal: {grandTotal} PHP ({orderList.Count} item/s) \nYou may view the order via the View Order. \nInput {nextOrderID} in Order ID to view your order.";

            ResetFormFields();
        }

        private void ResetFormFields()
        {
            chkOrderBurger.Checked = false;
            chkOrderWrap.Checked = false;
            chkOrderSide.Checked = false;

            txtNumBurgerPatties.Text = "";
            txtNumBurgerCheeseSlices.Text = "";
            chkBurgerVeggies.Checked = false;

            txtNumWrapCheeseSlices.Text = "";
            cboWrapSpiceLevel.SelectedIndex = 0;
            chkWrapAllMeat.Checked = false;

            cboSideOrder.SelectedIndex = 0;
            cboSideDishSize.SelectedIndex = 0;
        }

        private void btnRemoveFirstItem_Click(object sender, EventArgs e)
        {
            CheckIfXMLExists();
            XDocument doc = XDocument.Load(XMLFilePath);
            
            XElement earliestOrder = doc.Root.Elements("Order").FirstOrDefault();

            if (earliestOrder == null)
            {
                lblOrderMade.Text = "No orders exist in the XML file to delete. Queue Empty.";
                return;
            }

            String deletedID = earliestOrder.Attribute("Id").Value;
            earliestOrder.Remove();
            doc.Save(XMLFilePath);

            lblOrderMade.Text = $"Earliest Order (Order #{deletedID}) has been deleted from the XML.)";
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            CheckIfXMLExists();
            XDocument doc = XDocument.Load(XMLFilePath);

            if (!int.TryParse(txtOrderIDNumToView.Text, out int targetID))
            {
                MessageBox.Show("Please enter a valid numeric order ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrderIDNumToView.Focus();
                return;
            }

            XElement targetOrder = null;
            
            foreach(XElement element in doc.Root.Elements("Order"))
            {
                int checkedID = (int)element.Attribute("Id");
                if(checkedID == targetID)
                {
                    targetOrder = element;
                    break;
                }
            }

            if (targetOrder == null)
            {
                lblOrderMade.Text = $"Order #{targetID} was not found in the XML file.";
                return;
            }

            String orderDetails = $"--- Order #{targetID} Details ---\n";
            int index = 1;
            
            foreach(var foodOrdered in targetOrder.Elements("Meal"))
            {
                String description = foodOrdered.Element("Description").Value;
                orderDetails += $"{index++}. {description}\n";
            }

            String totalCost = targetOrder.Attribute("TotalCost").Value;
            orderDetails += $"\nTotal Amount: {totalCost} PHP";

            lblOrderMade.Text = orderDetails;
        }
    }
}
