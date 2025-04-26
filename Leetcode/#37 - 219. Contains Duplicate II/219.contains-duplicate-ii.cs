/*
 * @lc app=leetcode id=219 lang=csharp
 *
 * [219] Contains Duplicate II
 */

// @lc code=start
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++) {
            if(map.ContainsKey(nums[i])) {
                if(i - map[nums[i]] <= k) {
                    return true;
                }
            }
            map[nums[i]] = i;
        }
        return false;
    }
}

// @lc code=end

