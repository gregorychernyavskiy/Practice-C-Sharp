/*
 * @lc app=leetcode id=304 lang=csharp
 *
 * [304] Range Sum Query 2D - Immutable
 */

// @lc code=start
// public class NumMatrix {
//     private int[][] matrix;
//     public NumMatrix(int[][] matrix) {
//         this.matrix = matrix;
//     }
    
//     public int SumRegion(int row1, int col1, int row2, int col2) {
//         int sum = 0;
//         for(int i = row1; i <= row2; i++) {
//             for(int j = col1; j <= col2; j++) {
//                 sum += matrix[i][j];
//             }
//         }
//         return sum;
//     }
// }

public class NumMatrix {
    int[,] dp;

    public NumMatrix(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        if(m == 0 || n == 0 ) return ;
        dp = new int[m+1, n+1];
        for(int i=1; i<=m ;i++){
            for(int j=1; j<=n; j++){
                dp[i,j] = dp[i-1,j] + dp[i,j-1] + matrix[i-1][j-1] - dp[i-1,j-1];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return dp[row2+1, col2+1] - dp[row1, col2+1] - dp[row2+1, col1] + dp[row1,col1];
    }
}
/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
// @lc code=end

