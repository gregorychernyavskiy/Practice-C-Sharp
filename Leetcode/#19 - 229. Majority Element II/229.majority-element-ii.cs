/*
 * @lc app=leetcode id=229 lang=csharp
 *
 * [229] Majority Element II
 */

// @lc code=start
public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> list = new List<int>();

        int n = nums.Length / 3;

        foreach(int num in nums) {
            if(map.ContainsKey(num)) {
                map[num]++;
            } else {
                map[num] = 1;
            }
        }

        foreach (KeyValuePair<int, int> pair in map) {
            if (pair.Value > n) {
                list.Add(pair.Key);
            }
        }
        return list;
    }
}
// @lc code=end

