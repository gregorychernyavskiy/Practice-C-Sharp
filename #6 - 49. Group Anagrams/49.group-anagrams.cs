/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string str in strs) {
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            string sorted = new string(ch);
            
            if(!map.ContainsKey(sorted)) {
                map[sorted] = new List<string>();
            }
            map[sorted].Add(str);
        }
        return new List<IList<string>>(map.Values);
    }
}
// @lc code=end

