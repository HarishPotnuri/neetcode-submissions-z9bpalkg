public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        int max = arr[n-1];
        arr[n-1] = -1;
        for (int i = n-2; i>=0; i--)
        {
            if (arr[i] > max)
            {
                int prvMax = max;
                max = arr[i];
                arr[i] = prvMax;
            }
            else
            {
                arr[i] = max;
            }
        }
        return arr;
        
    }
}