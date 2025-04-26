/*
 * @lc app=leetcode id=682 lang=csharp
 *
 * [682] Baseball Game
 */

// @lc code=start
public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> st = new Stack<int>();

        foreach(string op in operations) {
            if(op == "+") {
                int top = st.Pop();
                int second = st.Peek();
                st.Push(top);
                st.Push(top + second);
            }
            else if(op == "C") {
                st.Pop();
            }
            else if(op == "D") {
                st.Push(st.Peek() * 2);
            } else {
                st.Push(int.Parse(op)); //this converts a string to an integer
            }
        }
        int answer = 0;
        foreach(int num in st) {
            answer += num;
        }
        return answer;
    }
}
// @lc code=end

