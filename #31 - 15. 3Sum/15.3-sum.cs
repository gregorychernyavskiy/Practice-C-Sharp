/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> list = new  List<IList<int>>();
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++) {
            if(i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            int j = i + 1;
            int k = nums.Length - 1;

            while(j < k) {
                int total = nums[i] + nums[j] + nums[k];
                if(total > 0) {
                    k--;
                } else if(total < 0) {
                    j++;
                } else {
                    list.Add(new List<int> {nums[i], nums[j], nums[k]});
                    j++;
                    while(j < k && nums[j] == nums[j - 1]) {
                        j++;
                    }
                }
            }
        }
        return list;
    }
}
// @lc code=end

