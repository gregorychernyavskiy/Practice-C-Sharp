/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        char[] ch = s.ToCharArray();
        char[] arr = new char[s.Length]; // this length will change tho, since we will remove spaces and special characters.
        int count = 0;

        for(int i = 0; i < ch.Length; i++) {
            if(char.IsLetterOrDigit(ch[i])) {
                arr[count] = char.ToLower(ch[i]);
                count++;
            }
        }

        int left = 0;
        int right = count - 1;

        while(left < right) {
            if(arr[left] != arr[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
// @lc code=end

