/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int j = target - nums[i];
            if(map.ContainsKey(j)) {
                return new int[]{map[j], i};
            }
            map[nums[i]] = i;
        }
        return new int[]{};
    }
}
// @lc code=end

