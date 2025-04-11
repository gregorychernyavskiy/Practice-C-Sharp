/*
 * @lc app=leetcode id=189 lang=csharp
 *
 * [189] Rotate Array
 */

// @lc code=start
public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;

        swap(nums, 0, nums.Length - 1);
        swap(nums, 0, k - 1);
        swap(nums, k, nums.Length - 1);
    }

    private void swap(int[] arr, int left, int right) {
        while(left < right) {
            int tmp = arr[left];
            arr[left] = arr[right];
            arr[right] = tmp;
            left++;
            right--;
        }
    }
}
// @lc code=end

