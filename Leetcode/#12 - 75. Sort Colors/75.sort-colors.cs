/*
 * @lc app=leetcode id=75 lang=csharp
 *
 * [75] Sort Colors
 */

// @lc code=start
public class Solution {
    public void SortColors(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
    }

    private void MergeSort(int[] arr, int L, int R) {
        if (L >= R) return;

        int M = (L + R) / 2;
        MergeSort(arr, L, M);
        MergeSort(arr, M + 1, R);
        Merge(arr, L, M, R);
    }

    private void Merge(int[] nums, int L, int M, int R) {
        int[] tmp = new int[R - L + 1];
        int i = L;
        int j = M + 1;
        int k = 0;

        while (i <= M && j <= R) {
            if (nums[i] <= nums[j]) {
                tmp[k++] = nums[i++];
            } else {
                tmp[k++] = nums[j++];
            }
        }

        while (i <= M) {
            tmp[k++] = nums[i++];
        }

        while (j <= R) {
            tmp[k++] = nums[j++];
        }

        for (int q = 0; q < tmp.Length; q++) {
            nums[L + q] = tmp[q];
        }
    }
}

// @lc code=end

