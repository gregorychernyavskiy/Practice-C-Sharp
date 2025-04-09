/*
 * @lc app=leetcode id=1768 lang=csharp
 *
 * [1768] Merge Strings Alternately
 */

// @lc code=start
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder st = new StringBuilder();
        int max = Math.Max(word1.Length, word2.Length);

        for(int i = 0; i < max; i++) {
            if(i < word1.Length) {
                st.Append(word1[i]);
            }
            if(i < word2.Length) {
                st.Append(word2[i]);
            }
        }
        return st.ToString();
    }
}

// public class Solution {
//     public string MergeAlternately(string word1, string word2) {
//         int len1 = word1.Length;
//         int len2 = word2.Length;
//         int minLength = Math.Min(len1, len2);
//         char[] arr = new char[len1 + len2];
//         int j = 0;
        
//         for (int i = 0; i < minLength; i++) {
//             arr[j++] = word1[i];
//             arr[j++] = word2[i];
//         }

//         for (int i = minLength; i < len1; i++) {
//             arr[j++] = word1[i];
//         }
        
//         for (int i = minLength; i < len2; i++) {
//             arr[j++] = word2[i];
//         }
//         return new string(arr);
//     }
// }
// @lc code=end

