/*
 * @lc app=leetcode id=36 lang=csharp
 *
 * [36] Valid Sudoku
 */

// @lc code=start
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for(int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int i = 0; i < 9; i++) {
            for(int j = 0; j < 9; j++) {
                char value = board[i][j];

                if(value == '.') {
                    continue;
                }
                int boxIndex = (i / 3) * 3 + (j / 3);
                
                if(rows[i].Contains(value) || cols[j].Contains(value) || boxes[boxIndex].Contains(value)) {
                    return false;
                }
                rows[i].Add(value);
                cols[j].Add(value);
                boxes[boxIndex].Add(value);
            }
        }
        return true;
    }
}
// @lc code=end

