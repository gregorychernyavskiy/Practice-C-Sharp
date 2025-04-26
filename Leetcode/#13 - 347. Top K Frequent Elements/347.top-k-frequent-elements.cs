/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach(int num in nums) {
            if(map.ContainsKey(num)) {
                map[num]++;
            } else {
                map[num] = 1;
            }
        }

        List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();

        foreach(var pair in map) {
            list.Add(pair);
        }
        list.Sort((a, b) => b.Value.CompareTo(a.Value));

        int[] arr = new int[k];
        for(int i = 0; i < k; i++) {
            arr[i] = list[i].Key;
        }

        return arr;
    }
}
// @lc code=end

