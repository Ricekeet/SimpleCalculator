namespace SimpleCalculator
{
    public partial class CalculatorForm : Form
    {
        string display_string = string.Empty;
        string previous_number = string.Empty;
        bool new_number = false;
        char operator_char;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            tbDisplay.ReadOnly = true;
            tbDisplay.Text = "0";
        }

        private void NewNumberClear()
        {
            display_string = string.Empty;
            tbDisplay.Text = string.Empty;
            new_number = false;
        }

        private void Button_Handler(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            switch (clickedButton.Text)
            {
                case "1":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '1';
                        break;
                    }
                case "2":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '2';
                        break;
                    }
                case "3":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '3';
                        break;
                    }
                case "4":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '4';
                        break;
                    }
                case "5":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '5';
                        break;
                    }
                case "6":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '6';
                        break;
                    }
                case "7":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '7';
                        break;
                    }
                case "8":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '8';
                        break;
                    }
                case "9":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '9';
                        break;
                    }
                case "0":
                    {
                        if (new_number)
                            NewNumberClear();

                        display_string += '0';
                        break;
                    }
                case ".":
                    {
                        if (new_number)
                            NewNumberClear();

                        if (!display_string.Contains('.'))
                            display_string += ".";
                        break;
                    }
                default:
                    {
                        Operator_Handler(clickedButton, e);
                        if (clickedButton.Text != "=")
                        {
                            display_string = previous_number;
                        }
                        else
                        {
                            previous_number = string.Empty;
                        }
                        break;
                    }
            }
            tbDisplay.Text = display_string;
        }

        private void Operator_Handler(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;

            switch (operatorButton.Text)
            {
                case "C":
                    {
                        display_string = "";
                        tbDisplay.Text = "0";
                        break;
                    }
                case "+":
                    {
                        new_number = true;
                        if (previous_number == string.Empty)
                            previous_number = tbDisplay.Text;
                        else
                        {
                            double result = LinkedOperation(operator_char,
                                double.Parse(previous_number), double.Parse(tbDisplay.Text));
                            previous_number = result.ToString();
                        }
                        operator_char = '+';
                        break;
                    }
                case "-":
                    {
                        new_number = true;
                        if (previous_number == string.Empty)
                            previous_number = tbDisplay.Text;
                        else
                        {
                            double result = LinkedOperation(operator_char,
                                double.Parse(previous_number), double.Parse(tbDisplay.Text));
                            previous_number = result.ToString();
                        }
                        operator_char = '-';
                        break;
                    }
                case "x":
                    {
                        new_number = true;
                        if (previous_number == string.Empty)
                            previous_number = tbDisplay.Text;
                        else
                        {
                            double result = LinkedOperation(operator_char,
                                double.Parse(previous_number), double.Parse(tbDisplay.Text));
                            previous_number = result.ToString();
                        }
                        operator_char = 'x';
                        break;
                    }
                case "/":
                    {
                        new_number = true;
                        if (previous_number == string.Empty)
                            previous_number = tbDisplay.Text;
                        else
                        {
                            double result = LinkedOperation(operator_char,
                                double.Parse(previous_number), double.Parse(tbDisplay.Text));
                            previous_number = result.ToString();
                        }
                        operator_char = '/';
                        break;
                    }
                case "=":
                    {
                        new_number = true;
                        double result = LinkedOperation(operator_char,
                            double.Parse(previous_number), double.Parse(tbDisplay.Text));
                        display_string = result.ToString();

                        break;
                    }
            }
        }

        private double LinkedOperation(char operator_char, double a, double b)
        {
            double result = 0.0;

            switch (operator_char)
            {
                case '+':
                    {
                        result = Add(a, b); break;
                    }
                case '-':
                    {
                        result = Subtract(a, b); break;
                    }
                case 'x':
                    {
                        result = Multiply(a, b); break;
                    }
                case '/':
                    {
                        result = Divide(a, b); break;
                    }
            }

            return result;
        }

        private double Add(double a, double b)
        {
            return (a + b);
        }
        private double Subtract(double a, double b)
        {
            return (a - b);
        }
        private double Multiply(double a, double b)
        {
            return (a * b);
        }
        private double Divide(double a, double b)
        {
            return (a / b);
        }
    }
}