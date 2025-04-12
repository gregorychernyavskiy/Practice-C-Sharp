/*
 * @lc app=leetcode id=424 lang=csharp
 *
 * [424] Longest Repeating Character Replacement
 */

// @lc code=start
public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int left = 0;
        int length = 0;
        int result = 0;
        
        for (int right = 0; right < s.Length; right++) {
            if (map.ContainsKey(s[right])) {
                map[s[right]]++;
            } else {
                map[s[right]] = 1;
            }
            length = Math.Max(length, map[s[right]]);

            while (right - left + 1 - length > k) {
                char leftChar = s[left];
                map[leftChar]--;
                left++;
            }
            result = Math.Max(result, right - left + 1);
        }
        return result;
    }
}
// @lc code=end

