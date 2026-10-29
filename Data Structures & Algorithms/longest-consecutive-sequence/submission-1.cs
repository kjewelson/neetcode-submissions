public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums.Length <= 1)
            return nums.Length;

        HashSet<int> numbers = new();

        foreach(var num in nums)
        {
            numbers.Add(num);
        }

        List<int> sorted =  numbers.OrderBy(b=>b).ToList();

        int count = 1;
        int maxCon = 0;

        for(int i=1;i<sorted.Count();i++)
        {
            if(sorted[i]-sorted[i-1] == 1)
            {
                count++;
            }
            else
            {
                maxCon = Math.Max(maxCon, count);
                count = 1;
            }
             
        }   
        maxCon = Math.Max(maxCon, count);




        return maxCon;
    }
}
