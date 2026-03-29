public class Solution {
    public int[] GetConcatenation(int[] nums) {
        // int n = nums.Length;
        int[] ans = new int[2*nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = ans[nums.Length+i] = nums[i];
        }

        return ans;
    }
}