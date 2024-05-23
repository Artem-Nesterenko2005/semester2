namespace CalculatorForm
{
    /// <summary>
    /// class to interact with calculator form
    /// </summary>
    public partial class CalculatorForm : Form
    {
        private CalculatorOperations calculator = new();

        /// <summary>
        /// constructor for calculator form
        /// </summary
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, MouseEventArgs e)
        {
            textBoxDivisorNull.Visible = false;
            switch (ActiveControl!.Text)
            {
                case "/":
                case "-":
                case "+":
                case "*":
                case "=":
                    calculator.PerformOperation(ActiveControl!.Text[0]);
                    textBox1.Text = calculator.GetNumber1 + calculator.GetOperation;
                    break;

                case "C":
                    textBox1.Text = null;
                    calculator.FreeData();
                    break;

                default:
                    if (ActiveControl!.Text[0] == '0' && calculator.GetNumber2 == null && calculator.GetOperation == '/')
                    {
                        textBoxDivisorNull.Visible = true;
                        return;
                    }
                    calculator.AddNumber(ActiveControl!.Text[0]);
                    textBox1.Text += ActiveControl!.Text[0];
                    break;
            }
        }
    }
}
