/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        int k = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (set.Add(nums[i])) {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}
// @lc code=end

