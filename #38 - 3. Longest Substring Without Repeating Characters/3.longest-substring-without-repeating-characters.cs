/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int length = 0;
        int left = 0;

        for(int right = 0; right < s.Length; right++) {
            if(map.ContainsKey(s[right]) && map[s[right]] >= left) {
                left = map[s[right]] + 1;
            }
            map[s[right]] = right;
            length = Math.Max(length, right - left + 1);
        }
        return length;
    }
}

// @lc code=end

