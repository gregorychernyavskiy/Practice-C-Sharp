/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int min = int.MaxValue;

        for(int i = 0; i < prices.Length; i++) {
            if(min > prices[i]) {
                min = prices[i];
            }
            int profit = prices[i] - min;
            max = Math.Max(max, profit);
        }
        return max;
    }
}
// @lc code=end

