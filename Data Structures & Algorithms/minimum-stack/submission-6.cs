public class MinStack {

    private Stack<long> stk;
    long min;

    public MinStack() {
        stk = new Stack<long>();
    }
    
    public void Push(int val) {
        if (stk.Count == 0)
        {
            min = val;
            stk.Push(0);
        }
        else
        {
            if (val < min)
            {
                long diff = val - min;
                stk.Push(diff);
                min = val;
            }
            else
            {
                long enc = val - min;
                stk.Push(enc);
            }

        }
        Console.WriteLine($"Pushed {val}");
        
    }
    
    public void Pop() {
        long enc = stk.Pop();
        if (enc < 0)
        {
            long val = min;
            min = min - enc;
            Console.WriteLine($"Popped {val}");
        }
        else
        {
            long val = enc + min;
            Console.WriteLine($"Popped {val}");
        }
        
    }
    
    public int Top() {
        long enc_top = stk.Peek();
        long top;

        if (enc_top < 0)
        {
            top = min;
        }
        else
        {
            top = (int)(enc_top + min);
        }
            
        Console.WriteLine($"Top is {top}");
        return (int)top;
    }
    
    public int GetMin() {
        Console.WriteLine($"Got min {min}");
        return (int)min;
    }
}
