/*
 * @lc app=leetcode id=42 lang=csharp
 *
 * [42] Trapping Rain Water
 */

// @lc code=start
public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int leftMax = height[left];
        int rightMax = height[right];
        int water = 0;

        while(left < right) {
            if(leftMax < rightMax) {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                water += leftMax - height[left];
            } else {
                right --;
                rightMax = Math.Max(rightMax, height[right]);
                water += rightMax - height[right];
            }
        }
        return water;
    }
}
// @lc code=end

