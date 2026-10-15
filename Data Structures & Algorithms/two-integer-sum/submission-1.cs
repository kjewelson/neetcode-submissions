public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> dict = new ();
        
        for(int i=0;i<nums.Length;i++)
        {
            dict[nums[i]]=i;
        }

        for(int i=0;i<nums.Length;i++)
        {
            var sub = target-nums[i];
            if(dict.ContainsKey(sub) && dict[sub] != i)
            {
                return [i,dict[sub]];
            }
        }

        return new int[] {};


    }
}
