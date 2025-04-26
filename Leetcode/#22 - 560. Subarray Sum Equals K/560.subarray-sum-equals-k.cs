/*
 * @lc app=leetcode id=560 lang=csharp
 *
 * [560] Subarray Sum Equals K
 */

// @lc code=start
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        map[0] = 1;
        int count = 0;
        int total = 0;

        foreach(int num in nums) {
            total += num;
            if(map.ContainsKey(total - k)) {
                count += map[total - k];
            }

            if(map.ContainsKey(total)) {
                map[total]++;
            } else {
                map[total] = 1;
            }
        }
        return count;
    }
}
// @lc code=end

