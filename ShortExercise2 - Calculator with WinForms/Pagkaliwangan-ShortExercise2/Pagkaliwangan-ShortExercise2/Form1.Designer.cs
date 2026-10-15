namespace Pagkaliwangan_ShortExercise2
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
            lblCalculator = new Label();
            txtFirstNumber = new TextBox();
            txtSecondNumber = new TextBox();
            cboOperationDone = new ComboBox();
            lblOperationDone = new Label();
            lblFirstNum = new Label();
            lblSecondNum = new Label();
            btnCalculate = new Button();
            lblResultCaption = new Label();
            lblResult = new Label();
            btnQuitCalculator = new Button();
            SuspendLayout();
            // 
            // lblCalculator
            // 
            lblCalculator.AutoSize = true;
            lblCalculator.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalculator.Location = new Point(510, 41);
            lblCalculator.Name = "lblCalculator";
            lblCalculator.Size = new Size(118, 30);
            lblCalculator.TabIndex = 0;
            lblCalculator.Text = "Calculator";
            lblCalculator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Location = new Point(272, 120);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(201, 31);
            txtFirstNumber.TabIndex = 1;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Location = new Point(652, 120);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(201, 31);
            txtSecondNumber.TabIndex = 2;
            // 
            // cboOperationDone
            // 
            cboOperationDone.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOperationDone.FormattingEnabled = true;
            cboOperationDone.Items.AddRange(new object[] { "Addition", "Subtraction", "Multiplication", "Division" });
            cboOperationDone.Location = new Point(473, 197);
            cboOperationDone.Name = "cboOperationDone";
            cboOperationDone.Size = new Size(211, 33);
            cboOperationDone.TabIndex = 3;
            // 
            // lblOperationDone
            // 
            lblOperationDone.AutoSize = true;
            lblOperationDone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOperationDone.Location = new Point(487, 162);
            lblOperationDone.Name = "lblOperationDone";
            lblOperationDone.Size = new Size(197, 32);
            lblOperationDone.TabIndex = 4;
            lblOperationDone.Text = "Operation Done";
            // 
            // lblFirstNum
            // 
            lblFirstNum.AutoSize = true;
            lblFirstNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFirstNum.Location = new Point(267, 85);
            lblFirstNum.Name = "lblFirstNum";
            lblFirstNum.Size = new Size(172, 32);
            lblFirstNum.TabIndex = 5;
            lblFirstNum.Text = "First Number:";
            // 
            // lblSecondNum
            // 
            lblSecondNum.AutoSize = true;
            lblSecondNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSecondNum.Location = new Point(647, 85);
            lblSecondNum.Name = "lblSecondNum";
            lblSecondNum.Size = new Size(206, 32);
            lblSecondNum.TabIndex = 6;
            lblSecondNum.Text = "Second Number:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ButtonHighlight;
            btnCalculate.BackgroundImageLayout = ImageLayout.None;
            btnCalculate.Location = new Point(499, 339);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(140, 39);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResultCaption
            // 
            lblResultCaption.AutoSize = true;
            lblResultCaption.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResultCaption.Location = new Point(267, 251);
            lblResultCaption.Name = "lblResultCaption";
            lblResultCaption.Size = new Size(91, 32);
            lblResultCaption.TabIndex = 8;
            lblResultCaption.Text = "Result:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(282, 283);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(232, 28);
            lblResult.TabIndex = 9;
            lblResult.Text = "No Operation Done Yet";
            // 
            // btnQuitCalculator
            // 
            btnQuitCalculator.Location = new Point(668, 478);
            btnQuitCalculator.Name = "btnQuitCalculator";
            btnQuitCalculator.Size = new Size(163, 41);
            btnQuitCalculator.TabIndex = 10;
            btnQuitCalculator.Text = "Quit Calculator";
            btnQuitCalculator.UseVisualStyleBackColor = true;
            btnQuitCalculator.Click += btnQuitCalculator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 784);
            Controls.Add(btnQuitCalculator);
            Controls.Add(lblResult);
            Controls.Add(lblResultCaption);
            Controls.Add(btnCalculate);
            Controls.Add(lblSecondNum);
            Controls.Add(lblFirstNum);
            Controls.Add(lblOperationDone);
            Controls.Add(cboOperationDone);
            Controls.Add(txtSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(lblCalculator);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCalculator;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private ComboBox cboOperationDone;
        private Label lblOperationDone;
        private Label lblFirstNum;
        private Label lblSecondNum;
        private Button btnCalculate;
        private Label lblResultCaption;
        private Label lblResult;
        private Button btnQuitCalculator;
    }
}
