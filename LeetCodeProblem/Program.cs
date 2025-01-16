public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> sol = new();
        for (int i = 0; i < nums.Length; i++)
        {
           for (int j = i+1; j < nums.Length ; j++){
            if (nums[i]+nums[j] == target){
                sol.Add(i);
                sol.Add(j);
           }}
        }
        return sol.ToArray();
    }
}