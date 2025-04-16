/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        
        foreach (char ch in s) {
            if (ch == '(' || ch == '[' || ch == '{') {
                st.Push(ch);
            } else if (ch == ')' || ch == ']' || ch == '}') {
                if (st.Count == 0) {
                    return false;
                }
                if ((ch == ')' && st.Pop() != '(') ||
                    (ch == ']' && st.Pop() != '[') ||
                    (ch == '}' && st.Pop() != '{')) {
                    return false;
                }
            }
        }
        return st.Count == 0;
    }
}
// @lc code=end

