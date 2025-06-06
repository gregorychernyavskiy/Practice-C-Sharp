/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Find the Index of the First Occurrence in a String
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(haystack.Length < needle.Length) {
            return -1;
        }
        for(int i = 0; i <= haystack.Length - needle.Length; i++) {
            if(haystack.Substring(i, needle.Length).Equals(needle)) {
                return i;
            }
        }
        return -1;
    }
}
// @lc code=end

