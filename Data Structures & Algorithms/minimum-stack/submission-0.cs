public class MinStack {

    private Stack<int> stk;
    private Stack<int> minStk;

    public MinStack() {
        stk = new Stack<int>();
        minStk = new Stack<int>();
    }
    
    public void Push(int val) {
        stk.Push(val);
        if (minStk.Count == 0 || val <= minStk.Peek())
        {
            minStk.Push(val);
        }
    }
    
    public void Pop() {
        int e = stk.Pop();
        if (e == minStk.Peek())
        {
            minStk.Pop();
        }
    }
    
    public int Top() {
        return stk.Peek();
    }
    
    public int GetMin() {
        return minStk.Peek();
    }
}
