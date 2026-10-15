namespace Pagkaliwangan_ShortExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cboOperationDone.Items.Count > 0)
            {
                cboOperationDone.SelectedIndex = 0;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtFirstNumber.Text, out double firstNumber))
            {
                MessageBox.Show("Please enter a valid first number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstNumber.Focus();
                return;
            }
            if (!double.TryParse(txtSecondNumber.Text, out double secondNumber))
            {
                MessageBox.Show("Please enter a valid second number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSecondNumber.Focus();
                return;
            }

            double result = 0;
            int selectedOperation = cboOperationDone.SelectedIndex;

            switch (selectedOperation)
            {
                case 0:
                    result = firstNumber + secondNumber;
                    break;

                case 1:
                    result = firstNumber - secondNumber;
                    break;

                case 2:
                    result = firstNumber * secondNumber;
                    break;

                case 3:
                    if (secondNumber == 0)
                    {
                        lblResult.Text = "Invalid, Cannot Divide by Zero (0)";
                        MessageBox.Show("Division by zero is not allowed.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSecondNumber.Focus();
                    }

                    result = firstNumber / secondNumber;

                    break;

                default:
                    MessageBox.Show("Please select an operation.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            lblResult.Text = $"{result}";

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

        private void btnQuitCalculator_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
