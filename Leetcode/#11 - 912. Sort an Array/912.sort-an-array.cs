/*
 * @lc app=leetcode id=912 lang=csharp
 *
 * [912] Sort an Array
 */

// @lc code=start
public class Solution {
    public int[] SortArray(int[] nums) {
        return MergeSort(nums, 0, nums.Length - 1);
    }

    private int[] MergeSort(int[] arr, int L, int R) {
        if(L >= R) {
            return arr;
        }
        int M = (L + R) / 2;
        MergeSort(arr, L, M);
        MergeSort(arr, M + 1, R);
        Merge(arr, L, M, R);
        return arr;
    }

    public void Merge(int[] arr, int L, int M, int R) {
        int[] left = new int[M - L + 1];
        int[] right = new int[R - M];

        Array.Copy(arr, L, left, 0, left.Length);
        Array.Copy(arr, M + 1, right, 0, right.Length);

        int i = L;
        int j = 0;
        int k = 0;

        while(j < left.Length && k < right.Length) {
            if(left[j] < right[k]) {
                arr[i] = left[j];
                j++;
                i++;
            } else {
                arr[i] = right[k];
                k++;
                i++;
            }
        }
        while(j < left.Length) {
            arr[i] = left[j];
                j++;
                i++;
        }
        while(k < right.Length) {
            arr[i] = right[k];
                k++;
                i++;
        }
    }
}
// @lc code=end

