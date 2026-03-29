public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stk = new Stack<int>();

        foreach (string o in operations)
        {
            if (o == "C")
            {
                int e = stk.Pop();
                // Console.Write($"Popped {e}\n");
            }
            else if (o == "D")
            {
                int e = stk.Peek();
                stk.Push(e* 2);
                // Console.Write($"Pushed {e1 * e2}\n");
            }
            else if (o == "+")
            {
                int e1 = stk.Pop();
                Console.Write($"Popped {e1}\n");
                int e2 = stk.Peek();
                // Console.Write($"Popped {e2}\n");

                stk.Push(e1);
                stk.Push(e1 + e2);
                // Console.Write($"Pushed {e1 + e2}\n");
            }
            else
            {
                stk.Push(int.Parse(o));
                // Console.Write($"Pushed {int.Parse(o)}\n");

            }
        }

        // Console.Write($"end ops\n");


        int sum = 0;

        while (stk.Count > 0)
        {
            int p = stk.Pop();
            // Console.Write($"Popped {p}\n");
            sum = sum + p;

        }
        return sum;
        
    }
}