public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        //Linq
        Dictionary<int,int> countDict = nums.GroupBy(n=>n)
                                        .ToDictionary(g => g.Key, g => g.Count());
        // foreach(var item in nums)
        // {
        //     if(countDict.ContainsKey(item))
        //     {
        //         countDict[item]++;
        //     }
        //     else
        //     {
        //         countDict.Add(item,1);
        //     }
        // }

        var result = countDict.OrderByDescending(kv => kv.Value)
                        .Take(k)
                        .Select(kv=>kv.Key)
                        .ToArray();
        
        return result;

    }
}
