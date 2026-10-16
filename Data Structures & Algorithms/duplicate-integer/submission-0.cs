public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> set = new();
        
        for(int i=0;i<nums.Length;i++)
        {
            set.Add(nums[i]);
        }

        // Console.WriteLine($"set.Count(): {set.Count()}");
        var countsEqual = nums.Length==set.Count();
        return !countsEqual;

    }
}