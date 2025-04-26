/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int count = 0;
        int[] arr = new int[nums.Length];
        int total = 1;

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == 0) {
                count++;
                continue;
            }
            total *= nums[i];
        }

        for(int i = 0; i < nums.Length; i++) {
            if(count > 1) {
                arr[i] = 0;
            }
            else if(count == 1) {
                if(nums[i] == 0) {
                    arr[i] = total;
                } else {
                    arr[i] = 0;
                }
            } else {
                arr[i] = total / nums[i];
            }
        }
        return arr;
    }
}
// @lc code=end