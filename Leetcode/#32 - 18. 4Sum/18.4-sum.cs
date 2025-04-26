/*
 * @lc app=leetcode id=18 lang=csharp
 *
 * [18] 4Sum
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        List<IList<int>> list = new List<IList<int>>();
        Array.Sort(nums);

        for(int a = 0; a < nums.Length - 3; a++) {
            if(a > 0 && nums[a] == nums[a - 1]) {
                continue;
            }
            for(int b = a + 1; b < nums.Length - 2; b++) {
                if(b > a + 1 && nums[b] == nums[b - 1]) {
                    continue;
                }
                int c = b + 1;
                int d = nums.Length - 1;

                while(c < d) {
                    long total = (long)nums[a] + nums[b] + nums[c] + nums[d];
                    if(total < target) {
                        c++;
                    }
                    else if(total > target) {
                        d--;
                    } else {
                        list.Add(new List<int> {nums[a], nums[b], nums[c], nums[d]});
                        while(c < d && nums[c] == nums[c + 1]) {
                            c++;
                        }
                        while(c < d && nums[d] == nums[d - 1]) {
                            d--;
                        }
                        c++;
                        d--;
                    }
                }
            }
        }
        return list;
    }
}
// @lc code=end

