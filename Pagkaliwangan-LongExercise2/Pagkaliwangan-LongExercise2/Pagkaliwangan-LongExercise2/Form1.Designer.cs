namespace Pagkaliwangan_LongExercise2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitleHeader = new Label();
            lblBurgerOrder = new Label();
            lblWrapOrder = new Label();
            lblSideOrder = new Label();
            lblHorizontalLine = new Label();
            btnSubmitOrder = new Button();
            btnQuitForm = new Button();
            lblOrderCaption = new Label();
            lblOrderMade = new Label();
            chkOrderBurger = new CheckBox();
            chkOrderWrap = new CheckBox();
            chkOrderSide = new CheckBox();
            lblNumBurgerPatties = new Label();
            txtNumBurgerPatties = new TextBox();
            lblNumBurgerCheeseSlices = new Label();
            txtNumBurgerCheeseSlices = new TextBox();
            chkBurgerVeggies = new CheckBox();
            lblSideDishType = new Label();
            cboSideOrder = new ComboBox();
            lblSideDishSize = new Label();
            cboSideDishSize = new ComboBox();
            chkWrapAllMeat = new CheckBox();
            lblNumWrapCheeseSlices = new Label();
            txtNumWrapCheeseSlices = new TextBox();
            lblWrapSpiceLevel = new Label();
            cboWrapSpiceLevel = new ComboBox();
            lblRemoveFirstItem = new Label();
            btnRemoveFirstItem = new Button();
            lblViewOrder = new Label();
            btnViewOrder = new Button();
            lblXMLDirectoryInfo = new Label();
            lblXMLNote = new Label();
            txtOrderIDNumToView = new TextBox();
            lblOrderIDToView = new Label();
            SuspendLayout();
            // 
            // lblTitleHeader
            // 
            lblTitleHeader.AutoSize = true;
            lblTitleHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleHeader.Location = new Point(400, 20);
            lblTitleHeader.Name = "lblTitleHeader";
            lblTitleHeader.Size = new Size(367, 32);
            lblTitleHeader.TabIndex = 0;
            lblTitleHeader.Text = "Burger, Wrap, Side Order Form";
            // 
            // lblBurgerOrder
            // 
            lblBurgerOrder.AutoSize = true;
            lblBurgerOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBurgerOrder.Location = new Point(111, 70);
            lblBurgerOrder.Name = "lblBurgerOrder";
            lblBurgerOrder.Size = new Size(136, 28);
            lblBurgerOrder.TabIndex = 1;
            lblBurgerOrder.Text = "Burger Order";
            lblBurgerOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWrapOrder
            // 
            lblWrapOrder.AutoSize = true;
            lblWrapOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWrapOrder.Location = new Point(518, 70);
            lblWrapOrder.Name = "lblWrapOrder";
            lblWrapOrder.Size = new Size(123, 28);
            lblWrapOrder.TabIndex = 2;
            lblWrapOrder.Text = "Wrap Order";
            lblWrapOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSideOrder
            // 
            lblSideOrder.AutoSize = true;
            lblSideOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSideOrder.Location = new Point(935, 70);
            lblSideOrder.Name = "lblSideOrder";
            lblSideOrder.Size = new Size(112, 28);
            lblSideOrder.TabIndex = 3;
            lblSideOrder.Text = "Side Order";
            lblSideOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorizontalLine
            // 
            lblHorizontalLine.AutoSize = true;
            lblHorizontalLine.BackColor = Color.Transparent;
            lblHorizontalLine.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorizontalLine.Location = new Point(74, 52);
            lblHorizontalLine.Name = "lblHorizontalLine";
            lblHorizontalLine.Size = new Size(1027, 25);
            lblHorizontalLine.TabIndex = 4;
            lblHorizontalLine.Text = "-------------------------------------------------------------------------------------------------------------------------------------------------";
            lblHorizontalLine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubmitOrder.Location = new Point(488, 759);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new Size(190, 35);
            btnSubmitOrder.TabIndex = 5;
            btnSubmitOrder.Text = "Submit Order";
            btnSubmitOrder.UseVisualStyleBackColor = true;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // btnQuitForm
            // 
            btnQuitForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuitForm.Location = new Point(1048, 847);
            btnQuitForm.Name = "btnQuitForm";
            btnQuitForm.Size = new Size(112, 34);
            btnQuitForm.TabIndex = 6;
            btnQuitForm.Text = "Quit";
            btnQuitForm.UseVisualStyleBackColor = true;
            btnQuitForm.Click += btnQuitForm_Click;
            // 
            // lblOrderCaption
            // 
            lblOrderCaption.AutoSize = true;
            lblOrderCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderCaption.Location = new Point(85, 505);
            lblOrderCaption.Name = "lblOrderCaption";
            lblOrderCaption.Size = new Size(241, 28);
            lblOrderCaption.TabIndex = 7;
            lblOrderCaption.Text = "Order Report/Summary:";
            lblOrderCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderMade
            // 
            lblOrderMade.AutoSize = true;
            lblOrderMade.Location = new Point(111, 542);
            lblOrderMade.Name = "lblOrderMade";
            lblOrderMade.Size = new Size(155, 25);
            lblOrderMade.TabIndex = 8;
            lblOrderMade.Text = "No Order(s) Made";
            // 
            // chkOrderBurger
            // 
            chkOrderBurger.AutoSize = true;
            chkOrderBurger.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkOrderBurger.Location = new Point(111, 438);
            chkOrderBurger.Name = "chkOrderBurger";
            chkOrderBurger.Size = new Size(150, 29);
            chkOrderBurger.TabIndex = 9;
            chkOrderBurger.Text = "Order Burger";
            chkOrderBurger.UseVisualStyleBackColor = true;
            // 
            // chkOrderWrap
            // 
            chkOrderWrap.AutoSize = true;
            chkOrderWrap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkOrderWrap.Location = new Point(518, 438);
            chkOrderWrap.Name = "chkOrderWrap";
            chkOrderWrap.Size = new Size(138, 29);
            chkOrderWrap.TabIndex = 10;
            chkOrderWrap.Text = "Order Wrap";
            chkOrderWrap.UseVisualStyleBackColor = true;
            // 
            // chkOrderSide
            // 
            chkOrderSide.AutoSize = true;
            chkOrderSide.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkOrderSide.Location = new Point(935, 438);
            chkOrderSide.Name = "chkOrderSide";
            chkOrderSide.Size = new Size(128, 29);
            chkOrderSide.TabIndex = 11;
            chkOrderSide.Text = "Order Side";
            chkOrderSide.UseVisualStyleBackColor = true;
            // 
            // lblNumBurgerPatties
            // 
            lblNumBurgerPatties.AutoSize = true;
            lblNumBurgerPatties.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumBurgerPatties.Location = new Point(74, 118);
            lblNumBurgerPatties.Name = "lblNumBurgerPatties";
            lblNumBurgerPatties.Size = new Size(280, 25);
            lblNumBurgerPatties.TabIndex = 12;
            lblNumBurgerPatties.Text = "Number of Patties (50 PHP/pc):";
            // 
            // txtNumBurgerPatties
            // 
            txtNumBurgerPatties.Location = new Point(111, 146);
            txtNumBurgerPatties.Name = "txtNumBurgerPatties";
            txtNumBurgerPatties.Size = new Size(169, 31);
            txtNumBurgerPatties.TabIndex = 13;
            txtNumBurgerPatties.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNumBurgerCheeseSlices
            // 
            lblNumBurgerCheeseSlices.AutoSize = true;
            lblNumBurgerCheeseSlices.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumBurgerCheeseSlices.Location = new Point(74, 200);
            lblNumBurgerCheeseSlices.Name = "lblNumBurgerCheeseSlices";
            lblNumBurgerCheeseSlices.Size = new Size(334, 25);
            lblNumBurgerCheeseSlices.TabIndex = 14;
            lblNumBurgerCheeseSlices.Text = "Number of Cheese Slices (25 PHP/pc):";
            // 
            // txtNumBurgerCheeseSlices
            // 
            txtNumBurgerCheeseSlices.Location = new Point(111, 228);
            txtNumBurgerCheeseSlices.Name = "txtNumBurgerCheeseSlices";
            txtNumBurgerCheeseSlices.Size = new Size(169, 31);
            txtNumBurgerCheeseSlices.TabIndex = 15;
            txtNumBurgerCheeseSlices.TextAlign = HorizontalAlignment.Right;
            // 
            // chkBurgerVeggies
            // 
            chkBurgerVeggies.AutoSize = true;
            chkBurgerVeggies.CheckAlign = ContentAlignment.MiddleRight;
            chkBurgerVeggies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBurgerVeggies.Location = new Point(74, 289);
            chkBurgerVeggies.Name = "chkBurgerVeggies";
            chkBurgerVeggies.Size = new Size(152, 29);
            chkBurgerVeggies.TabIndex = 16;
            chkBurgerVeggies.Text = "Add Veggies?";
            chkBurgerVeggies.UseVisualStyleBackColor = true;
            // 
            // lblSideDishType
            // 
            lblSideDishType.AutoSize = true;
            lblSideDishType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSideDishType.Location = new Point(881, 118);
            lblSideDishType.Name = "lblSideDishType";
            lblSideDishType.Size = new Size(95, 25);
            lblSideDishType.TabIndex = 0;
            lblSideDishType.Text = "Side Dish:";
            // 
            // cboSideOrder
            // 
            cboSideOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSideOrder.DropDownWidth = 325;
            cboSideOrder.Items.AddRange(new object[] { "Fries (M - 50 PHP, L - 75 PHP)", "Onion Rings (M - 60 PHP, L - 90 PHP)", "Bacon Chips (M - 70 PHP, L - 105 PHP)" });
            cboSideOrder.Location = new Point(922, 144);
            cboSideOrder.Name = "cboSideOrder";
            cboSideOrder.Size = new Size(169, 33);
            cboSideOrder.TabIndex = 0;
            // 
            // lblSideDishSize
            // 
            lblSideDishSize.AutoSize = true;
            lblSideDishSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSideDishSize.Location = new Point(881, 200);
            lblSideDishSize.Name = "lblSideDishSize";
            lblSideDishSize.Size = new Size(134, 25);
            lblSideDishSize.TabIndex = 17;
            lblSideDishSize.Text = "Side Dish Size:";
            // 
            // cboSideDishSize
            // 
            cboSideDishSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSideDishSize.FormattingEnabled = true;
            cboSideDishSize.Items.AddRange(new object[] { "Medium", "Large" });
            cboSideDishSize.Location = new Point(922, 226);
            cboSideDishSize.Name = "cboSideDishSize";
            cboSideDishSize.Size = new Size(169, 33);
            cboSideDishSize.TabIndex = 18;
            // 
            // chkWrapAllMeat
            // 
            chkWrapAllMeat.AutoSize = true;
            chkWrapAllMeat.CheckAlign = ContentAlignment.MiddleRight;
            chkWrapAllMeat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkWrapAllMeat.Location = new Point(464, 117);
            chkWrapAllMeat.Name = "chkWrapAllMeat";
            chkWrapAllMeat.Size = new Size(117, 29);
            chkWrapAllMeat.TabIndex = 19;
            chkWrapAllMeat.Text = "All Meat?";
            chkWrapAllMeat.UseVisualStyleBackColor = true;
            // 
            // lblNumWrapCheeseSlices
            // 
            lblNumWrapCheeseSlices.AutoSize = true;
            lblNumWrapCheeseSlices.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumWrapCheeseSlices.Location = new Point(464, 200);
            lblNumWrapCheeseSlices.Name = "lblNumWrapCheeseSlices";
            lblNumWrapCheeseSlices.Size = new Size(334, 25);
            lblNumWrapCheeseSlices.TabIndex = 20;
            lblNumWrapCheeseSlices.Text = "Number of Cheese Slices (25 PHP/pc):";
            // 
            // txtNumWrapCheeseSlices
            // 
            txtNumWrapCheeseSlices.Location = new Point(509, 228);
            txtNumWrapCheeseSlices.Name = "txtNumWrapCheeseSlices";
            txtNumWrapCheeseSlices.Size = new Size(169, 31);
            txtNumWrapCheeseSlices.TabIndex = 21;
            // 
            // lblWrapSpiceLevel
            // 
            lblWrapSpiceLevel.AutoSize = true;
            lblWrapSpiceLevel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWrapSpiceLevel.Location = new Point(464, 290);
            lblWrapSpiceLevel.Name = "lblWrapSpiceLevel";
            lblWrapSpiceLevel.Size = new Size(157, 25);
            lblWrapSpiceLevel.TabIndex = 22;
            lblWrapSpiceLevel.Text = "Wrap Spice Level";
            // 
            // cboWrapSpiceLevel
            // 
            cboWrapSpiceLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWrapSpiceLevel.FormattingEnabled = true;
            cboWrapSpiceLevel.Items.AddRange(new object[] { "Mild", "Spicy", "Very Spicy" });
            cboWrapSpiceLevel.Location = new Point(509, 318);
            cboWrapSpiceLevel.Name = "cboWrapSpiceLevel";
            cboWrapSpiceLevel.Size = new Size(169, 33);
            cboWrapSpiceLevel.TabIndex = 23;
            // 
            // lblRemoveFirstItem
            // 
            lblRemoveFirstItem.AutoSize = true;
            lblRemoveFirstItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemoveFirstItem.Location = new Point(85, 732);
            lblRemoveFirstItem.Name = "lblRemoveFirstItem";
            lblRemoveFirstItem.Size = new Size(305, 25);
            lblRemoveFirstItem.TabIndex = 24;
            lblRemoveFirstItem.Text = "Remove first item from orders list?";
            // 
            // btnRemoveFirstItem
            // 
            btnRemoveFirstItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveFirstItem.Location = new Point(111, 760);
            btnRemoveFirstItem.Name = "btnRemoveFirstItem";
            btnRemoveFirstItem.Size = new Size(142, 34);
            btnRemoveFirstItem.TabIndex = 25;
            btnRemoveFirstItem.Text = "Remove";
            btnRemoveFirstItem.UseVisualStyleBackColor = true;
            btnRemoveFirstItem.Click += btnRemoveFirstItem_Click;
            // 
            // lblViewOrder
            // 
            lblViewOrder.AutoSize = true;
            lblViewOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewOrder.Location = new Point(894, 732);
            lblViewOrder.Name = "lblViewOrder";
            lblViewOrder.Size = new Size(115, 25);
            lblViewOrder.TabIndex = 26;
            lblViewOrder.Text = "View Order?";
            // 
            // btnViewOrder
            // 
            btnViewOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewOrder.Location = new Point(935, 760);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(142, 34);
            btnViewOrder.TabIndex = 27;
            btnViewOrder.Text = "View Order";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // lblXMLDirectoryInfo
            // 
            lblXMLDirectoryInfo.AutoSize = true;
            lblXMLDirectoryInfo.Location = new Point(111, 852);
            lblXMLDirectoryInfo.Name = "lblXMLDirectoryInfo";
            lblXMLDirectoryInfo.Size = new Size(478, 25);
            lblXMLDirectoryInfo.TabIndex = 28;
            lblXMLDirectoryInfo.Text = "XML file located inside bin/Debug/net[ver]-os near .exe file.";
            // 
            // lblXMLNote
            // 
            lblXMLNote.AutoSize = true;
            lblXMLNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXMLNote.Location = new Point(85, 827);
            lblXMLNote.Name = "lblXMLNote";
            lblXMLNote.Size = new Size(136, 25);
            lblXMLNote.TabIndex = 29;
            lblXMLNote.Text = "XML File Note:";
            // 
            // txtOrderIDNumToView
            // 
            txtOrderIDNumToView.Location = new Point(935, 683);
            txtOrderIDNumToView.Name = "txtOrderIDNumToView";
            txtOrderIDNumToView.Size = new Size(141, 31);
            txtOrderIDNumToView.TabIndex = 30;
            // 
            // lblOrderIDToView
            // 
            lblOrderIDToView.AutoSize = true;
            lblOrderIDToView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderIDToView.Location = new Point(893, 655);
            lblOrderIDToView.Name = "lblOrderIDToView";
            lblOrderIDToView.Size = new Size(152, 25);
            lblOrderIDToView.TabIndex = 31;
            lblOrderIDToView.Text = "Order ID to view";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 909);
            Controls.Add(lblOrderIDToView);
            Controls.Add(txtOrderIDNumToView);
            Controls.Add(lblXMLNote);
            Controls.Add(lblXMLDirectoryInfo);
            Controls.Add(btnViewOrder);
            Controls.Add(lblViewOrder);
            Controls.Add(btnRemoveFirstItem);
            Controls.Add(lblRemoveFirstItem);
            Controls.Add(cboWrapSpiceLevel);
            Controls.Add(lblWrapSpiceLevel);
            Controls.Add(txtNumWrapCheeseSlices);
            Controls.Add(lblNumWrapCheeseSlices);
            Controls.Add(chkWrapAllMeat);
            Controls.Add(cboSideDishSize);
            Controls.Add(lblSideDishSize);
            Controls.Add(cboSideOrder);
            Controls.Add(lblSideDishType);
            Controls.Add(chkBurgerVeggies);
            Controls.Add(txtNumBurgerCheeseSlices);
            Controls.Add(lblNumBurgerCheeseSlices);
            Controls.Add(txtNumBurgerPatties);
            Controls.Add(lblNumBurgerPatties);
            Controls.Add(chkOrderSide);
            Controls.Add(chkOrderWrap);
            Controls.Add(chkOrderBurger);
            Controls.Add(lblOrderMade);
            Controls.Add(lblOrderCaption);
            Controls.Add(btnQuitForm);
            Controls.Add(btnSubmitOrder);
            Controls.Add(lblHorizontalLine);
            Controls.Add(lblSideOrder);
            Controls.Add(lblWrapOrder);
            Controls.Add(lblBurgerOrder);
            Controls.Add(lblTitleHeader);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleHeader;
        private Label lblBurgerOrder;
        private Label lblWrapOrder;
        private Label lblSideOrder;
        private Label lblHorizontalLine;
        private Button btnSubmitOrder;
        private Button btnQuitForm;
        private Label lblOrderCaption;
        private Label lblOrderMade;
        private CheckBox chkOrderBurger;
        private CheckBox chkOrderWrap;
        private CheckBox chkOrderSide;
        private Label lblNumBurgerPatties;
        private TextBox txtNumBurgerPatties;
        private Label lblNumBurgerCheeseSlices;
        private TextBox txtNumBurgerCheeseSlices;
        private CheckBox chkBurgerVeggies;
        private Label lblSideDishType;
        private ComboBox cboSideOrder;
        private Label lblSideDishSize;
        private ComboBox cboSideDishSize;
        private CheckBox chkWrapAllMeat;
        private Label lblNumWrapCheeseSlices;
        private TextBox txtNumWrapCheeseSlices;
        private Label lblWrapSpiceLevel;
        private ComboBox cboWrapSpiceLevel;
        private Label lblRemoveFirstItem;
        private Button btnRemoveFirstItem;
        private Label lblViewOrder;
        private Button btnViewOrder;
        private Label lblXMLDirectoryInfo;
        private Label lblXMLNote;
        private TextBox txtOrderIDNumToView;
        private Label lblOrderIDToView;
    }
}
