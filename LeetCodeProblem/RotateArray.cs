public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        ArraySegment<int> lastSegment = new ArraySegment<int>(nums, nums.Length-k,k);
        ArraySegment<int> firstSegment = new ArraySegment<int>(nums,0,nums.Length-k);

        int[] sol = lastSegment.Concat(firstSegment).ToArray();

        Array.Copy(sol, nums, nums.Length);
    }
}