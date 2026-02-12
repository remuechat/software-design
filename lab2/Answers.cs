using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Answers
    {
    }
}

// #1 What are the advantages of recursion over iteration?

// It can be potential useful in situations where the problem can be broken down into smaller subproblems of the same type,
// and by then the program takes more resources (in terms of memory and processing power) to execute due to the overhead of multiple function calls.
// The tradeoff is between simplicity, time complexity and space complexity.

// #2 How can recursion be optimized in large-scale problems?

// There's multitudes of recursion optimization techniques, such as parallel processing and 
// memoization (caching previously computed results to avoid redundant calculations).

// OBSERVATION

// This activity, we are implementing various mathematical functions through recursion.
// While using the factorial function, I noticed that the higher the input, the greater time
// the program takes to generate an output. In particular, when I have 50 as input, the program
// hangs. The memory usage goes up to 1GB with high power draw. This is due to the fact that
// each recursive call spawns more instance of itself which makes the software buggy.