public class RandomizedSet {
    List<int> nums;
    Dictionary<int,int> HashMap;
    Random random = new();

    public RandomizedSet() {
        nums = new();
        HashMap = new();
    }
    
    public bool Insert(int val) {
        if(HashMap.ContainsKey(val))
            return false;
        nums.Add(val);
        HashMap[val] = nums.Count - 1;
        return true;    
    }
    
    public bool Remove(int val) {
        if(HashMap.ContainsKey(val)){
            int lastElement = nums[nums.Count - 1];
            int value = HashMap[val];

            nums[value] = lastElement;
            HashMap[lastElement] = value;

            nums.RemoveAt(nums.Count - 1);
            HashMap.Remove(val);
            return true;
        }
        return false;
    }
    
    public int GetRandom() => nums[random.Next(nums.Count)];
    
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */