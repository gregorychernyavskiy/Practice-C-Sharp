/*
 * @lc app=leetcode id=706 lang=csharp
 *
 * [706] Design HashMap
 */

// @lc code=start
public class MyHashMap {
    int[] map;

    public MyHashMap() {
        map = new int[1000001];
    }
    
    public void Put(int key, int value) {
        map[key] = value + 1;
    }
    
    public int Get(int key) {
        return map[key] - 1;
    }
    
    public void Remove(int key) {
        map[key] = 0;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
// @lc code=end

