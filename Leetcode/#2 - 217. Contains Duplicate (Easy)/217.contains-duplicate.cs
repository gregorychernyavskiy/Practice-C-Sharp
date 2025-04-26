/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach(int num in nums) {
            if(set.Contains(num)) {
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}
// @lc code=end

