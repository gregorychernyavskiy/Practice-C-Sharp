/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach(char sch in s) {
            if(map.ContainsKey(sch)) {
                map[sch]++;
            } else {
                map[sch] = 1;
            }
        }
        foreach(char tch in t) {
            if(map.ContainsKey(tch)) {
                map[tch]--;
                if(map[tch] < 0) {
                    return false;
                }
            } else {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

