namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] BubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            bool isSwapped;

            // BubbleSort, O(n^2)
            for (int i = 0; i < n - 1; i++)
            {
                isSwapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // bubble temp up if it's greater than next element
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        isSwapped = true;
                    }
                }
                // if not, continue the traversal
                if (isSwapped == false)
                    break;
            }

            return numbers;
        }

        public int[] ReverseArrays(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n / 2; i++)
            {
                // point to the end of the array and swap, O(n/2) since it's cut in half
                int temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;
            }
            return numbers;
        }

        public int[] ProceduralSort(int[] numbers)
        {

            // Required implementation from Task 3 Procedural Programming.
            // Remove comments to use built-in Array.Sort method below.

            // Array.Sort(numbers);

            // Use functional approach to sort and then reverse the array.
            ReverseArrays(BubbleSort(numbers));
            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = ProceduralSort(numbers);
            listBox1.DataSource = sortedNumbers;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

