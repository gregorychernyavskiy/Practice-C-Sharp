/*
 * @lc app=leetcode id=1929 lang=csharp
 *
 * [1929] Concatenation of Array
 */

// @lc code=start
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] arr = new int[n * 2];

        for(int i = 0; i < n; i++) {
            arr[i] = nums[i];
            arr[i + n] = nums[i];
        }
        return arr;
    }
}
// @lc code=end

