/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 */

// @lc code=start
public class Solution {
    public void ReverseString(char[] s) {
        int i = 0;
        int j = s.Length - 1;

        while(i < j) {
            char tmp = s[i];
            s[i] = s[j];
            s[j] = tmp;
            i++;
            j--;
        }
    }
}
// @lc code=end

