/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int max = nums[0];
        int count = 0;

        foreach(int num in nums) {
            if(map.ContainsKey(num)) {
                map[num]++;
            } else {
                map[num] = 1;
            }
        }

        foreach(var entry in map) {
            if(entry.Value > count) {
                max = entry.Key;
                count = entry.Value;
            }
        }
        return max;
    }
}
// @lc code=end

