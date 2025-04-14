/*
 * @lc app=leetcode id=209 lang=csharp
 *
 * [209] Minimum Size Subarray Sum
 */

// @lc code=start
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int minLength = int.MaxValue;
        int sum = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++) {
            sum += nums[right];
            
            while (sum >= target) {
                minLength = Math.Min(minLength, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }
        
        if (minLength == int.MaxValue) {
            return 0;
        } else {
            return minLength;
        }
    }
}
// @lc code=end

