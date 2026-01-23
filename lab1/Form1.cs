namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] BubbleSort(int[] numbers) {
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
    }
}

// QUESTIONS. 

// #1 What are the main differences between procedural and object-oriented programming?

// The difference is more or less on the approach. The procedural paradigm focuses
// on the sequences or tasks of procedures that operate on data. In this paradigm,
// the code is written in terms of how step-by-step acts on the data itself.
// On the other hand, object-oriented paradigm focuses on creation and manipulation
// of objects instead. In this paradigm, the emphasis is clear divison of both
// encapsulated data and methods and how each interacts with one another,
// along with other encapsulated data and methods (also called classes).

// #2 How does OOP improve code reusability?

// Code reusability is improved because there's an emphasis on what data is being
// manipulated and less emphasis on how the data is manipulated. When you describe
// how the object behave (through classes), then that is infinitely reusable
// throughout the codebase. You only need to extend and customize it later on,
// instead of overrelying on structs and procedures.

// OBSERVATION

// OOP concepts can also be observed when we deal with WPF development.
// Each form is encapsulated and described through a class. Further,
// the methods in the class indicate the events that each component
// encapsulated in the form does. This creates a uniquely convinient
// synergy along with WPF and OOP.

// Note: The answers are also posted in GitHub markdown readme in
// features/week1 in the fork.