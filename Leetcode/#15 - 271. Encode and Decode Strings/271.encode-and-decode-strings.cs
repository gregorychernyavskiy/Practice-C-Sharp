/*
 * @lc app=leetcode id=271 lang=csharp
 *
 * [271] Encode and Decode Strings
 */

// @lc code=start
public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encoded = new StringBuilder();
        foreach (string str in strs) {
            encoded.Append(str.Length).Append('#').Append(str);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            
            int length = int.Parse(s.Substring(i, j - i));
            string word = s.Substring(j + 1, length);
            result.Add(word);
            
            i = j + 1 + length;
        }
        
        return result;
    }
}
// @lc code=end