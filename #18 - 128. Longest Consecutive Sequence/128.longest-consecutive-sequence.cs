/*
 * @lc app=leetcode id=128 lang=csharp
 *
 * [128] Longest Consecutive Sequence
 */

// @lc code=start
class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        int answer = 0;

        foreach(int num in nums) {
            set.Add(num);
        }

        foreach(int num in set) {
            if(!set.Contains(num - 1)) {
                int streak = 1;
                int count = num;

                while(set.Contains(count + 1)) {
                    count++;
                    streak++;
                }
                answer = Math.Max(streak, answer);
            }
        }
        return answer;
    }
}
// @lc code=end

