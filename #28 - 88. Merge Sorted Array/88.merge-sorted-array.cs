/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (nums1 == null || nums2 == null) return;
        if (nums1.Length < m + n) return;
        if (nums2.Length < n) return;
        if (n == 0) return;

        int j = 0;
        for (int i = 0; i < nums1.Length && j < n; i++) {
            if (nums1[i] == 0) {
                nums1[i] = nums2[j];
                j++;
            }
        }
        Array.Sort(nums1);
    }
}
// @lc code=end

