namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(factorialArrayInput.Text);
            int result = RecursiveFactorial(number);
            lblFactorialResult.Text = $"Factorial: {result}";
        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = sumArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        public int FibbonaciSequence(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return FibbonaciSequence(n - 1) + FibbonaciSequence(n - 2);
        }

        private void btnFibbonacciSequence_Click(object sender, EventArgs e)
        {
            int number = int.Parse(fibArrayInput.Text);
            int result = FibbonaciSequence(number);
            lblFibbonacciResult.Text = $"Fibbonaci: {result}";
        }

        int RecursivePower(int n, int p)
        {
            if (n == 1) return p;
            else if (p == 0) return 1;
            else return n * RecursivePower(n, p - 1);
        }

        private void btnPowerCalc_Click(object sender, EventArgs e)
        {
            int x = int.Parse(lblPowN.Text);
            int power = int.Parse(lblPowX.Text);
            int result = RecursivePower(x, power);
            lblPowResult.Text = $"Power: {result}";

        }
    }
}
