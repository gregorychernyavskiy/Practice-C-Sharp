/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] != val) {
                nums[k] = nums[i];
                k++;

            }
        }
        return k;
    }
}
// @lc code=end

