/*
 * @lc app=leetcode id=1295 lang=csharp
 *
 * [1295] Find Numbers with Even Number of Digits
 */

// @lc code=start
public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;

        foreach(int num in nums) {
            int digits = 0;
            int current = num;
            while(current > 0) {
                current = current / 10;
                digits++;
            }
            if(digits % 2 == 0) {
                count++;
            }
        }
        return count;
    }
}
// @lc code=end

