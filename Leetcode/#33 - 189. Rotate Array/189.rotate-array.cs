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

// public class Solution {
//     public void Rotate(int[] nums, int k) {
//         int[] arr = new int[nums.Length];
//         int count = 0;

//         if(k == 0 || k == null) return;
//         if(nums.Length == 0 || nums.Length == null) return;

//         k = k % nums.Length;
//         if(k == 0) return;

//         for(int i = nums.Length - k; i < nums.Length; i++) {
//             arr[count] = nums[i];
//             count++;
//         }
//         for(int i = 0; i < nums.Length - k; i++) {
//             arr[count] = nums[i];
//             count++;
//         }
//         for(int i = 0; i < nums.Length; i++) {
//             nums[i] = arr[i];
//         }
//     }
// }
// @lc code=end

