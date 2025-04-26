/*
 * @lc app=leetcode id=76 lang=csharp
 *
 * [76] Minimum Window Substring
 */

// @lc code=start
public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach (char tch in t) {
            if (map.ContainsKey(tch)) {
                map[tch]++;
            } else {
                map[tch] = 1;
            }
        }
        int left = 0;
        int length = int.MaxValue;
        int required = t.Length;
        int start = left;

        for (int right = 0; right < s.Length; right++) {
            char ch = s[right];
            if (map.ContainsKey(ch)) {
                map[ch]--;
                if (map[ch] >= 0) {
                    required--;
                }
            }
            while (required == 0) {
                if (right - left + 1 < length) {
                    length = right - left + 1;
                    start = left;
                }
                char leftCh = s[left];
                if (map.ContainsKey(leftCh)) {
                    map[leftCh]++;
                    if (map[leftCh] > 0) {
                        required++;
                    }
                }
                left++;
            }
        }
        if (length == int.MaxValue) {
            return "";
        } else {
            return s.Substring(start, length);
        }
    }
}
// @lc code=end

