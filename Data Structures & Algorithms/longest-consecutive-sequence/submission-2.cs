public class Solution {
    public int LongestConsecutive(int[] nums) {

        //OPTIMAL Solution 
        HashSet<int> numbers = new();

        foreach(var num in nums)
            numbers.Add(num);

        int maxCon = 0;

        foreach(var num in numbers)
        {
            if(!numbers.Contains(num-1))
            {
                int current = num;
                int count = 1;
            

            while(numbers.Contains(current+1))
            {
                count++;
                current++; 
            } 
            

            maxCon = Math.Max(count, maxCon);
            
            }

        }

        return maxCon;




        //MY SOLUTION 
        
        // if(nums.Length <= 1)
        //     return nums.Length;

        // HashSet<int> numbers = new();

        // foreach(var num in nums)
        // {
        //     numbers.Add(num);
        // }

        // List<int> sorted =  numbers.OrderBy(b=>b).ToList();

        // int count = 1;
        // int maxCon = 0;

        // for(int i=1;i<sorted.Count();i++)
        // {
        //     if(sorted[i]-sorted[i-1] == 1)
        //     {
        //         count++;
        //     }
        //     else
        //     {
        //         maxCon = Math.Max(maxCon, count);
        //         count = 1;
        //     }
             
        // }   
        // maxCon = Math.Max(maxCon, count);
        // return maxCon;




    }
}
